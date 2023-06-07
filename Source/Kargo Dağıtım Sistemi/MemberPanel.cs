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
using Guna.UI2.WinForms;

namespace Kargo_Dağıtım_Sistemi
{
    public partial class MemberPanel : UserControl
    {
        MainForm mForm;
        public MemberPanel(MainForm mf)
        {
            InitializeComponent();
            mForm = mf;
        }

        public string UserID, Username, Password, eMail, coordinate;

        public MemberUI_Contents.CreateOrder UI_CreateOrder;
        public MemberUI_Contents.CargoTracking UI_CargoTracking;
        public MemberUI_Contents.AccountSettings UI_Settings;


        #region Voids

        public void ChangeContent(Guna2Button Sender)
        {

            if (Sender == btn_CreateOrder && !pnl_Content.Controls.Contains(UI_CreateOrder))
            {
                pnl_Content.Controls.Clear();
                pnl_Content.Controls.Add(UI_CreateOrder = new MemberUI_Contents.CreateOrder(this));
            }
            if (Sender == btn_CargoTracking && !pnl_Content.Controls.Contains(UI_CargoTracking))
            {
                pnl_Content.Controls.Clear();
                pnl_Content.Controls.Add(UI_CargoTracking = new MemberUI_Contents.CargoTracking(this));
            }
            if (Sender == btn_AccountSettings && !pnl_Content.Controls.Contains(UI_Settings))
            {
                pnl_Content.Controls.Clear();
                pnl_Content.Controls.Add(UI_Settings = new MemberUI_Contents.AccountSettings(this));
            }
        }

        public void restart()
        {
            ChangeContent(btn_CreateOrder);
        }

        #endregion

        private void NavigateButtons(object sender, EventArgs e)
        {
            ChangeContent((Guna2Button)sender);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            mForm.ChangeContent(mForm._LoginUI);
        }

        private void MemberPanel_Load(object sender, EventArgs e)
        {

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


        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            mForm.WindowState = FormWindowState.Minimized;
        }

        public void LoadDB(string _UserID)
        {
            MySqlDataReader Reader = Database.GetWhere("user", "username", _UserID);
            Username = _UserID;
            while (Reader.Read())
            {
                Password = Reader["Password"].ToString();
                eMail = Reader["eMail"].ToString();
                coordinate = Reader["coordinate"].ToString();
            }
            Reader.Close();

            lbl_Name.Text = Username;
            btn_CargoTracking.Checked = true;
            ChangeContent(btn_CargoTracking);
        }
    }
}