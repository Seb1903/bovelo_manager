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
        public Bike(int id)
        {
            this.id = id;
            string bikeQuery = $"SELECT * FROM bike WHERE id={serial_number}";
            MySqlDataReader bikeReader = GetData(bikeQuery);
            this.type = bikeReader.GetString(1);
            this.color = bikeReader.GetString(2);
            this.size = bikeReader.GetString(3);
        }
        public void Build()
        {
            string partQuery = $"SELECT * FROM model_parts WHERE model='{type}'";
            MySqlDataReader partReader = GetData(partQuery);
            for (int i = 1; i < partReader.FieldCount; i++)
            {
                if (partReader[partReader.GetName(i)] != DBNull.Value)
                {
                    Part part = new Part(partReader.GetName(i), this.color, partReader.GetString(i));
                    this.partList.Add(partReader.GetName(i), part);
                }
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
                Console.WriteLine("\nType: {0} \n----Color = {1} \n----Characteristic = {2} \n----Quantity = {3}",
                    part.Key, part.Value.color, part.Value.characteristic, part.Value.quantity);
            }
            return ("\n" + type + " " + size + " " + color);
        }
    }
}

