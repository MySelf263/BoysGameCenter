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

        //PS4 ps4 = new PS4();
        //FinalText finalText = new FinalText();
        bool firstRun = true;
        string path = null;

        private void accept_button_Click(object sender, EventArgs e)
        {
            //ps4.priceSetter(byte.Parse(Ps4_Price_domainUpDown.Text));
            if (/*finalText*/this.path == null)
            {
                MessageBox.Show("مسیر ذخیره سازی وارد نشده است");

                folderBrowserDialog.ShowDialog();
                pathSetter(folderBrowserDialog.SelectedPath);
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
            this.Close();
        }

        public void pathSetter(string path)
        {
            //finalText.path = folderBrowserDialog.SelectedPath + @"\";
            MessageBox.Show(path);
            this.path = path;
        }

        private void saveLocationButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            pathSetter (folderBrowserDialog.SelectedPath);
        }
    }
}
