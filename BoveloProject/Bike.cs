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
            string query1 = $"SELECT * FROM bike WHERE id={id}";
            MySqlDataReader reader1 = GetData(query1);

            this.type = reader1.GetString(1);
            this.color = reader1.GetString(2);
            this.size = reader1.GetString(3);

            string query2 = $"SELECT * FROM model_parts WHERE model='{type}'";
            MySqlDataReader reader2 = GetData(query2);
            for (int i = 1; i < reader2.FieldCount; i++)
            {
                if(reader2[reader2.GetName(i)] != DBNull.Value)
                {
                    Part part = new Part(reader2.GetName(i), color, reader2.GetString(i));
                    partList.Add(reader2.GetName(i), part);  
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

