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
        public List<Part> partList = new List<Part>();
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
        public Bike() { } // needed to create models in NewModel form
        public void Build()
        {
            DataTable partTable = GetDataTable($"SELECT * FROM model_structure WHERE model_name='{type}'");
            foreach(DataRow partRow in partTable.Rows)
            {
                Part part = new Part(partRow.Field<string>("reference"), partRow.Field<int>("quantity"));
                this.addPart(part);
                part.Use(); 
            }
            this.ModifyState("Done"); //Comment for testing
        }

        public void addPart(Part part) //Useful for NewModels, partList can thus become a private attribute
        {
            partList.Add(part);
        }

        public void deletePart(string reference)
        {
            var itemToRemove = partList.Single(r => r.reference == reference);
            partList.Remove(itemToRemove);
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
            foreach (Part part in partList)
            {
                Console.WriteLine("\nType: {0}\n--Stock = {1}\n--Quantity used = {2}",
                    part.name, part.stock, part.quantity);
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

        public void saveModel()      //needs to be cleaned, create methods in database GetData and SendData 
        {
            Database db = new Database();
            MySqlConnection connection1 = new MySqlConnection(db.MyConnection);
            string query1 = $"INSERT into model_catalog(name, price) values('{type}','{price}');";
            MySqlCommand command1 = new MySqlCommand(query1, connection1);
            MySqlDataReader reader1;
            connection1.Open();
            reader1 = command1.ExecuteReader();
            reader1.Read();
            connection1.Close();

            foreach (Part part in partList)
            {
                MySqlConnection connection = new MySqlConnection(db.MyConnection);
                string query = $"INSERT into model_structure(model_name, reference, quantity) values('{type}','{part.reference}', '{part.quantity}');";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                reader.Read();
                connection.Close();
            }
           
        }
    }
}

