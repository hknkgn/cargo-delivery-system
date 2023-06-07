using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Kargo_Dağıtım_Sistemi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        public SplashUI _Splash;
        public LoginUI _LoginUI;
        public RegisterUI _RegisterUI;
        public MemberPanel _MemberPanel;
        public AdminPanel _AdminPanel;

        public MySqlConnection Connect;

        public string UserID;

        #region Voids

        public void ChangeContent(Control c)
        {
            // MainForm'da ki bütün kontrolleri temizle
            foreach (Control Cont in this.Controls)
                this.Controls.Clear();


            if (!(c is SplashUI))
                guna2DragControl1.TargetControl = c;
            if (c is MemberPanel)
            {
                string username = "";
                MySqlDataReader Reader = Database.GetWhere("user", "username", _LoginUI.tb_UserName.Text);
                while (Reader.Read())
                    username = Reader["username"].ToString();

                Reader.Close();
                _MemberPanel.LoadDB(username);
            }


            #region Clear Form

            foreach (Control Cont in c.Controls)
                if (Cont is Guna2TextBox)
                    ((Guna2TextBox)Cont).Text = "";

                else if (Cont is Guna2CheckBox)
                    ((Guna2CheckBox)Cont).Checked = false;
            #endregion

            this.Size = c.Size;
            this.CenterToScreen();
            this.Controls.Add(c);
        }

        #endregion

        private void LoginForm_Load(object sender, EventArgs e)
        {

            _Splash = new SplashUI(this);
            _LoginUI = new LoginUI(this);
            _RegisterUI = new RegisterUI(this);
            _MemberPanel = new MemberPanel(this);
            _AdminPanel = new AdminPanel(this);
            #region Splash Screen

            ChangeContent(_Splash);
            guna2BorderlessForm1.BorderRadius = 0;

            var worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerAsync();
            #endregion
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //UI Opening
            Connect = new MySqlConnection(Database.ConnectionString);
            Connect.Open();
            Action ChangeC = () => _Splash.DbSuccess();
            _Splash.Invoke(ChangeC);
            Database.Connection = Connect;
        }
    }
}
