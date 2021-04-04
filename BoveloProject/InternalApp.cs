using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Bovelo
{
    public class InternalApp
    {
        public static string managerPassword = "1234";
        public static DataTable bikeTable ;
        public static DataTable planningTable ;
        public static List<Bike> bikeList = new List<Bike>();
        public static string[] bikeStateList = new string[] { "Active", "Not active", "Done" };  
        public InternalApp()
        {
            SetBikeList();
        }
        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChooseUser());
        }
        public static DataTable GetDataTable(string sqlCommand)
        {
            Database db1 = new Database();
            MySqlConnection conn = new MySqlConnection(db1.MyConnection);
            MySqlCommand command = new MySqlCommand(sqlCommand, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            return table;
        }
        public static void ExecuteQuery(string query)
        {
            Database db = new Database();
            MySqlConnection connection = new MySqlConnection(db.MyConnection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read()) { }
            connection.Close();
        }
        public static MySqlDataReader GetData(string query)
        {
            Database db = new Database();
            MySqlConnection connection = new MySqlConnection(db.MyConnection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            return reader;
        }

        public static void UpdateBikeTable()
        {
            bikeTable = GetDataTable("SELECT * FROM bike WHERE cstr_status!='Done'");
        }
        public static void UpdatePlanningTable()
        {
            planningTable = GetDataTable("SELECT * FROM planning");
        }
        public static void SetBikeList()
        {
            UpdateBikeTable();
            UpdatePlanningTable();
            foreach (DataRow row in bikeTable.Rows)
            {
                Bike bike = new Bike(row.Field<int>("id"));
                bikeList.Add(bike);
            }
        }
    }
}
