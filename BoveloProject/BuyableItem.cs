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
        public int price { get; set; }


        public BuyableItem(string category, string color, string size, int quantity)
        {
            this.category = category;
            this.color = color;
            this.size = size;
            this.quantity = quantity;
            this.price = setPrice();
        }
        public void Save()
        {
            try
            {
                Database db = new Database();
                string Query = "insert into bike(type, color, size)" +
                    "values('" + this.category + "','" + this.color + "','" + this.size + "');";
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
        private int setPrice()
        {
            int price = 0; 
            if (this.category == "Adventure")
            {
                price = 300;
            }
            else if (this.category == "Explorer")
            {
                price = 350;
            }
            else if (this.category == "City")
            {
                price = 250;
            }
            if (this.size == "28\"")
            {
                price += 20;
            }
            return price;
        }

    }
}
