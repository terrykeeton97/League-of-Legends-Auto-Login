using AutoIt;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Threading;

namespace Auto_Login.Classes
{
    internal class LocalClientController
    {

        internal static IntPtr hWnd;

        internal static void RestartClient()
        {
            bool isOpen = false;
            var proc = Process.GetProcesses();
            var client = new Process { StartInfo = new ProcessStartInfo { FileName = ClientInfo(false, true) } };
            uint lClient = AutoItX.WinGetProcess("League of Legends");
            try
            {
                foreach (var prs in proc)
                {
                    if (prs.Id == lClient)
                    {
                        isOpen = true;
                        CloseLeagueClient();
                        prs.WaitForExit();
                    }
                }

                foreach (var process in Process.GetProcessesByName("RiotClientUx"))
                {
                    isOpen = true;
                    process.Refresh();
                    process.Kill();
                    process.WaitForExit();
                    Program.main.Log("Closing process");
                }
            }
            catch 
            {
                Program.main.Log("Unable to close client");
            }
            if (isOpen)
            {
                Program.main.Log("Starting client in 10 seconds");
                Program.main.Log("League client can take some time to close...");
                Thread.Sleep(10000);
            }

            Program.main.Log("Starting client");
            client.Start();
            client.Refresh();
            Program.main.Log("Waiting for client to idle");
            client.WaitForInputIdle();
        }

        internal static void Init()
        {
            Program.main.Log("Initializing");
            RestartClient();
            hWnd = Imports.FindWindow("RCLIENT", "Riot Client Main");
            if (hWnd != IntPtr.Zero)
            {
                Program.main.Log("Moving window to 0,0");
                Imports.SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, Imports.SWP_NOSIZE | Imports.SWP_NOZORDER);
            }
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
        private static void CloseLeagueClient()
        {
            hWnd = Imports.FindWindow("RCLIENT", "League of Legends");
            if (hWnd != IntPtr.Zero)
            {
                Program.main.Log("Moving League window to 0,0");
                Imports.SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, Imports.SWP_NOSIZE | Imports.SWP_NOZORDER);
                var WINDOW_RECT = AutoItX.WinGetClientSize(hWnd);
                Program.main.Log($"League window size: {WINDOW_RECT.Width} | {WINDOW_RECT.Height}");

                if(Properties.Settings.Default.blockInput)
                    Imports.BlockInput(true);

                AutoItX.PixelSearch(WINDOW_RECT, 0xA09B8C);
                Program.main.Log("Moving mouse");
                AutoItX.MouseMove(1574, 18);
                AutoItX.MouseClick("LEFT");
                AutoItX.MouseMove(724, 502);
                AutoItX.MouseClick("LEFT");
                Imports.BlockInput(false);
            }
        }
    }
}
