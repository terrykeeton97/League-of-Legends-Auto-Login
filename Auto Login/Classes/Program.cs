using Auto_Login.Properties;
using System;
using System.Windows.Forms;

namespace Auto_Login
{
    internal static class Program
    {
        public static Main main;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(main = new Main());
        }
    }
}
