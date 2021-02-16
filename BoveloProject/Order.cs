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
        public List<Bike> listBike = new List<Bike>();
        public int orderNumber;
        public string date;
        public string deliveryDate;
        public Client client;
        public double totalPrice;

        public Order(List<Bike> bikes, Client client)
        {
            this.date = DateTime.Now.ToString();
            this.listBike = bikes;
            this.client = client;
            this.totalPrice = SetPrice(bikes);
        }

        private int SetPrice(List<Bike> bikes)
        {
            int SumPrice = 0;
            foreach (Bike bike in bikes)
            {
                SumPrice += bike.price;
            }
            return SumPrice;
        }
    }
}