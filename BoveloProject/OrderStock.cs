using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bovelo
{
    class OrderStock
    {
        public static List<string> partsNames = new List<string>();
        public static List<int> partsIDs = new List<int>();

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
        public static void GetPartCatalog()
        {
            string quantityQuery = $"SELECT * FROM part_catalog";
            DataTable quantityReader = GetDataTable(quantityQuery);
            int size_datatable = quantityReader.Rows.Count;
            for (int i = 0; i < size_datatable; i++)
            {
                partsNames.Add(quantityReader.Rows[i]["name"].ToString());
                int ID = Convert.ToInt32((quantityReader.Rows[i]["reference"].ToString()));
                partsIDs.Add(ID);
            }
            
        }
        public static int GetPartStock(int ID)
        {
            string quantityQuery = $"SELECT * FROM part_stock WHERE reference='{ID}'";
            DataTable quantityReader = GetDataTable(quantityQuery);
            int size_datatable = quantityReader.Rows.Count;
            if (size_datatable <= 0)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(quantityReader.Rows[0]["quantity"].ToString());
            }
        }
    }
}
