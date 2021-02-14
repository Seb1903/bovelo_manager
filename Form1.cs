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
    public class Basket_bike
    {
        public string Category { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string category_chosen;

        private void category_choice(object sender, EventArgs e)
        {
            if (category.Text == "City")
            {
                description.Text = "le vélo est un city";
            }
            else if (category.Text == "Explorer")
            {
                description.Text = "le vélo est un explorer";
            }
            else
            {
                description.Text = "le vélo est un adventure";
            }

            category_chosen = category.Text;
        }

        int quantity_chosen;


        private void quantity_scroll(object sender, EventArgs e)
        {
            quantity_chosen = Decimal.ToInt32(quantity.Value);
        }

        string size_chosen;

        private void size1_check(object sender, EventArgs e)
        {
            size_chosen = size1.Text;
        }

        private void size2_check(object sender, EventArgs e)
        {
            size_chosen = size2.Text;
        }

        string color_chosen;

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

        private void addBasket_button(object sender, EventArgs e)
        {
            if (category_chosen != null && color_chosen != null && size_chosen != null && quantity_chosen >= 1)
            {
                Basket_bike basketBike = new Basket_bike() { Category = category_chosen, Color = color_chosen, Size = size_chosen, Quantity = quantity_chosen };
            }
            // MessageBox.Show("La catégorie est : " + basket_bike.Category);
        }

        private void showBasket_button(object sender, EventArgs e)
        {
            
        }
    }
}
