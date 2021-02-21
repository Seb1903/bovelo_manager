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
        public List<Bike> listBike = new List<Bike>();
        public int orderNumber;
        public string date;
        public string deliveryDate;
        public Client client;
        public double totalPrice;

        public Order()
        {
            this.date = DateTime.Now.ToString();
            this.client = client;
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