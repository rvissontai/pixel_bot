using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MiniBot.Domain.Models;
using MiniBot.Infra.CrossCutting;
using Newtonsoft.Json;

namespace MiniBot.Core
{
    public class Configuration
    {
        private static string ConfigFile = Path.Combine(Directory.GetCurrentDirectory(), "config.json");

        private static ConfigurationModel Instance {get;set; }

        private static Form MainForm { get; set; }

        private static BarPositionModel HealthBarPosition { get; set; }

        private static BarPositionModel ManaBarPosition { get; set; }

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

        public static void FindHealthAndManaBar()
        {
            TibiaClient.SetForeground();
            Thread.Sleep(350);

            var screenShot = Screenshot.FullDesktop();

            HealthBarPosition = new HealthBar().Find(screenShot);
            ManaBarPosition   = new ManaBar().Find(screenShot);

            screenShot.Dispose();

            CopyBarsCoordinatesToConfigurationModel();

            Save();
        }

        private static void CopyBarsCoordinatesToConfigurationModel()
        {
            Instance.Health.FirstPixelX = HealthBarPosition.FirstPixelX;
            Instance.Health.FirstPixelY = HealthBarPosition.FirstPixelY;
            Instance.Health.LastPixelX = HealthBarPosition.LastPixelX;
            Instance.Health.LastPixelY = HealthBarPosition.LastPixelY;
            Instance.Health.SizeInPixels = HealthBarPosition.SizeInPixels;

            Instance.Mana.FirstPixelX = ManaBarPosition.FirstPixelX;
            Instance.Mana.FirstPixelY = ManaBarPosition.FirstPixelY;
            Instance.Mana.LastPixelX = ManaBarPosition.LastPixelX;
            Instance.Mana.LastPixelY = ManaBarPosition.LastPixelY;
            Instance.Mana.SizeInPixels = ManaBarPosition.SizeInPixels;
        }
    }
}
