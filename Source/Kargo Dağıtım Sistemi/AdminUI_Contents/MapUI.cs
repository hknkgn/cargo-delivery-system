using GMap.NET;
using GMap.NET.MapProviders;
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

namespace Kargo_Dağıtım_Sistemi.AdminUI_Contents
{
    public partial class MapUI : UserControl
    {
        public MapUI()
        {
            InitializeComponent();
        }

        private void MapUI_Load(object sender, EventArgs e)
        {

            Map.DragButton = MouseButtons.Left;
            Map.MapProvider = GMapProviders.GoogleMap;
            Map.MaxZoom = 24;
            //      
            Map.Zoom = 11;

            MySqlCommand Command = new MySqlCommand("Select * From Cargo", Database.Connection);
            MySqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                if (Reader["CargoStatus"].ToString() != "Teslim Edildi")
                {
                    GMapOverlay markers = new GMapOverlay("markers");
                    double lat = Convert.ToDouble(Reader["Coordinate"].ToString().Split(new[] { ", " }, StringSplitOptions.None)[0]),
                        lng = Convert.ToDouble(Reader["Coordinate"].ToString().Split(new[] { ", " }, StringSplitOptions.None)[1]);

                    GMapMarker marker = new GMarkerGoogle(
                        new PointLatLng(lat, lng),
                        GMarkerGoogleType.green_dot);
                    markers.Markers.Add(marker);
                    Map.Overlays.Add(markers);

                    Map.Position = new PointLatLng(lat, lng);
                }
            }
            Reader.Close();
            Map.Zoom = 14;
        }
    }
}
