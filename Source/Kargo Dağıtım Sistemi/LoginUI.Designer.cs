
namespace Kargo_Dağıtım_Sistemi
{
    partial class LoginUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.cb_RememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tb_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Register = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AdminLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_RememberMe
            // 
            this.cb_RememberMe.AutoSize = true;
            this.cb_RememberMe.BackColor = System.Drawing.Color.Transparent;
            this.cb_RememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_RememberMe.CheckedState.BorderRadius = 0;
            this.cb_RememberMe.CheckedState.BorderThickness = 0;
            this.cb_RememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_RememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_RememberMe.Font = new System.Drawing.Font("Open Sans SemiBold", 10F);
            this.cb_RememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.cb_RememberMe.Location = new System.Drawing.Point(49, 254);
            this.cb_RememberMe.Name = "cb_RememberMe";
            this.cb_RememberMe.Size = new System.Drawing.Size(109, 23);
            this.cb_RememberMe.TabIndex = 9;
            this.cb_RememberMe.Text = "Beni Hatırla";
            this.cb_RememberMe.UncheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cb_RememberMe.UncheckedState.BorderRadius = 0;
            this.cb_RememberMe.UncheckedState.BorderThickness = 2;
            this.cb_RememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.cb_RememberMe.UseVisualStyleBackColor = false;
            // 
            // tb_Password
            // 
            this.tb_Password.Animated = true;
            this.tb_Password.BackColor = System.Drawing.Color.Transparent;
            this.tb_Password.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tb_Password.BorderRadius = 15;
            this.tb_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Password.CustomizableEdges.TopLeft = false;
            this.tb_Password.CustomizableEdges.TopRight = false;
            this.tb_Password.DefaultText = "";
            this.tb_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.DisabledState.Parent = this.tb_Password;
            this.tb_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.tb_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Password.FocusedState.Parent = this.tb_Password;
            this.tb_Password.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Password.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tb_Password.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_Password.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.tb_Password.HoverState.Parent = this.tb_Password;
            this.tb_Password.Location = new System.Drawing.Point(49, 138);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tb_Password.PlaceholderText = "Şifre";
            this.tb_Password.SelectedText = "";
            this.tb_Password.ShadowDecoration.BorderRadius = 15;
            this.tb_Password.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.tb_Password.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.tb_Password.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.tb_Password.ShadowDecoration.Depth = 40;
            this.tb_Password.ShadowDecoration.Enabled = true;
            this.tb_Password.ShadowDecoration.Parent = this.tb_Password;
            this.tb_Password.Size = new System.Drawing.Size(410, 40);
            this.tb_Password.TabIndex = 8;
            this.tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_UserName
            // 
            this.tb_UserName.BackColor = System.Drawing.Color.Transparent;
            this.tb_UserName.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tb_UserName.BorderRadius = 15;
            this.tb_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_UserName.CustomizableEdges.BottomLeft = false;
            this.tb_UserName.CustomizableEdges.BottomRight = false;
            this.tb_UserName.DefaultText = "";
            this.tb_UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_UserName.DisabledState.Parent = this.tb_UserName;
            this.tb_UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_UserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.tb_UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_UserName.FocusedState.Parent = this.tb_UserName;
            this.tb_UserName.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_UserName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tb_UserName.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_UserName.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.tb_UserName.HoverState.Parent = this.tb_UserName;
            this.tb_UserName.Location = new System.Drawing.Point(49, 81);
            this.tb_UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.PasswordChar = '\0';
            this.tb_UserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tb_UserName.PlaceholderText = "Kullanıcı Adı";
            this.tb_UserName.SelectedText = "";
            this.tb_UserName.ShadowDecoration.BorderRadius = 15;
            this.tb_UserName.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.tb_UserName.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.tb_UserName.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.tb_UserName.ShadowDecoration.Depth = 40;
            this.tb_UserName.ShadowDecoration.Enabled = true;
            this.tb_UserName.ShadowDecoration.Parent = this.tb_UserName;
            this.tb_UserName.Size = new System.Drawing.Size(410, 40);
            this.tb_UserName.TabIndex = 7;
            this.tb_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.CausesValidation = false;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.CustomizableEdges.TopRight = false;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.guna2Panel1.Location = new System.Drawing.Point(107, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 50;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.guna2Panel1.ShadowDecoration.Depth = 20;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(294, 51);
            this.guna2Panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(40, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kargo Takip Sistemi";
            // 
            // btn_Register
            // 
            this.btn_Register.Animated = true;
            this.btn_Register.BackColor = System.Drawing.Color.Transparent;
            this.btn_Register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Register.BorderRadius = 40;
            this.btn_Register.BorderThickness = 2;
            this.btn_Register.CheckedState.Parent = this.btn_Register;
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.CustomImages.Parent = this.btn_Register;
            this.btn_Register.CustomizableEdges.BottomRight = false;
            this.btn_Register.CustomizableEdges.TopLeft = false;
            this.btn_Register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Register.DisabledState.Parent = this.btn_Register;
            this.btn_Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.btn_Register.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Register.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Register.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Register.HoverState.Parent = this.btn_Register;
            this.btn_Register.Location = new System.Drawing.Point(315, 254);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Register.PressedDepth = 50;
            this.btn_Register.ShadowDecoration.BorderRadius = 40;
            this.btn_Register.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Register.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.btn_Register.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.btn_Register.ShadowDecoration.Depth = 20;
            this.btn_Register.ShadowDecoration.Enabled = true;
            this.btn_Register.ShadowDecoration.Parent = this.btn_Register;
            this.btn_Register.Size = new System.Drawing.Size(144, 45);
            this.btn_Register.TabIndex = 13;
            this.btn_Register.Text = "Kayıt Ol";
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_AdminLogin
            // 
            this.btn_AdminLogin.Animated = true;
            this.btn_AdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_AdminLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(83)))));
            this.btn_AdminLogin.BorderRadius = 40;
            this.btn_AdminLogin.BorderThickness = 2;
            this.btn_AdminLogin.CheckedState.Parent = this.btn_AdminLogin;
            this.btn_AdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AdminLogin.CustomImages.Parent = this.btn_AdminLogin;
            this.btn_AdminLogin.CustomizableEdges.BottomLeft = false;
            this.btn_AdminLogin.CustomizableEdges.TopRight = false;
            this.btn_AdminLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AdminLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AdminLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AdminLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AdminLogin.DisabledState.Parent = this.btn_AdminLogin;
            this.btn_AdminLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.btn_AdminLogin.Font = new System.Drawing.Font("Open Sans SemiBold", 10F);
            this.btn_AdminLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(83)))));
            this.btn_AdminLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(83)))));
            this.btn_AdminLogin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_AdminLogin.HoverState.Parent = this.btn_AdminLogin;
            this.btn_AdminLogin.Location = new System.Drawing.Point(270, 194);
            this.btn_AdminLogin.Name = "btn_AdminLogin";
            this.btn_AdminLogin.PressedDepth = 50;
            this.btn_AdminLogin.ShadowDecoration.BorderRadius = 40;
            this.btn_AdminLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(83)))));
            this.btn_AdminLogin.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.btn_AdminLogin.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.btn_AdminLogin.ShadowDecoration.Depth = 20;
            this.btn_AdminLogin.ShadowDecoration.Enabled = true;
            this.btn_AdminLogin.ShadowDecoration.Parent = this.btn_AdminLogin;
            this.btn_AdminLogin.Size = new System.Drawing.Size(189, 45);
            this.btn_AdminLogin.TabIndex = 12;
            this.btn_AdminLogin.Text = "Kurye Girişi Yap";
            this.btn_AdminLogin.Click += new System.EventHandler(this.btn_AdminLogin_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Animated = true;
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Login.BorderRadius = 40;
            this.btn_Login.BorderThickness = 2;
            this.btn_Login.CheckedState.Parent = this.btn_Login;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.CustomImages.Parent = this.btn_Login;
            this.btn_Login.CustomizableEdges.BottomRight = false;
            this.btn_Login.CustomizableEdges.TopLeft = false;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.DisabledState.Parent = this.btn_Login;
            this.btn_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.btn_Login.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Login.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Login.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Login.HoverState.Parent = this.btn_Login;
            this.btn_Login.Location = new System.Drawing.Point(49, 194);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.PressedDepth = 50;
            this.btn_Login.ShadowDecoration.BorderRadius = 40;
            this.btn_Login.ShadowDecoration.Color = System.Drawing.Color.MediumSeaGreen;
            this.btn_Login.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.btn_Login.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.btn_Login.ShadowDecoration.Depth = 20;
            this.btn_Login.ShadowDecoration.Enabled = true;
            this.btn_Login.ShadowDecoration.Parent = this.btn_Login;
            this.btn_Login.Size = new System.Drawing.Size(189, 45);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "Üye Girişi Yap";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.label2;
            // 
            // btn_Close
            // 
            this.btn_Close.Animated = true;
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Close.BorderRadius = 35;
            this.btn_Close.CheckedState.Parent = this.btn_Close;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Close.CustomImages.Parent = this.btn_Close;
            this.btn_Close.CustomizableEdges.BottomLeft = false;
            this.btn_Close.CustomizableEdges.BottomRight = false;
            this.btn_Close.CustomizableEdges.TopLeft = false;
            this.btn_Close.CustomizableEdges.TopRight = false;
            this.btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Close.DisabledState.Parent = this.btn_Close;
            this.btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Close.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btn_Close.HoverState.Parent = this.btn_Close;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageOffset = new System.Drawing.Point(1, 0);
            this.btn_Close.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Close.Location = new System.Drawing.Point(455, -1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.ShadowDecoration.BorderRadius = 35;
            this.btn_Close.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.btn_Close.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.btn_Close.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.btn_Close.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.btn_Close.ShadowDecoration.Parent = this.btn_Close;
            this.btn_Close.Size = new System.Drawing.Size(50, 50);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.TextOffset = new System.Drawing.Point(1, 1);
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click_1);
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.cb_RememberMe);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_AdminLogin);
            this.Controls.Add(this.btn_Login);
            this.Name = "LoginUI";
            this.Size = new System.Drawing.Size(508, 321);
            this.Load += new System.EventHandler(this.LoginUI_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_Register;
        private Guna.UI2.WinForms.Guna2Button btn_AdminLogin;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        public Guna.UI2.WinForms.Guna2CheckBox cb_RememberMe;
        public Guna.UI2.WinForms.Guna2TextBox tb_Password;
        public Guna.UI2.WinForms.Guna2TextBox tb_UserName;
        private Guna.UI2.WinForms.Guna2Button btn_Close;
    }
}
