using System.IO;
using Newtonsoft.Json;

namespace MiniBot.Core
{
    public class Configuration
    {
        private static string ConfigFile = Path.Combine(Directory.GetCurrentDirectory(), "config.json");

        public static void Save(ConfigurationModel model)
        {
            using (var sw = new StreamWriter(ConfigFile))
                sw.Write(JsonConvert.SerializeObject(model, Formatting.Indented));
        }

        public static ConfigurationModel Load()
        {
            ConfigurationModel model;

            if (!File.Exists(ConfigFile))
            {
                model = new ConfigurationModel();
                Save(model);
            }

            using (var sr = new StreamReader(ConfigFile))
                model = JsonConvert.DeserializeObject<ConfigurationModel>(sr.ReadToEnd());

            return model;
        }
    }
}
