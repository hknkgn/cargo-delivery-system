
namespace Kargo_Dağıtım_Sistemi.MemberUI_Contents
{
    partial class CreateOrder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_accept = new Guna.UI2.WinForms.Guna2Button();
            this.tb_Coordinates = new Guna.UI2.WinForms.Guna2TextBox();
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // btn_accept
            // 
            this.btn_accept.Animated = true;
            this.btn_accept.BackColor = System.Drawing.Color.Transparent;
            this.btn_accept.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_accept.BorderRadius = 40;
            this.btn_accept.BorderThickness = 2;
            this.btn_accept.CheckedState.Parent = this.btn_accept;
            this.btn_accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_accept.CustomImages.Parent = this.btn_accept;
            this.btn_accept.CustomizableEdges.BottomRight = false;
            this.btn_accept.CustomizableEdges.TopLeft = false;
            this.btn_accept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            this.btn_accept.DisabledState.Parent = this.btn_accept;
            this.btn_accept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.btn_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_accept.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_accept.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_accept.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_accept.HoverState.Parent = this.btn_accept;
            this.btn_accept.Location = new System.Drawing.Point(38, 401);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.PressedDepth = 50;
            this.btn_accept.ShadowDecoration.BorderRadius = 40;
            this.btn_accept.ShadowDecoration.Color = System.Drawing.Color.MediumSeaGreen;
            this.btn_accept.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.btn_accept.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.btn_accept.ShadowDecoration.Depth = 20;
            this.btn_accept.ShadowDecoration.Enabled = true;
            this.btn_accept.ShadowDecoration.Parent = this.btn_accept;
            this.btn_accept.Size = new System.Drawing.Size(229, 45);
            this.btn_accept.TabIndex = 12;
            this.btn_accept.Text = "Onayla";
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // tb_Coordinates
            // 
            this.tb_Coordinates.Animated = true;
            this.tb_Coordinates.BackColor = System.Drawing.Color.Transparent;
            this.tb_Coordinates.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tb_Coordinates.BorderRadius = 30;
            this.tb_Coordinates.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Coordinates.CustomizableEdges.BottomLeft = false;
            this.tb_Coordinates.CustomizableEdges.TopRight = false;
            this.tb_Coordinates.DefaultText = "";
            this.tb_Coordinates.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Coordinates.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Coordinates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Coordinates.DisabledState.Parent = this.tb_Coordinates;
            this.tb_Coordinates.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Coordinates.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.tb_Coordinates.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Coordinates.FocusedState.Parent = this.tb_Coordinates;
            this.tb_Coordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_Coordinates.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tb_Coordinates.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Coordinates.HoverState.Parent = this.tb_Coordinates;
            this.tb_Coordinates.Location = new System.Drawing.Point(402, 401);
            this.tb_Coordinates.Name = "tb_Coordinates";
            this.tb_Coordinates.PasswordChar = '\0';
            this.tb_Coordinates.PlaceholderText = "Koordinat ";
            this.tb_Coordinates.ReadOnly = true;
            this.tb_Coordinates.SelectedText = "";
            this.tb_Coordinates.ShadowDecoration.BorderRadius = 30;
            this.tb_Coordinates.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.tb_Coordinates.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.tb_Coordinates.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.tb_Coordinates.ShadowDecoration.Enabled = true;
            this.tb_Coordinates.ShadowDecoration.Parent = this.tb_Coordinates;
            this.tb_Coordinates.Size = new System.Drawing.Size(461, 45);
            this.tb_Coordinates.TabIndex = 6;
            this.tb_Coordinates.Tag = "inputs";
            this.tb_Coordinates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Coordinates.TextOffset = new System.Drawing.Point(10, 1);
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(38, 30);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 2;
            this.Map.MinZoom = 2;
            this.Map.MouseWheelZoomEnabled = true;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = true;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = true;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(825, 355);
            this.Map.TabIndex = 13;
            this.Map.Zoom = 0D;
            this.Map.Load += new System.EventHandler(this.Map_Load);
            this.Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Map_MouseMove);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.Map);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.tb_Coordinates);
            this.Name = "CreateOrder";
            this.Size = new System.Drawing.Size(900, 465);
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_accept;
        private Guna.UI2.WinForms.Guna2TextBox tb_Coordinates;
        private GMap.NET.WindowsForms.GMapControl Map;
    }
}
