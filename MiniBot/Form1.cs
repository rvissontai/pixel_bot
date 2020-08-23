﻿using MiniBot.Core;
using System;
using System.Windows.Forms;
using t = System.Timers;

namespace MiniBot
{
    public partial class Form1 : Form
    {
        private t.Timer timerMana;
        private t.Timer timerHealth;
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
            configurationModel = Configuration.Load();

            if (configurationModel == null)
                return;

            if (!string.IsNullOrWhiteSpace(configurationModel.LifeHotKey))
                cbLifeHotkey.SelectedItem = configurationModel.LifeHotKey;

            if (!string.IsNullOrWhiteSpace(configurationModel.ManaHotKey))
                cbManaHotKey.SelectedItem = configurationModel.ManaHotKey;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbLifeHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            var model = new ConfigurationModel();

            model.LifeHotKey = cbLifeHotkey.SelectedItem.ToString();
            //model.ManaHotKey = cbManaHotKey.SelectedItem.ToString();

            Configuration.Save(model);
        }
    }
}
