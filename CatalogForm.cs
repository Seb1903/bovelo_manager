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

        public static List<Basket_bike> Basket_bikes = new List<Basket_bike>();

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
            if (category_chosen != null && color_chosen != null && size_chosen != null && quantity_chosen >= 1)
            {
                Basket_bike basketBike = new Basket_bike() { Category = category_chosen, Color = color_chosen, Size = size_chosen, Quantity = quantity_chosen };
                Basket_bikes.Add(basketBike);
            }
            // MessageBox.Show("La catégorie est : " + Basket_bikes[0].Category);
        }

        private void showBasket_button(object sender, EventArgs e)
        {
            BasketForm basketForm = new BasketForm();
            basketForm.Show();
        }
    }

    public class Basket_bike
    {
        public string Category { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
    }
}
