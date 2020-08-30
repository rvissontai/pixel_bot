using System;

namespace MiniBot.Domain.Models.Configuration
{
    [Serializable]
    public class ConfigurationBarModel
    {
        public int UseAtPercent { get; set; }
        public string HotKey { get; set; }
        public bool Active { get; set; }

        public int FirstPixelX { get; set; }
        public int FirstPixelY { get; set; }

        public int LastPixelX { get; set; }
        public int LastPixelY { get; set; }

        public int SizeInPixels { get; set; }

        public int TargetPixelBasedOnPercent { get; set; }
    }
}
