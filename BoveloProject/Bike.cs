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
        public int serial_number;
        public string type;
        public string color;
        public string size;
        public int price;
        public Dictionary<string, Part> partList = new Dictionary<string, Part>();

        public Bike(int id)
        {
            this.serial_number = id;
            string query1 = $"SELECT * FROM bike WHERE id={serial_number}";
            MySqlDataReader reader1 = GetData(query1);
            this.type = reader1.GetString(1);
            this.size = reader1.GetString(3);
            this.color = reader1.GetString(2);

            Console.WriteLine(type + " " + size + " " + color);

            string query2 = $"SELECT * FROM model_parts WHERE model='{type}'";
            MySqlDataReader reader2 = GetData(query2);

            
            for (int i = 1; i < reader2.FieldCount; i++)
            {
                //Console.WriteLine("column name : " + reader2.GetName(i));
                string query3 = $"SELECT * FROM part_stock WHERE name='{reader2.GetName(i)}'";
                MySqlDataReader reader3 = GetData(query3);
                Console.WriteLine("Result : " + reader3.GetValue(i).ToString());
                //Console.WriteLine("Color : " + reader3.GetString(1));
                /*if (reader3.GetString(1) != "Default") 
                {
                    Part part = new Part(reader2.GetName(i), color, reader2.GetString(i));
                    partList.Add(reader2.GetName(i), part);
                }
                else
                {
                    Part part = new Part(reader2.GetName(i), "Default", reader2.GetString(i));
                    partList.Add(reader2.GetName(i), part);
                }*/   
            }
            // Print partList
            Console.WriteLine("PARTLIST : ");
            foreach(KeyValuePair<string, Part> part in partList)
            {
                Console.WriteLine("Key = {0}, Value = {1}", part.Key, part.Value);
            }
        }
        private static MySqlDataReader GetData(string query)
        {
            Database db = new Database(); 
            MySqlConnection MyConn = new MySqlConnection(db.MyConnection); 
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            MyReader.Read();
            return MyReader;
        }
    }
}

