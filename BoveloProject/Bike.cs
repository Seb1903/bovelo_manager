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
        public Dictionary<string, Part> partList = new Dictionary<string, Part>();
        public int price;
        public int size;

        public Bike(int id)
        {
            this.serial_number = id;
            try
            {
                string query1 = $"SELECT * FROM bike WHERE id={serial_number}";
                MySqlDataReader reader1 = GetData(query1);
                string type = reader1.GetString(1);
                this.size = reader1.GetInt32(3);

                string query2 = $"SELECT * FROM model_parts WHERE model={type}";
                MySqlDataReader reader2 = GetData(query2);
       
                Console.WriteLine("Size : ", size.ToString());
                Console.WriteLine("Type :", type);
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
            return MyReader;
        }
    }
}

