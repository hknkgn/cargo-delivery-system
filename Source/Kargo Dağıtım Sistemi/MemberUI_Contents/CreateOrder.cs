using GMap.NET;
using GMap.NET.MapProviders;
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

namespace Kargo_Dağıtım_Sistemi.MemberUI_Contents
{
    public partial class CreateOrder : UserControl
    {
        MemberPanel mPanel;
        public CreateOrder(MemberPanel mp)
        {
            mPanel = mp;
            InitializeComponent();
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            Map.DragButton = MouseButtons.Left;
            Map.MapProvider = GMapProviders.GoogleMap;
            Map.MaxZoom = 24;
            double lat = Convert.ToDouble(mPanel.coordinate.Split(new[] { ", " }, StringSplitOptions.None)[0]),
                   lng = Convert.ToDouble(mPanel.coordinate.Split(new[] { ", " }, StringSplitOptions.None)[1]);
            Map.Position = new PointLatLng(lat, lng); 
            Map.Zoom = 11;
            tb_Coordinates.Text = $"{Map.Position.Lat}, {Map.Position.Lng}";
            
        }

        bool Clickable = true;

        string fixZero(string Target)
        {
            return (Convert.ToInt32(Target) <= 9 ? $"0{Target}": Target).ToString();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (Clickable)
            {
            Thread th = new Thread(new ThreadStart(() =>
            {
                Action btnFalse = () => btn_accept.Enabled= false;
                Action btnTrue = () => btn_accept.Enabled = true;

                Action GoCargoTrackPanel = () => mPanel.ChangeContent(mPanel.btn_CargoTracking);
                Action SelectButton = () => mPanel.btn_CargoTracking.Checked = true;

                string Day = DateTime.Now.Day.ToString(),
                       Month = DateTime.Now.Month.ToString(),
                       Year = DateTime.Now.Year.ToString(),
                       Hour = DateTime.Now.Hour.ToString(),
                       Minute = DateTime.Now.Minute.ToString(),
                       Second = DateTime.Now.Second.ToString();


                this.Invoke(btnFalse);
                Database.Insert("Cargo", "CargoID,username,coordinate,CreateDate,CargoStatus",
                    $"'{Database.CreateCargoID()}'," +
                    $"'{mPanel.Username}'," +
                    $"'{tb_Coordinates.Text}'," +
                    $"'{fixZero(Day)}.{fixZero(Month)}.{fixZero(Year)} {fixZero(Hour)}:{fixZero(Minute)}:{fixZero(Second)}'," +
                    $"'Şubede'");
                this.Invoke(btnTrue);
                mPanel.Invoke(GoCargoTrackPanel);
                mPanel.Invoke(SelectButton);
            }));
            th.Start();
            }
        }


        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            tb_Coordinates.Text = $"{Map.Position.Lat}, {Map.Position.Lng}";
        }

        private void Map_Load(object sender, EventArgs e)
        {

        }
    }
}
