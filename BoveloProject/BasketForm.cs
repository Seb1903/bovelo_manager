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
            foreach (BuyableItem item in CatalogForm.order.content)
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
            if (CatalogForm.order.content.Count == 0)
            {
                DialogResult result = MessageBox.Show("Your cart is empty! Would you like to go back to catalog?", "Cart Info", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        private void removeBtn_Click(object sender, EventArgs e, BuyableItem item)
        {
            CatalogForm.order.DeleleteProduct(item); 
       
            UpdateForm();
            CheckEmptyCart();
        }
        private void quantity_scroll(object sender, EventArgs e, BuyableItem item)
        {
            NumericUpDown quantityBtn = sender as NumericUpDown;
            int newQuantity = Decimal.ToInt32(quantityBtn.Value);
            if (newQuantity == 0)
            {
                CatalogForm.order.DeleleteProduct(item);
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
            CatalogForm.order.EmptyBasket();
        }
        private void validate_Click(object sender, EventArgs e)
        {
            // Confirm order
        }
    }
}