using AutoIt;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Auto_Login.Classes
{
    internal class LocalClientController
    {

        internal static string[] WINDOW_NAMES = { "RiotClientUx", "LeagueClientUxRender", "LeagueClientUx" };
        private static bool CheckForWindows()
        {
            Process[] client = WINDOW_NAMES.SelectMany(name => Process.GetProcessesByName(name)).ToArray();
            if (client.Length == 0)
                return false;

            Program.main.Log("Client & windows found");
            MessageBox.Show("Please close the client and any related windows", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        internal static bool StartClient()
        {
            if (!CheckForWindows())
            {
                Program.main.Log("Attemping to start the client");
                Process.Start(ClientInfo(false, true, false));


                AutoItX.ProcessWait("RiotClientUx", 10);
                IntPtr hWnd = Imports.FindWindow("RCLIENT", "Riot Client Main");
                if (hWnd != IntPtr.Zero)
                {
                    Program.main.Log("Moving window to 0,0");
                    Imports.SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, Imports.SWP_NOSIZE | Imports.SWP_NOZORDER);
                    Thread.Sleep(1000);
                    return true;
                }           
            }
            return false;
        }

        internal static string ClientInfo(bool configLocation = false, bool exeLocation = false, bool cfgLocation = false)
        {
            var reg = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\Riot Game league_of_legends.live", "InstallLocation", null);
            string path;
            if (cfgLocation)
            {
                path = reg.ToString() + @"\Config\game.cfg";
                return path;
            }
            if (exeLocation)
            {
                path = reg.ToString() + @"\LeagueClient.exe";
                return path;
            }
            if (configLocation)
            {
                path = reg.ToString() + @"\Config\LeagueClientSettings.yaml";
                return path;
            }
            path = reg.ToString();
            return path;
        }
    }
}
