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
            addItem(category_chosen, color_chosen, size_chosen, quantity_chosen);
        }

        private void showBasket_button(object sender, EventArgs e)
        {
            this.Hide(); 
            BasketForm basketForm = new BasketForm();
            basketForm.ShowDialog();
            this.Show();
        }

        private void addItem(string category_chosen, string color_chosen, string size_chosen, int quantity_chosen)
        {
            if (category_chosen != null && color_chosen != null && size_chosen != null && quantity_chosen >= 1)
            {
                bool state = basket.Exists(bike => bike.Equality(category_chosen, color_chosen, size_chosen)); // true if equals

                if (state)
                {
                    MessageBox.Show("A bike with these features already exists");
                }
                else
                {
                    BasketItem item = new BasketItem() { category = category_chosen, color = color_chosen, size = size_chosen, quantity = quantity_chosen };
                    basket.Add(item);
                    MessageBox.Show("Item was added succesfully");
                }
            }
            else
            {
                MessageBox.Show("Not all features were selected");
            }
        }
    }

    public class BasketItem
    {
        public string category { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public int quantity { get; set; }

        public bool Equality (string category_chosen, string color_chosen, string size_chosen)
        {
            return (this.category == category_chosen) && (this.color == color_chosen) && (this.size == size_chosen); // tout est pareil
        }
    }
}