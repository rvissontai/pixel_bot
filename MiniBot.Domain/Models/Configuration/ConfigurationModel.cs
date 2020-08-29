using MiniBot.Domain.Models.Configuration;
using System;

namespace MiniBot.Core
{
    [Serializable]
    public class ConfigurationModel
    {
        public ConfigurationModel()
        {
            Health = new ConfigurationBarModel();
            Mana = new ConfigurationBarModel();
        }

        public ConfigurationBarModel Health { get; set; }

        public ConfigurationBarModel Mana { get; set; }
    }
}
