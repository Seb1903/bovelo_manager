using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bovelo
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        public string category_chosen;
        int quantity_chosen;
        string size_chosen;
        string color_chosen;

        public static List<BasketItem> basket = new List<BasketItem>();
        private void category_choice(object sender, EventArgs e)
        {
            if (category.Text == "City")
            {
                description.Text = "Add description city bike";
            }
            else if (category.Text == "Explorer")
            {
                description.Text = "Add description explorer bike";
            }
            else
            {
                description.Text = "Add description adventure bike";
            }

            category_chosen = category.Text;
        }

        private void quantity_scroll(object sender, EventArgs e)
        {
            quantity_chosen = Decimal.ToInt32(quantity.Value);
        }

        private void size1_check(object sender, EventArgs e)
        {
            size_chosen = size1.Text;
        }

        private void size2_check(object sender, EventArgs e)
        {
            size_chosen = size2.Text;
        }

        private void color1_check(object sender, EventArgs e)
        {
            color_chosen = color1.Text;
        }

        private void color2_check(object sender, EventArgs e)
        {
            color_chosen = color2.Text;
        }

        private void color3_check(object sender, EventArgs e)
        {
            color_chosen = color3.Text;
        }

        public void addBasket_button(object sender, EventArgs e)
        {
            bool itemAlreadyInBasket = false;
            if (category_chosen != null && color_chosen != null && size_chosen != null && quantity_chosen >= 1)
            {
                BasketItem newItem = new BasketItem() {category = category_chosen, color = color_chosen, size = size_chosen, quantity = quantity_chosen};
                foreach (BasketItem item in basket)
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
                    basket.Add(newItem);
                    Console.WriteLine("Item added to basket successfully!");
                }
            }
        }
        private void showBasket_button(object sender, EventArgs e)
        {
            this.Hide();
            BasketForm basketForm = new BasketForm();
            basketForm.ShowDialog();
            this.Show();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {

        }
    }

    public class BasketItem
    {
        public string category { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public int quantity { get; set; }
    }
}
