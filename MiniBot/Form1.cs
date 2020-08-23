using MiniBot.Core;
using System;
using System.Windows.Forms;
using t = System.Timers;

namespace MiniBot
{
    public partial class Form1 : Form
    {
        private t.Timer timerMana;
        private t.Timer timerHealth;

        public Form1()
        {
            InitializeComponent();

            TibiaClient.FindTibiaClientProcess();

            InitializeTimers();

            StartTimers();
        }

        private void TimerMana_Elapsed(object sender, t.ElapsedEventArgs e)
        {
            Invoke(new Action(() => { Mana.UsePotionOrWait(); }));
        }

        private void TimerHealth_Elapsed(object sender, t.ElapsedEventArgs e)
        {
            Invoke(new Action(() => { Health.UsePotionOrWait(); }));
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
    }
}
