using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace MAChanger
{
    public partial class LAST : Form
    {
        public LAST()
        {
            InitializeComponent();
        }

        private void LAST_Load(object sender, EventArgs e)
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
            SAVE.Enabled = (CurrentMAC.Text != NewMAC.Text);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            UA();
        }

        private void Adapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            UA();
        }

        private void Summon_Click(object sender, EventArgs e)
        {
            NewMAC.Text = Adapter.CreateMAC();
        }

        private void NewMAC_TextChanged(object sender, EventArgs e)
        {
            SAVE.Enabled = (Adapter.ControlMAC(NewMAC.Text, false) == (CurrentMAC.Text != NewMAC.Text));
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (Adapter.ControlMAC(NewMAC.Text, false))
                SetMAC(NewMAC.Text, "Change MAC Address");
            else
                MessageBox.Show("The MAC Address Entered is Invalid, It Will Not Be Updated!", "Invalid MAC Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            SetMAC("", "Undo MAC Address");
        }

        public void SetMAC(string MAC, string Title)
        {
            Adapter Adapter = Adapters.SelectedItem as Adapter;

            if (Adapter.SetRegistryMAC(MAC, Title))
            {
                Thread.Sleep(111);
                MessageBox.Show("MAC Address Successfully Changed!", Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                UA();
            }
        }
    }
}