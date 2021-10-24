using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace ABCSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new WelcomeMenu());
                Application.Run(new MainMenu());
            }
            catch
            {
                Application.Exit();
            }
        }
    }
}
