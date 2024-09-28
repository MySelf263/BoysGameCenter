using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoysGameCenter
{
    public partial class AuxiliaryMenu: Form
    {
        public AuxiliaryMenu(Console console)
        {
            InitializeComponent();
            this.console = console;
        }
        sbyte reserveHour, reserveMinute;
        private Console console;

        public void consoleSetter(Console console)
        {
            this.console = console;
        }

        public void increaseTimeSetter(byte increseTime)
        {
            console.increaseTimeSetter(increseTime);
        }

        public void reservation(sbyte hour, sbyte minute)
        {
            console.devTimer[1] = hour;
            console.devTimer[2] = minute;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            if (increase_time_numericUpDown.Value == 0 && reservation_numericUpDown.Value == 0)
            {
                increase_time_numericUpDown.Focus();
            }

            if (increase_time_numericUpDown.Value != 0)
            {
                console.increaseTimeSetter((byte)increase_time_numericUpDown.Value);

                //MessageBox.Show(increase_time_numericUpDown.Value.ToString());
                
                this.Close();
            }

            if (reservation_numericUpDown.Value != 0)
            {
                while (reservation_numericUpDown.Value >= 60)
                {
                    reserveHour += -1;
                    reservation_numericUpDown.Value -= 60;
                }

                reserveMinute -= (sbyte)reservation_numericUpDown.Value;

                console.devTimer[2]=reserveHour;
                console.devTimer[1]=reserveMinute;

                //MessageBox.Show(reserveHour + ":" + reserveMinute);

                this.Close();
                
            }

        }

    }
}
