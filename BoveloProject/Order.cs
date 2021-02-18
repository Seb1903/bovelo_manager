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
        //coucou
        public List<BuyableItem> basket;
        public int orderNumber;
        public string date;
        public string deliveryDate;
        public Client client;
        public double totalPrice;

        public Order()
        {
            this.date = DateTime.Now.ToString();
            this.basket = new List<BuyableItem>;
        }
        /*
        private int SetPrice(List<Bike> bikes)
        {
            int SumPrice = 0;
            foreach (Bike bike in bikes)
            {
                SumPrice += bike.price;
            }
            return SumPrice;
        }
        */
        public void AddProduct(BuyableItem buyableItem)
        {
            basket.Add(buyableItem);
        }
        public void DelProduct(BuyableItem buyableItem)
        {
            basket.Remove(buyableItem);
        }
        public void EmptyBasket()
        {
            basket.Clear();
        }
        public void AddClient(Client client)
        {
            this.client = client;
        }
    }
}