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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        Console ps4 = new Console();
        bool firstRun = true;
        public string path = null;

        private void accept_button_Click(object sender, EventArgs e)
        {
            //Ps4_No_domainUpDown
            ps4.priceSetter((byte)Ps4_Price_domainUpDown.Value);
            ps4.ACPriceSetter((byte)Ps4_ctrlr_domainUpDown.Value);



            if (/*finalText*/this.path == null)
            {
                MessageBox.Show("مسیر ذخیره سازی وارد نشده است");

                folderBrowserDialog.ShowDialog();
                this.path = folderBrowserDialog.SelectedPath;
            }
            else
            {
                if (firstRun)
                {
                    firstRun = false;
                    this.Close();
                }
                else
                    this.Close();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (firstRun)
                Application.Exit();
            else
            {
                this.Close();
                firstRun = false;
            }
        }


        private void saveLocationButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            this.path = folderBrowserDialog.SelectedPath;
        }

       public byte PS4_number()
        {
            return ((byte)Ps4_No_domainUpDown.Value);
        }
        public byte PS5_number()
        {
            return ((byte)Ps5_No_domainUpDown.Value);
        }
    }
}
