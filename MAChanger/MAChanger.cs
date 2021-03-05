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
#if NET5_0 || NET6_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.Run(new MAIN());
        }
    }
}