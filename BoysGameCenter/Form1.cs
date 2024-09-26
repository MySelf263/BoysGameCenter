﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoysGameCenter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            settingForm.ShowDialog();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;

        }
        byte[,] time = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        byte[] price = { 25, 25, 25, 25 };
        int cost;
        bool[] dev = { false, false, false, false };
        int[] totalTime = { 0, 0, 0, 0 };
        public sbyte[] devTimer = { 0, 0, 0 };

        SettingForm settingForm = new SettingForm();
        Console ps4 = new Console();
        //FinalText finalText = new FinalText();
        //AuxiliaryMenu auxiliaryMenu = new AuxiliaryMenu();

        private void ButtonFunction() {

            if (!ps4.enabledGetter())
            {
                ps4.start();
                timer.Enabled = true;
                PS5_1_button.BackColor = Color.ForestGreen;
            }
            else
            {
                ps4.finish();
                MessageBox.Show(ps4.report());
                PS5_1_button.BackColor = Color.Gainsboro;
                comboBox6.SelectedIndex = 0;
                minHourTimer6.Text = "00:00";
                secondsTimer6.Text = ":00";
                for (int i = 0; i < devTimer.Length; i++)
                {
                    devTimer[i] = 0;
                }
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ps4.enabledGetter())
            {
                devTimer[0] += 1;
                if (devTimer[0] > 59)
                {
                    devTimer[0] = 0;
                    devTimer[1] += 1;
                }
                if (devTimer[1] > 59)
                {
                    devTimer[1] = 0;
                    devTimer[2] += 1;
                }
                string behindHour = "", behindMinute = ":", behindSecond = ":";
                if (devTimer[2] < 10) { behindHour += "0"; }
                if (devTimer[1] < 10) { behindMinute += "0"; }
                if (devTimer[0] < 10) { behindSecond += "0"; }
                minHourTimer6.Text = behindHour + devTimer[2] + behindMinute + devTimer[1];
                secondsTimer6.Text = behindSecond + devTimer[0];
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.SelectedIndex)
            {
                case (0):
                    ps4.ACNumberSetter(0);
                    break;

                case (1):
                    ps4.ACNumberSetter(1);
                    break;

                case (2):
                    ps4.ACNumberSetter(2);
                    break;

                default:
                    ps4.ACNumberSetter(0);
                    break;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            
            this.ButtonFunction();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            string atentionText = "";
            bool atention = false;
            for (int i = 0; i < dev.Length; i++)
            {
                if (dev[i])
                {
                    atentionText += "PlayStation " + (i + 1) + " is working\n";
                    atention = true;
                }
            }
            if (!atention)
            {
                //string resualt = "Ps4 _ 1 : " + totalTime[0] + " minute" + "\t\tPs4 _ 2 : " + totalTime[1] + " minute" +
                //    "\n\nPs4 _ 3 : " + totalTime[2] + " minute" + "\t\tPs4 _ 4 : " + totalTime[3] + " minute";
                //MessageBox.Show(resualt, "Total Time");

                ps4.ending();
                this.Close();
            }
            else MessageBox.Show(atentionText, "atention");
        }

        private void Setting_button_Click(object sender, EventArgs e)
        {
            settingForm.ShowDialog();
        }

        private void minHourTimer1_Click(object sender, EventArgs e)
        {
            //auxiliaryMenu.ShowDialog();
        }


    }
}
