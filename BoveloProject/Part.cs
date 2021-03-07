using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bovelo
{
    /*
        Every single argument get requested in database and placed as a 
        parameter in the constructor.
    
        The part gets fours parameters
            > The name of the part
            > The color
            > The quantity
            > The characteristics : contains bike specific specifications
    */
    public class Part
    {
        public string name;
        public string color;
        public int quantity;
        public string characteristic;
        public Part(string name, string color, string characteristic) 
        {
            this.name = name;
            this.characteristic = characteristic;
            string colorQuery = $"SELECT * FROM part_stock WHERE name='{name}' AND characteristic='{characteristic}'";
            DataTable colorTable = GetDataTable(colorQuery);
            DataRow[] availableColor = colorTable.Select("color='" + color + "'");
            if (availableColor.Length != 0)
            {
                this.color = color;
            }
            else
            {
                this.color = "Default";
            }
            string quantityQuery = $"SELECT * FROM part_stock WHERE name='{this.name}' AND color='{this.color}' AND characteristic='{this.characteristic}'";
            DataTable quantityReader = GetDataTable(quantityQuery);
            this.quantity = Convert.ToInt32(quantityReader.Rows[0]["quantity"].ToString());
        }
        public void Use()
        {
            quantity--;
            string query = $"UPDATE part_stock SET quantity={quantity} WHERE name='{name}' AND color='{color}' AND characteristic='{characteristic}'";
            ExecuteQuery(query);
        }
        public void Order(int quantity)
        {
            this.quantity += quantity;
            string query = $"UPDATE part_stock SET quantity={this.quantity} WHERE name='{name}' AND color='{color}' AND characteristic='{characteristic}'";
            ExecuteQuery(query);
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
        private static void ExecuteQuery(string query)
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
    }
}