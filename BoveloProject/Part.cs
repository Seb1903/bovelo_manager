using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;

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
            this.color = color;
            this.characteristic = characteristic;
            string query = $"SELECT * FROM part_stock WHERE name={name} AND color={color} AND characteristic={characteristic}";
            MySqlDataReader reader = GetData(query);
            this.quantity = reader.GetInt32(2);
        }

        public void Use()
        {
            quantity--;
            string query = $"UPDATE part_stock SET quantity={quantity} WHERE name={name} AND color={color} AND characteristic={characteristic}";
        }
        public void Order(int quantity)
        {
            this.quantity += quantity;
            string query = $"UPDATE part_stock SET quantity={quantity} WHERE name={name} AND color={color} AND characteristic={characteristic}";
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