using System;
using System.Windows.Forms;

namespace MAChanger
{
    internal static class MAChanger
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MAIN());
        }
    }
}