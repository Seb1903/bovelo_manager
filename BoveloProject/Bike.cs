using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    public class Bike
    {
        public int id;
        public string type;
        public string color;
        public string size;
        public int price;
        public Dictionary<string, Part> partList = new Dictionary<string, Part>();
        public DateTime cstr_date; 
        public Bike(int id)
        {
            this.id = id;
            string bikeQuery = $"SELECT * FROM bike WHERE id={id}";
            MySqlDataReader bikeReader = GetData(bikeQuery);
            this.type = bikeReader.GetString(1);
            this.color = bikeReader.GetString(2);
            this.size = bikeReader.GetString(3);
            string dateQuery = $"SELECT * FROM planning WHERE bike={id}";
            MySqlDataReader dateReader = GetData(dateQuery);
            this.cstr_date = dateReader.GetDateTime(0);
            
        }
        public void Build()
        {
            string partQuery = $"SELECT * FROM model_structure WHERE model='{type}'";
            MySqlDataReader partReader = GetData(partQuery);
            for (int i = 1; i < partReader.FieldCount; i++)
            {
                if (partReader[partReader.GetName(i)] != DBNull.Value)
                {
                    Part part = new Part(partReader.GetName(i), this.color, partReader.GetInt32(i));
                    this.partList.Add(part.name, part);
                }
            }
            foreach (KeyValuePair<string, Part> part in partList)
            {
                part.Value.Use();
            }
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
    }
}

