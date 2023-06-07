using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Kargo_Dağıtım_Sistemi
{
    public partial class SplashUI : UserControl
    {
        MainForm mForm;
        public SplashUI(object mf)
        {
            mForm = (MainForm)mf;
            InitializeComponent();
        }

        private void SplashUI_Load(object sender, EventArgs e)
        {
        }

        int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!success)
            {
                if (counter < 3)
                    label1.Text += ".";
                if (counter > 3)
                    label1.Text = label1.Text.Replace("...", "..").Replace("r..", "r.");
                if (counter == 6)
                    counter = 1;
                else
                    counter++;
            }
            else
            {
                mForm.ChangeContent(mForm._LoginUI);
                timer1.Enabled = false;
                mForm._Splash = null;
                
            }

        }

        bool success = false;
        public void DbSuccess()
        {
            timer1.Enabled = false;
            success = true;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            label1.Text = "Veritabanına bağlanıldı.";
            label1.ForeColor = Color.SpringGreen;

        }
    }
}
