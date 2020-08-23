using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;

namespace MiniBot.Core
{
    public class Configuration
    {
        private static string ConfigFile = Path.Combine(Directory.GetCurrentDirectory(), "config.json");

        private static ConfigurationModel Instance {get;set; }

        private Configuration()
        {
        }

        public static ConfigurationModel Settings
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new ConfigurationModel();
                }
                return Instance;
            }
        }

        public static void Save()
        {
            using (var sw = new StreamWriter(ConfigFile))
                sw.Write(JsonConvert.SerializeObject(Instance, Formatting.Indented));
        }

        public static ConfigurationModel Load()
        {
            if (!File.Exists(ConfigFile))
            {
                Instance = new ConfigurationModel();
                Save();
            }

            using (var sr = new StreamReader(ConfigFile))
                Instance = JsonConvert.DeserializeObject<ConfigurationModel>(sr.ReadToEnd());

            return Instance;
        }
    }
}
