using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    public class BuyableItem
    {
        public string category { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public int quantity { get; set; }

        public BuyableItem(string category, string color, string size, int quantity)
        {
            this.category = category;
            this.color = color;
            this.size = size;
            this.quantity = quantity;
        }
        public void Save()
        {
            try
            {
                Console.WriteLine("connecting to DB");
                Database db = new Database();
                string Query = "insert into table_bike(bike_type, bike_color, bike_size)" +
                    "values('" + this.category + "','" + this.color + "','" + this.size + "');";
                Console.WriteLine("Query created");
                MySqlConnection MyConn = new MySqlConnection(db.MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                Console.WriteLine("Bike Saved");
                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
