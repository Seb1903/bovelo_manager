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
    public partial class Bovelo : Form
    {
        public Bovelo()
        {
            InitializeComponent();
        }


        private void category_choice(object sender, EventArgs e)
        {
            if (category.Text == "City")
            {
                description.Text = "le vélo est un city";
            }
            else
            {
                description.Text = "le vélo n'est pas un city";
            }
        }


        private void addBasket_button(object sender, EventArgs e)
        {

        }

        private void showBasket_button(object sender, EventArgs e)
        {

        }


        private void quantity_scroll(object sender, EventArgs e)
        {

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

        private void validate_button(object sender, EventArgs e)
        {
            MessageBox.Show(color_chosen + size_chosen);
        }
    }
}
