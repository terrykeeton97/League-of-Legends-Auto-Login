using System.IO;

namespace Auto_Login.Classes
{
    internal class FileController
    { 
        internal static void SetYAMLFile(byte[] server)
        {
            Program.main.Log("Writing configuration file");
            File.WriteAllBytes(LocalClientController.ClientInfo(true), server);
        }

    }
}
