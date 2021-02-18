using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
    }
}