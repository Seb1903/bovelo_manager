using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    public class Order
    {
        public List<BuyableItem> content;
        public int orderNumber;
        public string date;
        public string deliveryDate;
        public Client client;
        public double totalPrice;

        public Order()
        {
            this.date = DateTime.Now.ToString();
            this.content = new List<BuyableItem>();
        }
        public void AddProduct(BuyableItem newItem)
        {
            bool itemAlreadyInBasket = false;
            foreach (BuyableItem item in content)
            {
                if (item.category == newItem.category && item.color == newItem.color && item.size == newItem.size)
                {
                    item.quantity += newItem.quantity;
                    itemAlreadyInBasket = true;
                    Console.WriteLine("Item already in basket, update quantity successfully!");
                    break;
                }
            }
            if (!itemAlreadyInBasket)
            {
                content.Add(newItem);
                Console.WriteLine("Item added to basket successfully!");
            }
        }
        public void DeleleteProduct(BuyableItem buyableItem)
        {
            content.Remove(buyableItem);
            Console.WriteLine("Item Removed");
        }
        public void EmptyBasket()
        {
            content.Clear();
        }
        public void AddClient(Client client)
        {
            this.client = client;
        }
        public void Save()
        {
            try
            {
                Database db = new Database();   //Let's us protect the password by having a class database with a public string containing the credentials
                foreach (BuyableItem item in content)
                {
                    //This is my connection string i have assigned the database file address path  
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into table_bike(bike_type,bike_color,bike_size) values('" + item.category + "','" + item.color + "','" + item.size + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(db.MyConnection);
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    Console.WriteLine("Save Data");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}