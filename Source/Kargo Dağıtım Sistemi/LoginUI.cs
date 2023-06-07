using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kargo_Dağıtım_Sistemi
{
    public partial class LoginUI : UserControl
    {
        MainForm mForm;
        public LoginUI(MainForm mf)
        {
            mForm = mf;
            InitializeComponent();
        }

        void LoginFail()
        {
            Database.Dialog("Hatalı Şifre Veya Kullanıcı Adı.", Header: "Uyarı");
        }

        void Remember()
        {
            MySqlDataReader Reader = Database.GetWhere("user", "username", tb_UserName.Text);
            while (Reader.Read())
                mForm.UserID = Reader["username"].ToString();
            Reader.Close();


            if (cb_RememberMe.Checked)
            {
                Database.RemoveWhere("rememberMe", "Username", tb_UserName.Text);
                Database.Insert("rememberMe", "IpAddress,Username,Password", $"'{GetIPAddress()}','{tb_UserName.Text}','{tb_Password.Text}'");
            }
            else
            {
                Database.RemoveWhere("rememberMe", "Username", GetIPAddress());
                Database.RemoveWhere("rememberMe", "IpAddress", GetIPAddress());
                /*/ Veritabanı şişmemesi için giriş yapıldığında o IP Adresine kayıtlı sütunları siliyorum /*/
            }
        }

        string GetIPAddress()
        {
            string address = "";
            WebRequest request = WebRequest.Create("http://checkip.amazonaws.com");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }
            return address;
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (Database.Login("user", tb_UserName.Text, tb_Password.Text))
            {
                Thread th1 = new Thread(new ThreadStart(Remember));
                th1.Start();
                mForm.ChangeContent(mForm._MemberPanel);
            }
            else
                LoginFail();

        }

        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            if (Database.Login("admin", tb_UserName.Text, tb_Password.Text))
            {
                Thread th1 = new Thread(new ThreadStart(Remember));
                th1.Start();
                mForm.ChangeContent(mForm._AdminPanel);
                mForm._AdminPanel.Username = tb_UserName.Text;
                mForm._AdminPanel.AdminPanel_Load(sender, e);
            }
            else
                LoginFail();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            mForm.ChangeContent(mForm._RegisterUI);
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            #region Remember 
            
            /*/ Eğer rememberMe tablosunda IP Adresi var ise o IP Adresinde kayıtlı kullanıcı adı ve şifreye buradan ulaşıyorum /*/ 
            /*/ Direkt giriş yapmak yerine textboxlara yazdırma sebebim şifre değişikliğinde sorun olmaması için /*/

            MySqlDataReader Reader = Database.GetWhere("rememberMe", "IpAddress", GetIPAddress());
            while (Reader.Read())
            {
                tb_UserName.Text = Reader["Username"].ToString();
                tb_Password.Text = Reader["Password"].ToString();
                cb_RememberMe.Checked = true;
            }
            Reader.Close();
            #endregion

            btn_Close.Location = new Point(this.Size.Width - btn_Close.Size.Width , 0);
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}