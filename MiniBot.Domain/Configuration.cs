using System.IO;
using System.Threading;
using System.Windows.Forms;
using MiniBot.Domain.Models;
using MiniBot.Domain.Models.Configuration;
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
            CalculateTargetPixel();

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
            BindConfigurationBarPositionModel(Instance.Health, HealthBarPosition);
            BindConfigurationBarPositionModel(Instance.Mana, ManaBarPosition);
        }

        private static void BindConfigurationBarPositionModel(ConfigurationBarModel configurationModel, BarPositionModel barPositionModel)
        {
            configurationModel.FirstPixelX  = barPositionModel.FirstPixelX;
            configurationModel.FirstPixelY  = barPositionModel.FirstPixelY;
            configurationModel.LastPixelX   = barPositionModel.LastPixelX;
            configurationModel.LastPixelY   = barPositionModel.LastPixelY;
            configurationModel.SizeInPixels = barPositionModel.SizeInPixels;
        }

        private static void CalculateTargetPixel()
        {
            Instance.Health.TargetPixelBasedOnPercent = ((Instance.Health.SizeInPixels / 100) * Instance.Health.UseAtPercent) + Instance.Health.FirstPixelX;
            Instance.Mana.TargetPixelBasedOnPercent = ((Instance.Mana.SizeInPixels / 100) * (100 - Instance.Mana.UseAtPercent)) + Instance.Mana.FirstPixelX;
        }
    }
}
