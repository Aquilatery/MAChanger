using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace MAChanger
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            foreach (NetworkInterface Adapter in NetworkInterface.GetAllNetworkInterfaces().Where(FA => Adapter.ControlMAC(FA.GetPhysicalAddress().GetAddressBytes(), true)).OrderByDescending(FA => FA.IsReceiveOnly))
                Adapters.Items.Add(new Adapter(Adapter));

            if (Adapters.Items.Count > 0)
                Adapters.SelectedIndex = Adapters.Items.Count - 1;
        }

        public void UA()
        {
            Adapter MAC = Adapters.SelectedItem as Adapter;
            CurrentMAC.Text = MAC.GMAC;
            if (!string.IsNullOrEmpty(MAC.RegistryMAC))
                NewMAC.Text = MAC.RegistryMAC;
            else
                NewMAC.Text = CurrentMAC.Text;
        }

        private void Refresh_Click(object sender, System.EventArgs e)
        {
            UA();
        }

        private void Adapters_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UA();
        }

        private void Summon_Click(object sender, System.EventArgs e)
        {
            NewMAC.Text = Adapter.CreateMAC();
        }

        private void NewMAC_TextChanged(object sender, System.EventArgs e)
        {
            SAVE.Enabled = Adapter.ControlMAC(NewMAC.Text, false);
        }

        private void SAVE_Click(object sender, System.EventArgs e)
        {
            if (!Adapter.ControlMAC(NewMAC.Text, false))
                MessageBox.Show("Girilen MAC Adresi Geçersiz, Güncellenmeyecek!", "Geçersiz MAC Adresi Belirtildi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            SetMAC(NewMAC.Text);
        }

        private void BACK_Click(object sender, System.EventArgs e)
        {
            SetMAC("");
        }

        public void SetMAC(string MAC)
        {
            Adapter Adapter = Adapters.SelectedItem as Adapter;

            if (Adapter.SetRegistryMAC(MAC))
            {
                Thread.Sleep(50);
                UA();
                MessageBox.Show("Güzel!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}