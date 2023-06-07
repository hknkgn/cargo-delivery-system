using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace Kargo_Dağıtım_Sistemi
{
     class Database
    {
        public static void Dialog(string Message, string Header = "Uyarı", MessageDialogIcon icon = MessageDialogIcon.Information)
        {
            MessageDialog.Show(null, Message, Header, MessageDialogButtons.OK, icon, MessageDialogStyle.Light);
        }

        public static string ConnectionString = "server=34.72.247.96;user ID=root;password=bM1Be6xi0pOKMJC2;database=cargos;";
        public static MySqlConnection Connection;
        public static MySqlCommand Command;
        public static MySqlDataReader Reader;


        public static MySqlDataReader ExecuteReader(string cm)
        {
            Command = new MySqlCommand(cm, Connection);
            return Command.ExecuteReader();
        }

        public static bool Search(string table, string name, string searchText)
        {
            bool IsFound = false;
            Command = new MySqlCommand($"SELECT * FROM {table} WHERE {name}='{searchText}'", Connection);
            Reader = Command.ExecuteReader();
            while (Reader.Read()) { IsFound = true; }
            Reader.Close();

            if (IsFound) 
                return true;
            else
                return false;
        }

        public static List<String> GetAllValues(string Table, string Name)
        {
            List<String> s = new List<String>();

            Command = new MySqlCommand($"SELECT * FROM {Table}",Connection);
            Reader = Command.ExecuteReader();

            while (Reader.Read())
                s.Add(Reader[Name].ToString());
            Reader.Close();
            return s;
        }

        public static string CreateCargoID()
        {
            string stUserIDs = "";

            List<string> UserIDs = GetAllValues("Cargo", "CargoID"); // CargoID tablosunu liste aktarma
            foreach (var UserID in UserIDs)
                stUserIDs += $"{UserID}\n"; // Listeyi stringe çeviriyorum contains methodu için

            string val = "ABCDEFGHIJKLMNOPRSTUVYZ1234567890";

            /*/
             * Burada while(true) ile kısır döngü oluşturuyorum, oluşturulan yeni ID'yi veritabanında tarıyor eğer eşleşen varsa-
             * -yeniden oluşturuyor ta ki eşleşmeyene kadar.
            /*/
            while(true)
            {
                string NewID = "";
                int lenght = 8;
                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                while (0 < lenght--)
                    res.Append(val[rnd.Next(val.Length)]);
                NewID = res.ToString();
                if (!stUserIDs.Contains(NewID))
                    return NewID;
            }
        }

        public static void Insert(string table, string columns, string values)
        {
            Command = new MySqlCommand($"INSERT INTO {table}({columns}) VALUES({values})", Connection);
            Command.ExecuteNonQuery();
        }

        public static void RemoveWhere(string Table, string column, string value)
        {
            Command = new MySqlCommand($"DELETE FROM {Table} WHERE {column}='{value}'", Connection);
            Command.ExecuteNonQuery();
        }

        public static MySqlDataReader GetWhere(string table, string column, string value, string Params = "")
        {
            Command = new MySqlCommand($"SELECT * FROM {table} WHERE {column}='{value}' {Params}", Connection);
            return Command.ExecuteReader();
        }

        public static bool Login(string TableName, string username, string password)
        {
            bool IsSuccess = false;
            MySqlDataReader reader = ExecuteReader($"SELECT * FROM {TableName} WHERE username='{username}' and password='{password}'");
            while (reader.Read())
                IsSuccess = true; /*/ Direkt return true; yerine bool değişkeni kullanıyorum ki DataReader'i Close edebileyim /*/
            reader.Close();

            if (!IsSuccess)
                return false;
            else
                return true;
        }

    }
}