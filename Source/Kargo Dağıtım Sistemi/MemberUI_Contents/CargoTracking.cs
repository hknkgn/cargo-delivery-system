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

namespace Kargo_Dağıtım_Sistemi.MemberUI_Contents
{
    public partial class CargoTracking : UserControl
    {
        MemberPanel mPanel;
        public CargoTracking(MemberPanel mp)
        {
            mPanel = mp;
            InitializeComponent();
        }

        Label CopyLabel(Label NewLabel, Label Target, string Text = "")
        {

            NewLabel.Location = Target.Location;
            NewLabel.AutoSize = Target.AutoSize;
            NewLabel.Font = Target.Font;
            NewLabel.Size = Target.Size;
            NewLabel.ForeColor = Target.ForeColor;
            NewLabel.BackColor = Target.BackColor;
            NewLabel.TextAlign = Target.TextAlign;
            NewLabel.Text = Text == "" ? Target.Text : Text;
            return NewLabel;
        }

        List<Guna2Panel> Panels = new List<Guna2Panel>();

        int LastY = 0;
        int BuffY = 100;

        private void CargoTracking_Load(object sender, EventArgs e)
        {

            #region Database
            MySqlDataReader Reader = Database.GetWhere("Cargo", "username", mPanel.Username, "ORDER BY CreateDate DESC");
            while (Reader.Read())
            {
                #region Variables
                Guna2Panel nPanel = new Guna2Panel();

                Label Header_lbl_CargoStatus = new Label();
                Label Header_lbl_DeliveryDate = new Label();
                Label Header_lbl_CreateDate = new Label();
                Label Header_lbl_CargoID = new Label();

                Label n_lbl_CargoStatus = new Label();
                Label n_lbl_DeliveryDate = new Label();
                Label n_lbl_CreateDate = new Label();
                Label n_lbl_CargoID = new Label();

                string Status = Reader["CargoStatus"].ToString();
                #endregion

                #region Panel

                pnl_Cargos.Controls.Add(nPanel);
                Panels.Add(nPanel);
                nPanel.Size = pnl_CargoTemplate.Size;
                nPanel.Location = new Point(pnl_CargoTemplate.Location.X, pnl_CargoTemplate.Location.Y + (LastY == 0 ? 0 : LastY + BuffY));
                nPanel.BorderThickness = pnl_CargoTemplate.BorderThickness;
                LastY = Panels[Panels.Count - 1].Location.Y;

                nPanel.BorderColor =
                    Status == "Şubede"        ? Color.DodgerBlue            :
                    Status == "Yolda"         ? Color.FromArgb(242, 227, 0) : /*/ Yellow /*/
                    Status == "Teslim Edildi" ? Color.SeaGreen              : pnl_CargoTemplate.BorderColor;

                #endregion
                #region Labels
                nPanel.Controls.Add(CopyLabel(Header_lbl_CargoStatus, lbl_CargoStatus_Head));
                nPanel.Controls.Add(CopyLabel(Header_lbl_DeliveryDate, lbl_DeliveryDate_Head));
                nPanel.Controls.Add(CopyLabel(Header_lbl_CreateDate, lbl_CreateDate_Head));
                nPanel.Controls.Add(CopyLabel(Header_lbl_CargoID, lbl_CargoID_Header));

                nPanel.Controls.Add(CopyLabel(n_lbl_DeliveryDate, lbl_DeliveryDate, Reader["DeliveryDate"].ToString()));
                nPanel.Controls.Add(CopyLabel(n_lbl_CargoStatus, lbl_CargoStatus, Reader["CargoStatus"].ToString()));
                nPanel.Controls.Add(CopyLabel(n_lbl_CreateDate, lbl_CreateDate, Reader["CreateDate"].ToString()));
                nPanel.Controls.Add(CopyLabel(n_lbl_CargoID, lbl_CargoID, Reader["CargoID"].ToString()));

                n_lbl_CargoStatus.ForeColor = nPanel.BorderColor;
                n_lbl_DeliveryDate.ForeColor = n_lbl_DeliveryDate.Text != "-" ? nPanel.BorderColor : n_lbl_DeliveryDate.ForeColor;
                #endregion
                #region PictureBox

                PictureBox pBox = new PictureBox();
                nPanel.Controls.Add(pBox);
                pBox.Location = pictureBox1.Location;
                pBox.Size = pictureBox1.Size;
                pBox.SizeMode = pictureBox1.SizeMode;
                pBox.Image = Status == "Şubede"        ? Properties.Resources.trolley :
                             Status == "Yolda"         ? Properties.Resources.truck   :
                             Status == "Teslim Edildi" ? Properties.Resources.check   : null;
                #endregion
            }
            Reader.Close();
            #endregion

            #region pnl_Cargos Border
            Label Top = new Label();
            Label Bottom = new Label();

            Color Col = Color.DodgerBlue;
            int Thickness = 1;

            Top.AutoSize = false;
            Top.BackColor = Col;
            Top.Width = pnl_Cargos.Width;
            Top.Height = Thickness;

            this.Controls.Add(Top);
            this.Controls.Add(Bottom);

            Top.Location = new Point(pnl_Cargos.Location.X, pnl_Cargos.Location.Y - 1);

            Bottom = CopyLabel(Bottom, Top);
            Bottom.Location = new Point(pnl_Cargos.Location.X, pnl_Cargos.Location.Y + pnl_Cargos.Height - 1);
            Bottom.BringToFront();

            #endregion

            #region pnl_Cargos Vertical Scroll Settings
            pnl_Cargos.AutoScroll = false;
            pnl_Cargos.HorizontalScroll.Enabled = false;
            pnl_Cargos.HorizontalScroll.Visible = false;
            pnl_Cargos.VerticalScroll.Enabled = false;
            pnl_Cargos.VerticalScroll.Visible = false;
            pnl_Cargos.HorizontalScroll.Maximum = 0;
            pnl_Cargos.AutoScroll = true;
            pnl_Cargos.MouseWheel += pnl_Cargos_MouseWheel;

            ScrollBar.Maximum = pnl_Cargos.VerticalScroll.Maximum;
            ScrollBar.SmallChange = pnl_Cargos.VerticalScroll.SmallChange;
            ScrollBar.LargeChange = pnl_Cargos.VerticalScroll.LargeChange;
            //ScrollBar.Height += 6;
            ScrollBar.Location = new Point(((pnl_Cargos.Location.X + pnl_Cargos.Size.Width) - ScrollBar.Width), pnl_Cargos.Location.Y /*- 3*/);
            #endregion

        }

        void pnl_Cargos_MouseWheel(object sender, MouseEventArgs e)
        {
            ScrollBar.Value = pnl_Cargos.VerticalScroll.Value;
        }

        private void ScrollBar_ValueChanged(object sender, EventArgs e)
        {
            pnl_Cargos.AutoScrollPosition = new Point(pnl_Cargos.AutoScrollPosition.X, ScrollBar.Value);

        }

        private void lbl_CargoID_Click(object sender, EventArgs e)
        {

        }
    }
}
