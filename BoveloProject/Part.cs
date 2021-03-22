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
        public string reference { get; set; } 
        public string name { get; set; }
        public int quantity { get; set; }
        public int stock { get; set; }

        public Part(string reference, int quantity)
        {
            this.reference = reference;
            this.quantity = quantity;

            DataTable nameTable = GetDataTable($"SELECT * FROM parts_catalog WHERE reference='{reference}'"); //Facultatif
            this.name = nameTable.Rows[0].Field<string>("name");

            DataTable partDataTable = GetDataTable($"SELECT * FROM parts_stock WHERE reference='{reference}'");
            this.stock = partDataTable.Rows[0].Field<int>("quantity");
        }
        public void Use()
        {
            stock-=quantity;
            string query = $"UPDATE parts_stock SET quantity={stock} WHERE reference='{reference}'";
            ExecuteQuery(query);
        }
        public void Order(int quantity)
        {
            this.stock += quantity;
            string query = $"UPDATE parts_stock SET quantity={this.stock} WHERE reference='{reference}'";
            ExecuteQuery(query);
        }
        public void AutoOrder()
        {
            if(stock <= quantity * 50) //if stock under 50 bikes parts
            {
                Order(40 * quantity); //Order 40 bikes parts
            }
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