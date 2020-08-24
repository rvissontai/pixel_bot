using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MiniBot.Infra.CrossCutting;
using Newtonsoft.Json;

namespace MiniBot.Core
{
    public class Configuration
    {
        private static string ConfigFile = Path.Combine(Directory.GetCurrentDirectory(), "config.json");

        private static ConfigurationModel Instance {get;set; }

        private static Form MainForm { get; set; }

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

        public static ConfigurationModel Load(Form mainForm)
        {
            MainForm = mainForm;

            if (!File.Exists(ConfigFile))
            {
                Instance = new ConfigurationModel();
                Save();
            }

            using (var sr = new StreamReader(ConfigFile))
                Instance = JsonConvert.DeserializeObject<ConfigurationModel>(sr.ReadToEnd());

            return Instance;
        }

        public static void FindBarsPotision()
        {
            TibiaClient.SetForeground();
            Thread.Sleep(250);

            var screenShot = Screenshot.FullDesktop();

            HealthBar.Find(screenShot);
        }
    }
}
