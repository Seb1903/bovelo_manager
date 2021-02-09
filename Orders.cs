using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bovelo
{
    public class Orders
    {
        private static int OrderNumber = 0;
        public List<Bike> ListBike = new List<Bike>();
        public int SelfOrderNumber;
        public string Date;
        public string DeliveryDate;
        public Client Client;
        public double price;

        public Orders(List<Bike> Bikes, Client Client)
        {
            OrderNumber++;
            //to automate order numbers
            this.SelfOrderNumber = OrderNumber;
            this.Date = DateTime.Now.ToString();
            this.ListBike = Bikes;
            this.Client = Client;
            this.price = SetPrice(Bikes);
        }

        private int SetPrice(List<Bike> Bikes)
        {
            int SumPrice = 0;
            foreach (Bike bike in Bikes)
            {
                SumPrice += bike.price;
            }
            return SumPrice;
        }
    }
}