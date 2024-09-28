using System;
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
       
        SettingForm settingForm = new SettingForm();
        Console ps4_1 = new Console();
        Console ps4_2 = new Console();
        Console ps4_3 = new Console();
        Console ps4_4 = new Console();
        Console ps4_5 = new Console();
        Console ps5_1 = new Console();
        Console ps5_2 = new Console();
        Console ps5_3 = new Console();
        Console ps5_4 = new Console();
        Console ps5_5 = new Console();

        //FinalText finalText = new FinalText();
        

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ps4_1.enabledGetter())
            {
                ps4_1.devTimer[0] += 1;
                if (ps4_1.devTimer[0] > 59)
                {
                    ps4_1.devTimer[0] = 0;
                    ps4_1.devTimer[1] += 1;
                }
                if (ps4_1.devTimer[1] > 59)
                {
                    ps4_1.devTimer[1] = 0;
                    ps4_1.devTimer[2] += 1;
                }
                string behindHour = "", behindMinute = ":", behindSecond = ":";
                if (ps4_1.devTimer[2] < 10) { behindHour += "0"; }
                if (ps4_1.devTimer[1] < 10) { behindMinute += "0"; }
                if (ps4_1.devTimer[0] < 10) { behindSecond += "0"; }
                minHourTimer1.Text = behindHour + ps4_1.devTimer[2] + behindMinute + ps4_1.devTimer[1];
                secondsTimer1.Text = behindSecond + ps4_1.devTimer[0];
            }
            if (ps4_2.enabledGetter())
            {
                ps4_2.devTimer[0] += 1;
                if (ps4_2.devTimer[0] > 59)
                {
                    ps4_2.devTimer[0] = 0;
                    ps4_2.devTimer[1] += 1;
                }
                if (ps4_2.devTimer[1] > 59)
                {
                    ps4_2.devTimer[1] = 0;
                    ps4_2.devTimer[2] += 1;
                }
                string behindHour = "", behindMinute = ":", behindSecond = ":";
                if (ps4_2.devTimer[2] < 10) { behindHour += "0"; }
                if (ps4_2.devTimer[1] < 10) { behindMinute += "0"; }
                if (ps4_2.devTimer[0] < 10) { behindSecond += "0"; }
                minHourTimer2.Text = behindHour + ps4_2.devTimer[2] + behindMinute + ps4_2.devTimer[1];
                secondsTimer2.Text = behindSecond + ps4_2.devTimer[0];
            }
            if (ps4_3.enabledGetter())
            {
                ps4_3.devTimer[0] += 1;
                if (ps4_3.devTimer[0] > 59)
                {
                    ps4_3.devTimer[0] = 0;
                    ps4_3.devTimer[1] += 1;
                }
                if (ps4_3.devTimer[1] > 59)
                {
                    ps4_3.devTimer[1] = 0;
                    ps4_3.devTimer[2] += 1;
                }
                string behindHour = "", behindMinute = ":", behindSecond = ":";
                if (ps4_3.devTimer[2] < 10) { behindHour += "0"; }
                if (ps4_3.devTimer[1] < 10) { behindMinute += "0"; }
                if (ps4_3.devTimer[0] < 10) { behindSecond += "0"; }
                minHourTimer3.Text = behindHour + ps4_3.devTimer[2] + behindMinute + ps4_3.devTimer[1];
                secondsTimer3.Text = behindSecond + ps4_3.devTimer[0];
            }
            if (ps4_4.enabledGetter())
            {
                ps4_4.devTimer[0] += 1;
                if (ps4_4.devTimer[0] > 59)
                {
                    ps4_4.devTimer[0] = 0;
                    ps4_4.devTimer[1] += 1;
                }
                if (ps4_4.devTimer[1] > 59)
                {
                    ps4_4.devTimer[1] = 0;
                    ps4_4.devTimer[2] += 1;
                }
                string behindHour = "", behindMinute = ":", behindSecond = ":";
                if (ps4_4.devTimer[2] < 10) { behindHour += "0"; }
                if (ps4_4.devTimer[1] < 10) { behindMinute += "0"; }
                if (ps4_4.devTimer[0] < 10) { behindSecond += "0"; }
                minHourTimer4.Text = behindHour + ps4_4.devTimer[2] + behindMinute + ps4_4.devTimer[1];
                secondsTimer4.Text = behindSecond + ps4_4.devTimer[0];
            }
            if (ps4_5.enabledGetter())
            {
                ps4_5.devTimer[0] += 1;
                if (ps4_5.devTimer[0] > 59)
                {
                    ps4_5.devTimer[0] = 0;
                    ps4_5.devTimer[1] += 1;
                }
                if (ps4_5.devTimer[1] > 59)
                {
                    ps4_5.devTimer[1] = 0;
                    ps4_5.devTimer[2] += 1;
                }
                string behindHour = "", behindMinute = ":", behindSecond = ":";
                if (ps4_5.devTimer[2] < 10) { behindHour += "0"; }
                if (ps4_5.devTimer[1] < 10) { behindMinute += "0"; }
                if (ps4_5.devTimer[0] < 10) { behindSecond += "0"; }
                minHourTimer5.Text = behindHour + ps4_5.devTimer[2] + behindMinute + ps4_5.devTimer[1];
                secondsTimer5.Text = behindSecond + ps4_5.devTimer[0];
            }

            if (ps5_1.enabledGetter())
            {
                ps5_1.devTimer[0] += 1;
                if (ps5_1.devTimer[0] > 59)
                {
                    ps5_1.devTimer[0] = 0;
                    ps5_1.devTimer[1] += 1;
                }
                if (ps5_1.devTimer[1] > 59)
                {
                    ps5_1.devTimer[1] = 0;
                    ps5_1.devTimer[2] += 1;
                }
                string behindHour = "", behindMinute = ":", behindSecond = ":";
                if (ps5_1.devTimer[2] < 10) { behindHour += "0"; }
                if (ps5_1.devTimer[1] < 10) { behindMinute += "0"; }
                if (ps5_1.devTimer[0] < 10) { behindSecond += "0"; }
                minHourTimer6.Text = behindHour + ps5_1.devTimer[2] + behindMinute + ps5_1.devTimer[1];
                secondsTimer6.Text = behindSecond + ps5_1.devTimer[0];
            }
            if (ps5_2.enabledGetter())
            {
                ps5_2.devTimer[0] += 1;
                if (ps5_2.devTimer[0] > 59)
                {
                    ps5_2.devTimer[0] = 0;
                    ps5_2.devTimer[1] += 1;
                }
                if (ps5_2.devTimer[1] > 59)
                {
                    ps5_2.devTimer[1] = 0;
                    ps5_2.devTimer[2] += 1;
                }
                string behindHour = "", behindMinute = ":", behindSecond = ":";
                if (ps5_2.devTimer[2] < 10) { behindHour += "0"; }
                if (ps5_2.devTimer[1] < 10) { behindMinute += "0"; }
                if (ps5_2.devTimer[0] < 10) { behindSecond += "0"; }
                minHourTimer7.Text = behindHour + ps5_2.devTimer[2] + behindMinute + ps5_2.devTimer[1];
                secondsTimer7.Text = behindSecond + ps5_2.devTimer[0];
            }
            if (ps5_3.enabledGetter())
            {
                ps5_3.devTimer[0] += 1;
                if (ps5_3.devTimer[0] > 59)
                {
                    ps5_3.devTimer[0] = 0;
                    ps5_3.devTimer[1] += 1;
                }
                if (ps5_3.devTimer[1] > 59)
                {
                    ps5_3.devTimer[1] = 0;
                    ps5_3.devTimer[2] += 1;
                }
                string behindHour = "", behindMinute = ":", behindSecond = ":";
                if (ps5_3.devTimer[2] < 10) { behindHour += "0"; }
                if (ps5_3.devTimer[1] < 10) { behindMinute += "0"; }
                if (ps5_3.devTimer[0] < 10) { behindSecond += "0"; }
                minHourTimer8.Text = behindHour + ps5_3.devTimer[2] + behindMinute + ps5_3.devTimer[1];
                secondsTimer8.Text = behindSecond + ps5_3.devTimer[0];
            }
            if (ps5_4.enabledGetter())
            {
                ps5_4.devTimer[0] += 1;
                if (ps5_4.devTimer[0] > 59)
                {
                    ps5_4.devTimer[0] = 0;
                    ps5_4.devTimer[1] += 1;
                }
                if (ps5_4.devTimer[1] > 59)
                {
                    ps5_4.devTimer[1] = 0;
                    ps5_4.devTimer[2] += 1;
                }
                string behindHour = "", behindMinute = ":", behindSecond = ":";
                if (ps5_4.devTimer[2] < 10) { behindHour += "0"; }
                if (ps5_4.devTimer[1] < 10) { behindMinute += "0"; }
                if (ps5_4.devTimer[0] < 10) { behindSecond += "0"; }
                minHourTimer9.Text = behindHour + ps5_4.devTimer[2] + behindMinute + ps5_4.devTimer[1];
                secondsTimer9.Text = behindSecond + ps5_4.devTimer[0];
            }
            if (ps5_5.enabledGetter())
            {
                ps5_5.devTimer[0] += 1;
                if (ps5_5.devTimer[0] > 59)
                {
                    ps5_5.devTimer[0] = 0;
                    ps5_5.devTimer[1] += 1;
                }
                if (ps5_5.devTimer[1] > 59)
                {
                    ps5_5.devTimer[1] = 0;
                    ps5_5.devTimer[2] += 1;
                }
                string behindHour = "", behindMinute = ":", behindSecond = ":";
                if (ps5_5.devTimer[2] < 10) { behindHour += "0"; }
                if (ps5_5.devTimer[1] < 10) { behindMinute += "0"; }
                if (ps5_5.devTimer[0] < 10) { behindSecond += "0"; }
                minHourTimer10.Text = behindHour + ps5_5.devTimer[2] + behindMinute + ps5_5.devTimer[1];
                secondsTimer10.Text = behindSecond + ps5_5.devTimer[0];
            }

        }


        private void PS4_1_button_Click(object sender, EventArgs e)
        {

            if (!ps4_1.enabledGetter())
            {
                ps4_1.start();
                PS4_1_button.BackColor = Color.ForestGreen;
            }
            else
            {
                ps4_1.ACNumberSetter((byte)comboBox1.SelectedIndex);
                ps4_1.finish();
                PS4_1_button.BackColor = Color.Gainsboro;
                minHourTimer1.Text = "00:00";
                secondsTimer1.Text = ":00";
                comboBox1.SelectedIndex = 0;
            }

        }


        private void PS4_2_button_Click(object sender, EventArgs e)
        {

            if (!ps4_2.enabledGetter())
            {
                ps4_2.start();
                PS4_2_button.BackColor = Color.ForestGreen;
            }
            else
            {
                ps4_2.ACNumberSetter((byte)comboBox2.SelectedIndex);
                ps4_2.finish();
                PS4_2_button.BackColor = Color.Gainsboro;
                minHourTimer2.Text = "00:00";
                secondsTimer2.Text = ":00";
                comboBox2.SelectedIndex = 0;
            }

        }


        private void PS4_3_button_Click(object sender, EventArgs e)
        {

            if (!ps4_3.enabledGetter())
            {
                ps4_3.start();
                PS4_3_button.BackColor = Color.ForestGreen;
            }
            else
            {
                ps4_3.ACNumberSetter((byte)comboBox3.SelectedIndex);
                ps4_3.finish();
                PS4_3_button.BackColor = Color.Gainsboro;
                minHourTimer3.Text = "00:00";
                secondsTimer3.Text = ":00";
                comboBox3.SelectedIndex = 0;
            }

        }


        private void PS4_4_button_Click(object sender, EventArgs e)
        {

            if (!ps4_4.enabledGetter())
            {
                ps4_4.start();
                PS4_4_button.BackColor = Color.ForestGreen;
            }
            else
            {
                ps4_4.ACNumberSetter((byte)comboBox4.SelectedIndex);
                ps4_4.finish();
                PS4_4_button.BackColor = Color.Gainsboro;
                minHourTimer4.Text = "00:00";
                secondsTimer4.Text = ":00";
                comboBox4.SelectedIndex = 0;
            }

        }


        private void PS4_5_button_Click(object sender, EventArgs e)
        {

            if (!ps4_5.enabledGetter())
            {
                ps4_5.start();
                PS4_5_button.BackColor = Color.ForestGreen;
            }
            else
            {
                ps4_5.ACNumberSetter((byte)comboBox5.SelectedIndex);
                ps4_5.finish();
                PS4_5_button.BackColor = Color.Gainsboro;
                minHourTimer5.Text = "00:00";
                secondsTimer5.Text = ":00";
                comboBox5.SelectedIndex = 0;
            }

        }


        private void PS5_1_button_Click(object sender, EventArgs e)
        {

            if (!ps5_1.enabledGetter())
            {
                ps5_1.start();
                PS5_1_button.BackColor = Color.ForestGreen;
            }
            else
            {
                ps5_1.ACNumberSetter((byte)comboBox6.SelectedIndex);
                ps5_1.finish();
                PS5_1_button.BackColor = Color.Gainsboro;
                minHourTimer6.Text = "00:00";
                secondsTimer6.Text = ":00";
                comboBox6.SelectedIndex = 0;
            }

        }


        private void PS5_2_button_Click(object sender, EventArgs e)
        {

            if (!ps5_2.enabledGetter())
            {
                ps5_2.start();
                PS5_2_button.BackColor = Color.ForestGreen;
            }
            else
            {
                ps5_2.ACNumberSetter((byte)comboBox7.SelectedIndex);
                ps5_2.finish();
                PS5_2_button.BackColor = Color.Gainsboro;
                minHourTimer7.Text = "00:00";
                secondsTimer7.Text = ":00";
                comboBox7.SelectedIndex = 0;
            }

        }


        private void PS5_3_button_Click(object sender, EventArgs e)
        {

            if (!ps5_3.enabledGetter())
            {
                ps5_3.start();
                PS5_3_button.BackColor = Color.ForestGreen;
            }
            else
            {
                ps5_3.ACNumberSetter((byte)comboBox8.SelectedIndex);
                ps5_3.finish();
                PS5_3_button.BackColor = Color.Gainsboro;
                minHourTimer8.Text = "00:00";
                secondsTimer8.Text = ":00";
                comboBox8.SelectedIndex = 0;
            }

        }


        private void PS5_4_button_Click(object sender, EventArgs e)
        {

            if (!ps5_4.enabledGetter())
            {
                ps5_4.start();
                PS5_4_button.BackColor = Color.ForestGreen;
            }
            else
            {
                ps5_4.ACNumberSetter((byte)comboBox9.SelectedIndex);
                ps5_4.finish();
                PS5_4_button.BackColor = Color.Gainsboro;
                minHourTimer9.Text = "00:00";
                secondsTimer9.Text = ":00";
                comboBox9.SelectedIndex = 0;
            }

        }


        private void PS5_5_button_Click(object sender, EventArgs e)
        {

            if (!ps5_5.enabledGetter())
            {
                ps5_5.start();
                PS5_5_button.BackColor = Color.ForestGreen;
            }
            else
            {
                ps5_5.ACNumberSetter((byte)comboBox10.SelectedIndex);
                ps5_5.finish();
                PS5_5_button.BackColor = Color.Gainsboro;
                minHourTimer10.Text = "00:00";
                secondsTimer10.Text = ":00";
                comboBox10.SelectedIndex = 0;
            }

        }



        private void Close_button_Click(object sender, EventArgs e)
        {
            string atentionText = "";
            bool atention = false;
            //for (int i = 0; i < dev.Length; i++)
            //{
            //    if (dev[i])
            //    {
            //        atentionText += "PlayStation " + (i + 1) + " is working\n";
            //        atention = true;
            //    }
            //}
            if (!atention)
            {
                //string resualt = "Ps4 _ 1 : " + totalTime[0] + " minute" + "\t\tPs4 _ 2 : " + totalTime[1] + " minute" +
                //    "\n\nPs4 _ 3 : " + totalTime[2] + " minute" + "\t\tPs4 _ 4 : " + totalTime[3] + " minute";
                //MessageBox.Show(resualt, "Total Time");

                ps4_1.ending();
                this.Close();
            }
            else MessageBox.Show(atentionText, "atention");
        }

        private void Setting_button_Click(object sender, EventArgs e)
        {
            settingForm.ShowDialog();
        }

        private void minHourTimer1_Click_1(object sender, EventArgs e)
        {
            AuxiliaryMenu auxiliaryMenu = new AuxiliaryMenu(ps4_1);
            auxiliaryMenu.ShowDialog();
        }
    }
}
