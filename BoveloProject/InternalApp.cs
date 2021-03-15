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
        public static DataTable bikeTable = GetDataTable("SELECT * FROM bike WHERE cstr_status!='Done'");
        public static DataTable planningTable = GetDataTable("SELECT * FROM planning");
        public static List<Bike> bikeList = new List<Bike>();
        public InternalApp()
        {
        }
        public void Run()
        {
            foreach(DataRow row in bikeTable.Rows)
            {
                Bike bike = new Bike(row.Field<int>("id"));
                bikeList.Add(bike);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChooseUser());
        }
        private static DataTable GetDataTable(string sqlCommand)
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
    }
}
