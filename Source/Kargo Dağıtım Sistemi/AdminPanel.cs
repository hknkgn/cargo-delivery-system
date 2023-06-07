using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GMap.NET.MapProviders;
using Guna.UI2.WinForms;

namespace Kargo_Dağıtım_Sistemi
{
    public partial class AdminPanel : UserControl
    {
        MainForm mForm;
        public AdminPanel(MainForm mf)
        {
            mForm = mf;
            InitializeComponent();
        }

        public string Username;
        public void AdminPanel_Load(object sender, EventArgs e)
        {
            lbl_Name.Text = Username;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            mForm.WindowState = FormWindowState.Minimized;
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageDialog.Show(null, "Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageDialogButtons.YesNo, MessageDialogIcon.Information, MessageDialogStyle.Light);
            if (dResult == DialogResult.Yes)
            {
                Database.RemoveWhere("rememberMe", "username", Username);
                mForm.ChangeContent(mForm._LoginUI);
                mForm._MemberPanel = new MemberPanel(mForm);
            }
        }

        private void btn_ShowMap_Click(object sender, EventArgs e)
        {
            AdminUI_Contents.MapUI mUI = new AdminUI_Contents.MapUI();
            pnl_Content.Controls.Clear();
            pnl_Content.Controls.Add(mUI);
        }

        public void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminUI_Contents.CargoSettings cSet = new AdminUI_Contents.CargoSettings(this);
            pnl_Content.Controls.Clear();
            pnl_Content.Controls.Add(cSet);
        }
    }
}
