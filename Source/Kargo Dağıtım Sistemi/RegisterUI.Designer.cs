
namespace Kargo_Dağıtım_Sistemi
{
    partial class RegisterUI
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.tb_Coordinates = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_ConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_ePosta = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_register = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Back = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(469, 29);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 100;
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
            this.Map.Size = new System.Drawing.Size(403, 496);
            this.Map.TabIndex = 2;
            this.Map.Zoom = 0D;
            this.Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Map_MouseMove);
            // 
            // tb_Coordinates
            // 
            this.tb_Coordinates.Animated = true;
            this.tb_Coordinates.BackColor = System.Drawing.Color.Transparent;
            this.tb_Coordinates.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tb_Coordinates.BorderRadius = 20;
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
            this.tb_Coordinates.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.tb_Coordinates.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tb_Coordinates.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Coordinates.HoverState.Parent = this.tb_Coordinates;
            this.tb_Coordinates.Location = new System.Drawing.Point(244, 199);
            this.tb_Coordinates.Name = "tb_Coordinates";
            this.tb_Coordinates.PasswordChar = '\0';
            this.tb_Coordinates.PlaceholderText = "Koordinat  (*)";
            this.tb_Coordinates.ReadOnly = true;
            this.tb_Coordinates.SelectedText = "";
            this.tb_Coordinates.ShadowDecoration.BorderRadius = 20;
            this.tb_Coordinates.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.tb_Coordinates.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.tb_Coordinates.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.tb_Coordinates.ShadowDecoration.Enabled = true;
            this.tb_Coordinates.ShadowDecoration.Parent = this.tb_Coordinates;
            this.tb_Coordinates.Size = new System.Drawing.Size(190, 41);
            this.tb_Coordinates.TabIndex = 5;
            this.tb_Coordinates.Tag = "inputs";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Animated = true;
            this.tb_UserName.BackColor = System.Drawing.Color.Transparent;
            this.tb_UserName.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tb_UserName.BorderRadius = 35;
            this.tb_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_UserName.CustomizableEdges.BottomLeft = false;
            this.tb_UserName.CustomizableEdges.TopRight = false;
            this.tb_UserName.DefaultText = "";
            this.tb_UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_UserName.DisabledState.Parent = this.tb_UserName;
            this.tb_UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_UserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.tb_UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_UserName.FocusedState.Parent = this.tb_UserName;
            this.tb_UserName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_UserName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tb_UserName.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_UserName.HoverState.Parent = this.tb_UserName;
            this.tb_UserName.Location = new System.Drawing.Point(45, 55);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.PasswordChar = '\0';
            this.tb_UserName.PlaceholderText = "Kullanıcı Adı (*)";
            this.tb_UserName.SelectedText = "";
            this.tb_UserName.ShadowDecoration.BorderRadius = 35;
            this.tb_UserName.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.tb_UserName.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.tb_UserName.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.tb_UserName.ShadowDecoration.Depth = 40;
            this.tb_UserName.ShadowDecoration.Enabled = true;
            this.tb_UserName.ShadowDecoration.Parent = this.tb_UserName;
            this.tb_UserName.Size = new System.Drawing.Size(190, 47);
            this.tb_UserName.TabIndex = 0;
            this.tb_UserName.Tag = "inputs";
            this.tb_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ConfirmPassword
            // 
            this.tb_ConfirmPassword.Animated = true;
            this.tb_ConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.tb_ConfirmPassword.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tb_ConfirmPassword.BorderRadius = 35;
            this.tb_ConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ConfirmPassword.CustomizableEdges.BottomLeft = false;
            this.tb_ConfirmPassword.CustomizableEdges.TopRight = false;
            this.tb_ConfirmPassword.DefaultText = "";
            this.tb_ConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_ConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_ConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ConfirmPassword.DisabledState.Parent = this.tb_ConfirmPassword;
            this.tb_ConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.tb_ConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_ConfirmPassword.FocusedState.Parent = this.tb_ConfirmPassword;
            this.tb_ConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_ConfirmPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tb_ConfirmPassword.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_ConfirmPassword.HoverState.Parent = this.tb_ConfirmPassword;
            this.tb_ConfirmPassword.Location = new System.Drawing.Point(244, 109);
            this.tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            this.tb_ConfirmPassword.PasswordChar = '*';
            this.tb_ConfirmPassword.PlaceholderText = "Şifreyi Onayla (*)";
            this.tb_ConfirmPassword.SelectedText = "";
            this.tb_ConfirmPassword.ShadowDecoration.BorderRadius = 35;
            this.tb_ConfirmPassword.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.tb_ConfirmPassword.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.tb_ConfirmPassword.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.tb_ConfirmPassword.ShadowDecoration.Depth = 40;
            this.tb_ConfirmPassword.ShadowDecoration.Enabled = true;
            this.tb_ConfirmPassword.ShadowDecoration.Parent = this.tb_ConfirmPassword;
            this.tb_ConfirmPassword.Size = new System.Drawing.Size(190, 47);
            this.tb_ConfirmPassword.TabIndex = 3;
            this.tb_ConfirmPassword.Tag = "inputs";
            this.tb_ConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ePosta
            // 
            this.tb_ePosta.Animated = true;
            this.tb_ePosta.BackColor = System.Drawing.Color.Transparent;
            this.tb_ePosta.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tb_ePosta.BorderRadius = 35;
            this.tb_ePosta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ePosta.CustomizableEdges.BottomRight = false;
            this.tb_ePosta.CustomizableEdges.TopLeft = false;
            this.tb_ePosta.DefaultText = "";
            this.tb_ePosta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_ePosta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_ePosta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ePosta.DisabledState.Parent = this.tb_ePosta;
            this.tb_ePosta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ePosta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.tb_ePosta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_ePosta.FocusedState.Parent = this.tb_ePosta;
            this.tb_ePosta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_ePosta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tb_ePosta.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_ePosta.HoverState.Parent = this.tb_ePosta;
            this.tb_ePosta.Location = new System.Drawing.Point(45, 109);
            this.tb_ePosta.Name = "tb_ePosta";
            this.tb_ePosta.PasswordChar = '\0';
            this.tb_ePosta.PlaceholderText = "E-Posta (*)";
            this.tb_ePosta.SelectedText = "";
            this.tb_ePosta.ShadowDecoration.BorderRadius = 35;
            this.tb_ePosta.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.tb_ePosta.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.tb_ePosta.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.tb_ePosta.ShadowDecoration.Depth = 40;
            this.tb_ePosta.ShadowDecoration.Enabled = true;
            this.tb_ePosta.ShadowDecoration.Parent = this.tb_ePosta;
            this.tb_ePosta.Size = new System.Drawing.Size(190, 47);
            this.tb_ePosta.TabIndex = 1;
            this.tb_ePosta.Tag = "inputs";
            this.tb_ePosta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Password
            // 
            this.tb_Password.Animated = true;
            this.tb_Password.BackColor = System.Drawing.Color.Transparent;
            this.tb_Password.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tb_Password.BorderRadius = 35;
            this.tb_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Password.CustomizableEdges.BottomRight = false;
            this.tb_Password.CustomizableEdges.TopLeft = false;
            this.tb_Password.DefaultText = "";
            this.tb_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.DisabledState.Parent = this.tb_Password;
            this.tb_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.tb_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Password.FocusedState.Parent = this.tb_Password;
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb_Password.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tb_Password.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_Password.HoverState.Parent = this.tb_Password;
            this.tb_Password.Location = new System.Drawing.Point(244, 55);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '\0';
            this.tb_Password.PlaceholderText = "Şifre (*)";
            this.tb_Password.SelectedText = "";
            this.tb_Password.ShadowDecoration.BorderRadius = 35;
            this.tb_Password.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.tb_Password.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.tb_Password.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.tb_Password.ShadowDecoration.Depth = 40;
            this.tb_Password.ShadowDecoration.Enabled = true;
            this.tb_Password.ShadowDecoration.Parent = this.tb_Password;
            this.tb_Password.Size = new System.Drawing.Size(190, 47);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.Tag = "inputs";
            this.tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_register
            // 
            this.btn_register.Animated = true;
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_register.BorderRadius = 45;
            this.btn_register.BorderThickness = 2;
            this.btn_register.CheckedState.Parent = this.btn_register;
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.CustomImages.Parent = this.btn_register;
            this.btn_register.CustomizableEdges.BottomLeft = false;
            this.btn_register.CustomizableEdges.TopRight = false;
            this.btn_register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_register.DisabledState.Parent = this.btn_register;
            this.btn_register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.btn_register.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_register.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_register.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_register.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_register.HoverState.Parent = this.btn_register;
            this.btn_register.Location = new System.Drawing.Point(28, 426);
            this.btn_register.Name = "btn_register";
            this.btn_register.PressedColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_register.PressedDepth = 50;
            this.btn_register.ShadowDecoration.BorderRadius = 45;
            this.btn_register.ShadowDecoration.Color = System.Drawing.Color.MediumSeaGreen;
            this.btn_register.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.btn_register.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.btn_register.ShadowDecoration.Depth = 20;
            this.btn_register.ShadowDecoration.Enabled = true;
            this.btn_register.ShadowDecoration.Parent = this.btn_register;
            this.btn_register.Size = new System.Drawing.Size(180, 45);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Kayıt Ol";
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Animated = true;
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Back.BorderRadius = 45;
            this.btn_Back.BorderThickness = 2;
            this.btn_Back.CheckedState.Parent = this.btn_Back;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.CustomImages.Parent = this.btn_Back;
            this.btn_Back.CustomizableEdges.BottomRight = false;
            this.btn_Back.CustomizableEdges.TopLeft = false;
            this.btn_Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Back.DisabledState.Parent = this.btn_Back;
            this.btn_Back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.btn_Back.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Back.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Back.HoverState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Back.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Back.HoverState.Parent = this.btn_Back;
            this.btn_Back.Location = new System.Drawing.Point(28, 477);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.PressedColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Back.PressedDepth = 50;
            this.btn_Back.ShadowDecoration.BorderRadius = 45;
            this.btn_Back.ShadowDecoration.Color = System.Drawing.Color.DeepSkyBlue;
            this.btn_Back.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.btn_Back.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.btn_Back.ShadowDecoration.Depth = 20;
            this.btn_Back.ShadowDecoration.Enabled = true;
            this.btn_Back.ShadowDecoration.Parent = this.btn_Back;
            this.btn_Back.Size = new System.Drawing.Size(180, 45);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Geri Dön";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // RegisterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.tb_ePosta);
            this.Controls.Add(this.tb_ConfirmPassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.tb_Coordinates);
            this.Name = "RegisterUI";
            this.Size = new System.Drawing.Size(900, 554);
            this.Load += new System.EventHandler(this.RegisterUI_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl Map;
        private Guna.UI2.WinForms.Guna2TextBox tb_Coordinates;
        private Guna.UI2.WinForms.Guna2TextBox tb_UserName;
        private Guna.UI2.WinForms.Guna2TextBox tb_ConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox tb_ePosta;
        private Guna.UI2.WinForms.Guna2TextBox tb_Password;
        private Guna.UI2.WinForms.Guna2Button btn_register;
        private Guna.UI2.WinForms.Guna2Button btn_Back;
    }
}
