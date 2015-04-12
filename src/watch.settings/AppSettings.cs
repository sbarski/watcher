using System.IO;
using Newtonsoft.Json;

namespace watch.settings
{
    public class AppSettings
    {
        public static void Save(Settings settings, string settingsFilePath)
        {
            File.WriteAllText(settingsFilePath, JsonConvert.SerializeObject(settings));
        }

        public static Settings Load(string settingsFilePath)
        {
            var settings = new Settings();

            if (File.Exists(settingsFilePath))
            {
                settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(settingsFilePath));
            }

            return settings;
        }
    }
}
