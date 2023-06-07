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
    public partial class CargoSettings : UserControl
    {
        AdminPanel mPanel;
        public CargoSettings(AdminPanel ap)
        {
            mPanel = ap;
            InitializeComponent();
        }

        private void CargoSettings_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            MySqlCommand Command = new MySqlCommand("Select * From Cargo", Database.Connection);
            MySqlDataReader Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                guna2DataGridView1.Rows.Add(Reader["CargoID"], Reader["username"], Reader["coordinate"], Reader["CreateDate"],
                    Reader["DeliveryDate"], Reader["CargoStatus"]);
            }
            Reader.Close();
            cb_Status.SelectedIndex = 0;
        }


        string SelectedID;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedID = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lbl_CargoStatus.Text = "Seçilen Kargo No: " + SelectedID;
            }
            catch { }
        }

        string fixZero(string Target)
        {
            return (Convert.ToInt32(Target) <= 9 ? $"0{Target}" : Target).ToString();
        }

        private void btn_success_Click(object sender, EventArgs e)
        {
            if (SelectedID != "")
            {
                string SET_Text = $"CargoStatus='{cb_Status.Text}'";

                if (cb_Status.Text == "Teslim Edildi")
                {
                    string Day = DateTime.Now.Day.ToString(),
                       Month = DateTime.Now.Month.ToString(),
                       Year = DateTime.Now.Year.ToString(),
                       Hour = DateTime.Now.Hour.ToString(),
                       Minute = DateTime.Now.Minute.ToString(),
                       Second = DateTime.Now.Second.ToString();

                    string Date = $"{fixZero(Day)}.{fixZero(Month)}.{fixZero(Year)} {fixZero(Hour)}:{fixZero(Minute)}:{fixZero(Second)}";
                    SET_Text += $", DeliveryDate='{Date}'";
                }
                else
                    SET_Text += $", DeliveryDate=' '";


                MySqlCommand Command = new MySqlCommand($"UPDATE Cargo SET {SET_Text} WHERE CargoID='{SelectedID}'", Database.Connection);


                Command.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Değiştirildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mPanel.guna2Button1_Click(sender, e);
            }
            else
                MessageBox.Show("Aşağıdan kargo seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
