using System;
using System.Windows.Forms;

namespace MAChanger
{
    static class MAChanger
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MAIN());
        }
    }
}