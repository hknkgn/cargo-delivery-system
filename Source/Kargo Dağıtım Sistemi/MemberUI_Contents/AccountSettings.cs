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

namespace Kargo_Dağıtım_Sistemi.MemberUI_Contents
{
    public partial class AccountSettings : UserControl
    {
        MemberPanel mPanel;
        public AccountSettings(MemberPanel mp)
        {
            mPanel = mp;
            InitializeComponent();
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {

        }

        private void btn_Success_Click(object sender, EventArgs e)
        {

            string dbPass = "";

            MySqlDataReader Reader = Database.GetWhere("user", "username", mPanel.Username);
            while (Reader.Read())
                dbPass = Reader["password"].ToString();
            Reader.Close();

            MySqlCommand Command = new MySqlCommand($"UPDATE user SET password='{tb_NewPassword.Text}' WHERE username='{mPanel.Username}'", Database.Connection);

            if (tb_OldPassword.Text == dbPass)
                if (tb_NewPassword.Text != "")
                    if (tb_NewPassword.Text == tb_NewPasswordCheck.Text)
                    {
                        Command.ExecuteNonQuery();
                        Database.Dialog("Şifre değiştirildi.");
                        mPanel.ChangeContent(mPanel.btn_CargoTracking);
                        mPanel.btn_CargoTracking.Checked = true;
                    }
                    else
                        Database.Dialog("Şifreler Uyuşmuyor.");
                else
                    Database.Dialog("Lütfen geçerli bir şifre giriniz.");
            else
                Database.Dialog("Hatalı Şifre.");

        }
    }
}