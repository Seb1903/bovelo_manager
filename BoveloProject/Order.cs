using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
            this.date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"); //Formatted for SQL 
            this.deliveryDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"); //TEMPORARY implementatio, will be changed in next iterations

            this.content = new List<BuyableItem>();
        }
        public void Add(BuyableItem newItem)
        {
            bool itemAlreadyInBasket = false;
            foreach (BuyableItem item in content)
            {
                if (item.category == newItem.category && item.color == newItem.color && item.size == newItem.size)
                {
                    DialogResult result = MessageBox.Show("A bike with these features already exists. Do you still want to add it to basket?", "Cart Info", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        item.quantity += newItem.quantity;
                        Console.WriteLine("Quantity Updated Successfully!");
                    }
                    itemAlreadyInBasket = true;
                    break;
                }
            }
            if (!itemAlreadyInBasket)
            {
                content.Add(newItem);
                Console.WriteLine("Item Added successfully!");
            }
        }
        public void Remove(BuyableItem buyableItem)
        {
            content.Remove(buyableItem);
            Console.WriteLine("Item Removed");
        }
        public void Empty()
        {
            content.Clear();
        }
        public void AddClient(Client client)
        {
            this.client = client;
        }
        public void Save()
        {
            try //First we save the order in the order table. 
            {
                Database db = new Database();
                string Query = "insert into table_order(id_client, order_date, order_deliveryDate, order_totalPrice)" +
                    "values('" + Bovelo.order.client.clientID + "','" + Bovelo.order.date + "','" + Bovelo.order.deliveryDate + "','" + Bovelo.order.totalPrice + "');";
                MySqlConnection MyConn = new MySqlConnection(db.MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                Console.WriteLine("Order Saved");
                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (BuyableItem item in content) //then we save each Item in the Bike table 
            {
                for (int i = 0; i < item.quantity; i++)
                {
                    item.Save();  
                    // once the item is saved, we save the mapping to the order thanks to a trigger in the bike table(AFTER INSERT)
                }
            }
            this.Empty();
            MessageBox.Show("Order Confirmed!"); 
        }
        
    }
}