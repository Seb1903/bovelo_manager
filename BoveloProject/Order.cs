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
            this.date = DateTime.Now.ToString();
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
            foreach (BuyableItem item in content)
            {
                for (int i = 0; i < item.quantity; i++)
                {
                    item.Save();
                } 
            }
            this.Empty();
            MessageBox.Show("Order Confirmed!"); 
        }
    }
}