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
    public class Bike
    {
        public int id;
        public string type;
        public string color;
        public string size;
        public int price;
        public string state;
        public Dictionary<string, Part> partList = new Dictionary<string, Part>();
        public DateTime cstr_date; 
        public Bike(int id)
        {
            this.id = id;
            DataRow bikeRow = InternalApp.bikeTable.AsEnumerable().Single(r => r.Field<int>("id") == this.id);
            this.type = bikeRow.Field<string>("type");
            this.color = bikeRow.Field<string>("color");
            this.size = bikeRow.Field<string>("size");
            this.state = bikeRow.Field<string>("cstr_status");

            try
            {
                DataRow dateRow = InternalApp.planningTable.AsEnumerable().Single(r => r.Field<int>("bike") == id);
                DateTime date = dateRow.Field<DateTime>("date");
                this.cstr_date = date;
            }
            catch { 
            }
            
        }
        public void Build()
        {
            DataTable partTable = GetDataTable($"SELECT * FROM model_structure WHERE model_name='{type}'");
           
            foreach(DataRow partRow in partTable.Rows)
            {
                Part part = new Part(Convert.ToInt32(partRow["id_part"]), this.color, partRow.Field<int>("quantity"));
                partList.Add(part.name, part);
                //part.Use(); 
            }
            //this.ModifyState("Done"); //Comment for testing
        }
        private static MySqlDataReader GetData(string query)
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
        public override string ToString()
        {
            Console.WriteLine("\n-------------\nParts List:\n-------------");
            foreach (KeyValuePair<string, Part> part in partList)
            {
                Console.WriteLine("\nType: {0} \n--Color = {1}\n--Stock = {2}\n--Quantity used = {3}",
                    part.Key, part.Value.color, part.Value.stock, part.Value.quantity);
            }
            return ("\n" + type + " " + size + " " + color);
        }

        public void ModifyDate(string date)
        {
            //improve method with method taking DateTime instead of string in parameter
            Database db = new Database();
            MySqlConnection connection = new MySqlConnection(db.MyConnection);
            string query = $"UPDATE planning SET date='{date}' WHERE bike='{this.id}'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            connection.Close();
        }
        public void ModifyState(string state)
        {
            this.state = state;
            Database db = new Database();
            MySqlConnection connection = new MySqlConnection(db.MyConnection);
            string query = $"UPDATE bike SET cstr_status='{state}' WHERE id='{this.id}'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            connection.Close();

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

