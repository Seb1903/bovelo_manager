using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void AddToDb()
        {
            // db request
        }

    }
}
