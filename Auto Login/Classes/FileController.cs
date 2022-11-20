using System;
using System.IO;
using YamlDotNet.Serialization;

namespace Auto_Login.Classes
{
    internal class FileController
    {
        internal static void Init(string region)
        {
            if(Properties.Settings.Default.persistedSettings)
            {
                File.SetAttributes(LocalClientController.ClientInfo() + @"\Config\game.cfg", FileAttributes.ReadOnly);
                File.SetAttributes(LocalClientController.ClientInfo() + @"\Config\PersistedSettings.json", FileAttributes.ReadOnly);
            }
            File.SetAttributes(LocalClientController.ClientInfo() + @"\Config\game.cfg", FileAttributes.Normal);
            File.SetAttributes(LocalClientController.ClientInfo() + @"\Config\PersistedSettings.json", FileAttributes.Normal);

            var LEAGUE_CLIENT_SETTINGS = new DeserializerBuilder().Build();
            LEAGUE_CLIENT_SETTINGS.Deserialize<Object>(File.ReadAllText(LocalClientController.ClientInfo(true)));
        }
    }
    class YamlObject
    {
        public string install { get; set; }
        public string locale { get; set; }
        public string region { get; set; }
    }
}
