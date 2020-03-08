using System;
using System.Linq;
using Microsoft.Win32;
using System.Management;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace MAChanger
{
    public class Adapter
    {
        public ManagementObject VAdapter;
        public string AdapterName;
        public string CustomName;
        public int DevNum;

        private Adapter(ManagementObject A, string AName, string CName, int DN)
        {
            VAdapter = A;
            AdapterName = AName;
            CustomName = CName;
            DevNum = DN;
        }

        public Adapter(NetworkInterface i) : this(i.Description) { }

        private Adapter(string AName)
        {
            AdapterName = AName;

            var Searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE Name='" + AdapterName + "'");
            var Found = Searcher.Get();
            VAdapter = Found.Cast<ManagementObject>().FirstOrDefault();

            try
            {
                var Match = Regex.Match(VAdapter.Path.RelativePath, "\\\"(\\d+)\\\"$");
                DevNum = int.Parse(Match.Groups[1].Value);
            }
            catch
            {
                return;
            }

            CustomName = NetworkInterface.GetAllNetworkInterfaces().Where(o => o.Description == AdapterName).Select(o => " (" + o.Name + ")").FirstOrDefault();
        }

        private NetworkInterface ManagedAdapter
        {
            get
            {
                return NetworkInterface.GetAllNetworkInterfaces().Where(ANI => ANI.Description == AdapterName).FirstOrDefault();
            }
        }

        public string GMAC
        {
            get
            {
                try
                {
                    return BitConverter.ToString(ManagedAdapter.GetPhysicalAddress().GetAddressBytes()).Replace("-", "").ToUpper();
                }
                catch
                {
                    return null;
                }
            }
        }

        private string RegistryKey
        {
            get
            {
                return String.Format(@"SYSTEM\ControlSet001\Control\Class\{{4D36E972-E325-11CE-BFC1-08002BE10318}}\{0:D4}", DevNum);
            }
        }

        public string RegistryMAC
        {
            get
            {
                try
                {
                    using (RegistryKey RegKey = Registry.LocalMachine.OpenSubKey(RegistryKey, false))
                        return RegKey.GetValue("NetworkAddress").ToString();
                }
                catch
                {
                    return null;
                }
            }
        }

        public bool SetRegistryMAC(string Value)
        {
            bool ShouldReenable = false;
            try
            {
                if (Value.Length > 0 && !ControlMAC(Value, false))
                    throw new Exception(Value + " Geçerli Bir MAC Adresi Değil!");
                else
                {
                    using (RegistryKey RegKey = Registry.LocalMachine.OpenSubKey(RegistryKey, true))
                    {
                        if (RegKey == null)
                            throw new Exception("Kayıt Defteri Anahtarı Açılamadı!");
                        else if (RegKey.GetValue("AdapterModel") as string != AdapterName && RegKey.GetValue("DriverDesc") as string != AdapterName)
                            throw new Exception("Adaptör Kayıt Defterinde Bulunamadı!");
                        else
                        {
                            string Question = Value.Length > 0 ? "{0} Adaptörünün {1} Olan MAC Adresi {2} Olarak Değiştirilsin Mi?" : "{0} Adaptörünün MAC Adresinin Ayarları Geri Çekilsin Mi?";
                            DialogResult Proceed = MessageBox.Show(String.Format(Question, ToString(), GMAC, Value), "MAC Adresi Değiştirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Proceed != DialogResult.Yes)
                                return false;
                            else
                            {
                                var Result = (uint)VAdapter.InvokeMethod("Disable", null);
                                if (Result != 0)
                                    throw new Exception("Adaptör Devre Dışı Bırakılamadı!");
                                else
                                {
                                    ShouldReenable = true;

                                    if (Value.Length > 0)
                                        RegKey.SetValue("NetworkAddress", Value, RegistryValueKind.String);
                                    else if (!string.IsNullOrEmpty(RegKey.GetValue("NetworkAddress") as string))
                                        RegKey.DeleteValue("NetworkAddress");

                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
                return false;
            }
            finally
            {
                if (ShouldReenable)
                {
                    uint Result = (uint)VAdapter.InvokeMethod("Enable", null);
                    if (Result != 0)
                        MessageBox.Show("Adaptör Yeniden Aktifleştirilemedi!");
                }
            }
        }

        public override string ToString()
        {
            return AdapterName + CustomName;
        }

        public static string CreateMAC()
        {
            Random RM = new Random();

            byte[] Bytes = new byte[6];
            RM.NextBytes(Bytes);

            Bytes[0] = (byte)(Bytes[0] | 0x02);
            Bytes[0] = (byte)(Bytes[0] & 0xfe);

            return MACToString(Bytes);
        }

        public static bool ControlMAC(string MAC, bool Actual)
        {
            if (MAC.Length != 12)
                return false;
            else if (MAC != MAC.ToUpper())
                return false;
            else if (!Regex.IsMatch(MAC, "^[0-9A-F]*$"))
                return false;
            else if (Actual)
                return true;
            else
            {
                char C = MAC[1];
                return C == 'A' || C == 'E' || C == '2' || C == '6';
            }
        }

        public static bool ControlMAC(byte[] Bytes, bool Actual)
        {
            return ControlMAC(Adapter.MACToString(Bytes), Actual);
        }

        private static string MACToString(byte[] Bytes)
        {
            return BitConverter.ToString(Bytes).Replace("-", "").ToUpper();
        }
    }
}