using MiniBot.Core;
using MiniBot.Infra.CrossCutting;
using System;
using System.Threading;
using System.Windows.Forms;
using t = System.Timers;

namespace MiniBot
{
    public partial class Form1 : Form
    {
        private t.Timer timerMana;
        private t.Timer timerHealth;
        private Thread threadFindBars;
        private ConfigurationModel configurationModel;

        public Form1()
        {
            InitializeComponent();

            TibiaClient.FindTibiaClientProcess();

            InitializeTimers();

            StartTimers();

            LoadConfiguration();
        }

        private void TimerMana_Elapsed(object sender, t.ElapsedEventArgs e)
        {
            try
            {
                Invoke(new Action(() => { Mana.UsePotionOrWait(); }));
            }
            catch
            {
            }
            
        }      
        
        private void TimerHealth_Elapsed(object sender, t.ElapsedEventArgs e)
        {
            try
            {
                Invoke(new Action(() => { Health.UsePotionOrWait(); }));
            }
            catch
            {
            }   
        }

        private void InitializeTimers()
        {
            timerMana = new t.Timer();
            timerMana.Interval = 500;
            timerMana.Elapsed += TimerMana_Elapsed;

            timerHealth = new t.Timer();
            timerHealth.Interval = 333;
            timerHealth.Elapsed += TimerHealth_Elapsed;
        }

        private void StartTimers()
        {
            timerMana.Start();
            timerHealth.Start();
        }

        private void LoadConfiguration()
        {
            configurationModel = Configuration.Load(this);

            if (!string.IsNullOrWhiteSpace(configurationModel.Health.HotKey))
                cbLifeHotkey.SelectedItem = configurationModel.Health.HotKey;

            if (!string.IsNullOrWhiteSpace(configurationModel.Mana.HotKey))
                cbManaHotKey.SelectedItem = configurationModel.Mana.HotKey;

            nupLifePercent.Value = configurationModel.Health.UseAtPercent;
            nupManaPercent.Value = configurationModel.Mana.UseAtPercent;

            cbLifeActive.Checked = configurationModel.Health.Active;
            cbManaActive.Checked = configurationModel.Mana.Active;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbLifeHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            configurationModel.Health.HotKey = cbLifeHotkey.SelectedItem.ToString();
            configurationModel.Health.UseAtPercent = (short)nupLifePercent.Value;
            configurationModel.Health.Active = cbLifeActive.Checked;

            configurationModel.Mana.HotKey = cbManaHotKey.SelectedItem.ToString();
            configurationModel.Mana.UseAtPercent = (short)nupManaPercent.Value;
            configurationModel.Mana.Active = cbManaActive.Checked;

            Configuration.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            threadFindBars = new Thread(new ThreadStart(FindHealthAndManaBar));
            threadFindBars.Start();
        }

        private void FindHealthAndManaBar()
        {
            Configuration.FindHealthAndManaBar();
        }
    }
}
