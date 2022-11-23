using System.IO;
using YamlDotNet.Serialization;

namespace Auto_Login.Classes
{
    internal class FileController
    {
        internal static void Init(string region, string prefLanguage)
        {
            if(Properties.Settings.Default.persistedSettings)
            {
                File.SetAttributes(LocalClientController.ClientInfo() + @"\Config\game.cfg", FileAttributes.ReadOnly);
                File.SetAttributes(LocalClientController.ClientInfo() + @"\Config\PersistedSettings.json", FileAttributes.ReadOnly);
            }
            File.SetAttributes(LocalClientController.ClientInfo() + @"\Config\game.cfg", FileAttributes.Normal);
            File.SetAttributes(LocalClientController.ClientInfo() + @"\Config\PersistedSettings.json", FileAttributes.Normal);

            var deserializer = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();
            var serializer = new SerializerBuilder().Build();
            var settings = deserializer.Deserialize<YamlObject>(File.ReadAllText(LocalClientController.ClientInfo(true)));
            settings.Install.Globals.Region = region;
            settings.Install.Globals.Locale = prefLanguage;
            File.WriteAllText(LocalClientController.ClientInfo(true), serializer.Serialize(settings));
        }
    }
    public class YamlObject
    {
        [YamlMember(Alias = "install")]
        public Install Install { get; set; }
    }

    public class Install
    {
        [YamlMember(Alias = "globals")]
        public Globals Globals { get; set; }
    }
    public class Globals
    {
        [YamlMember(Alias = "locale")]
        public string Locale { get; set; }
        [YamlMember(Alias = "region")]
        public string Region { get; set; }
    }
}
