using AutoIt;
using System;
using System.IO;

namespace Auto_Login.Classes
{
    internal class Login
    {

        internal static void Start(string username, string password, string region)
        {
            Program.main.Log($"Setting server to {region}");
            FileController.Init(region);

            if(LocalClientController.StartClient())
            {
                Program.main.Log("Getting window size");
                IntPtr hWnd = Imports.FindWindow("RCLIENT", "Riot Client Main");
                var WINDOW_RECT = AutoItX.WinGetClientSize(hWnd);
                Program.main.Log($"Window size: {WINDOW_RECT.Width} | {WINDOW_RECT.Height}");
                AutoItX.PixelSearch(WINDOW_RECT, 0xEDEDED);
                Program.main.Log("Moving mouse");
                AutoItX.MouseMove(236, 254);
                AutoItX.MouseClick("LEFT");
                Program.main.Log("Sending username");
                AutoItX.Send(username);
                Program.main.Log("Moving mouse");
                AutoItX.MouseMove(209, 323);
                AutoItX.MouseClick("LEFT");
                Program.main.Log("Sending decrypted password");
                AutoItX.Send(password);
                Program.main.Log("Logging in");
                AutoItX.PixelSearch(WINDOW_RECT, 0xD13639);
                AutoItX.MouseMove(194, 670);
                AutoItX.MouseClick("LEFT");
                Program.main.Log("Successfully logged in");
            }
            Program.main.Show();
        }

    }
}
