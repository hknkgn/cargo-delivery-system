using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using Guna.UI2.WinForms;
namespace Kargo_Dağıtım_Sistemi
{
    public partial class RegisterUI : UserControl
    {
        MainForm mForm;
        public RegisterUI(MainForm mf)
        {
            mForm = mf;
            InitializeComponent();
        }



        private void RegisterUI_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
                if (c is Guna2TextBox)
                    ((Guna2TextBox)c).Text = "";
                
            



            Map.DragButton = MouseButtons.Left;
            Map.MapProvider = GMapProviders.GoogleMap;
            Map.Zoom = 6;
            Map.MaxZoom = 24;
            Map.Position = new PointLatLng(38.7198047426424, 35.4638671875); // türkiye'nin tam ortası
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            mForm.ChangeContent(mForm._LoginUI);
        }

        private void btn_SelectCoordinate_Click(object sender, EventArgs e)
        {
            string lat = Map.Position.Lat.ToString().Replace(".", ","),
                   Lng = Map.Position.Lng.ToString().Replace(".", ",");
            tb_Coordinates.Text = $"{lat}, {Lng}";
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            foreach (Control tbox in this.Controls)
                if (tbox is Guna2TextBox)
                {
                    Guna2TextBox myTbox = (Guna2TextBox)tbox;
                    if (myTbox.Text == "" || myTbox.Text == " ")
                    {
                        Database.Dialog("Eksik veya hatalı bilgi doldurdunuz.");
                        return;
                    }
                }

            if (tb_Password.Text != tb_ConfirmPassword.Text)
            {
                Database.Dialog("Şifreler uyuşmuyor.");
                return;
            }
            else
            {
                // Kullanıcı Adı Kontrolü
                if (Database.Search("user", "username", tb_UserName.Text))
                {
                    Database.Dialog("Bu kullanıcı adı kullanılıyor.");
                    return;
                }
                else
                {
                    Database.Dialog("Yeni hesap oluşturuldu.");
                    Database.Insert("user", "username,password,email,coordinate",
                        $"'{tb_UserName.Text}', '{tb_Password.Text}', '{tb_ePosta.Text}', '{tb_Coordinates.Text}'");

                    mForm.ChangeContent(mForm._LoginUI);
                    mForm._LoginUI.tb_UserName.Text = tb_UserName.Text;
                    mForm._LoginUI.tb_Password.Focus();
                }
            }
        }

        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            tb_Coordinates.Text = $"{Map.Position.Lat}, {Map.Position.Lng}";
        }
    }
}
    