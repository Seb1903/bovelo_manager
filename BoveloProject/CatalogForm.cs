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
        public string category_chosen;
        public int quantity_chosen;
        public string size_chosen;
        public string color_chosen;

        public CatalogForm(string category)
        {
            InitializeComponent();
            this.category_chosen = category;
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
        private void addBasket_button(object sender, EventArgs e)
        {
            if (category_chosen != null && color_chosen != null && size_chosen != null && quantity_chosen >= 1)
            {
                BuyableItem newItem = new BuyableItem(category_chosen, color_chosen, size_chosen, quantity_chosen);
                Bovelo.order.Add(newItem);
            }
            else
            {
                MessageBox.Show("Not all features were selected");
            }
        }
        private void showBasket_button(object sender, EventArgs e)
        {
            BasketForm basketForm = new BasketForm();
            basketForm.Location = this.Location;
            basketForm.StartPosition = FormStartPosition.Manual;
            basketForm.FormClosing += delegate { this.Show(); };
            basketForm.Show();
            this.Hide();
        }
        private void CatalogForm_Load(object sender, EventArgs e)
        {
            if (category_chosen == "City")
            {
                description.Text = "Add description city bike";
            }
            else if (category_chosen == "Explorer")
            {
                description.Text = "Add description explorer bike";
            }
            else if (category_chosen == "Adventure")
            {
                description.Text = "Add description adventure bike";
            }
        }
    }
}