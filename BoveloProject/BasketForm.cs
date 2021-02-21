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
    public partial class BasketForm : Form
    {
        public BasketForm()
        {
            InitializeComponent();
        }
        private void BasketForm_Load(object sender, EventArgs e)
        {
            showBasket();      
        }
        private void showBasket()
        {
            int position = 1;
            foreach (BasketItem item in CatalogForm.basket)
            {
                Label bikeCategoryLbl = new Label();
                NumericUpDown quantityBtn = new NumericUpDown();
                Button removeBtn = new Button();

                bikeCategoryLbl.Text = item.category;
                bikeCategoryLbl.Top = position * 20 + 10;
                bikeCategoryLbl.Left = 10;
                bikeCategoryLbl.Size = new Size(80, 20);

                quantityBtn.Value = item.quantity;
                quantityBtn.Top = position * 20 + 10;
                quantityBtn.Left = 100;
                quantityBtn.Minimum = 0;
                quantityBtn.Maximum = 100;
                quantityBtn.Size = new Size (50, 20);
                quantityBtn.ValueChanged += (sender, EventArgs) => { quantity_scroll(sender, EventArgs, item); };

                removeBtn.Text = "remove";
                removeBtn.Top = position * 20 + 10;
                removeBtn.Left = 170;
                removeBtn.Size = new Size(50, 20);
                removeBtn.Click += (sender, EventArgs) => { removeBtn_Click(sender, EventArgs, item); };

                position++;

                this.Controls.Add(bikeCategoryLbl);
                this.Controls.Add(quantityBtn);
                this.Controls.Add(removeBtn);
            }
        }
        private void UpdateForm()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            showBasket();
        }
        private void CheckEmptyCart()
        {
            if (CatalogForm.basket.Count == 0)
            {
                DialogResult result = MessageBox.Show("Your cart is empty! Would you like to go back to catalog?", "Cart Info", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        private void removeBtn_Click(object sender, EventArgs e, BasketItem item)
        {
            CatalogForm.basket.Remove(item); 
            Console.WriteLine("Item Removed");
            UpdateForm();
            CheckEmptyCart();
        }
        private void quantity_scroll(object sender, EventArgs e, BasketItem item)
        {
            NumericUpDown quantityBtn = sender as NumericUpDown;
            int newQuantity = Decimal.ToInt32(quantityBtn.Value);
            if (newQuantity == 0)
            {
                CatalogForm.basket.Remove(item);
                Console.WriteLine("Item Removed");
                UpdateForm();
            }
            else
            {
                item.quantity = newQuantity;
                Console.WriteLine("New item quantity : " + item.quantity.ToString());
            }
            CheckEmptyCart();
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
        private void empty_cart_btn_Click(object sender, EventArgs e)
        {
            CatalogForm.basket.Clear();
        }
        private void validate_Click(object sender, EventArgs e)
        {
            // Confirm order
        }

        private void button_newClient_Click(object sender, EventArgs e)
        {
            var newclient = new AddClient();
            newclient.Location = this.Location;
            newclient.StartPosition = FormStartPosition.Manual;
            newclient.FormClosing += delegate { this.Show(); };
            newclient.Show();
            this.Hide();

        }

        private void button_selectClient_Click(object sender, EventArgs e)
        {
            var selectclient = new ClientSearch();
            selectclient.Location = this.Location;
            selectclient.StartPosition = FormStartPosition.Manual;
            selectclient.FormClosing += delegate { this.Show(); };
            selectclient.Show();
            this.Hide();
        }
    }
}