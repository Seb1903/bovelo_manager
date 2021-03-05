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
            showClient();
            showPrice();
        }
        private void showBasket()
        {
            Panel panel1 = new Panel();
            // panel1.Location = new Point(0, i * inputSeparation);
            //panel1.AutoSize = true;
            //panel1.BackColor = Color.AntiqueWhite;
            this.Controls.Add(panel1);

            int position = 1;
            foreach (BuyableItem item in Bovelo.order.content)
            {
                Label bikeCategoryLbl = new Label();
                Label bikeColorLbl = new Label();
                Label bikeSizeLbl = new Label();
                Label bikePriceLbl = new Label();
                NumericUpDown quantityBtn = new NumericUpDown();
                Button removeBtn = new Button();

                bikeCategoryLbl.Text = item.category;
                bikeCategoryLbl.Top = position * 20 + 10;
                bikeCategoryLbl.Left = 10;
                bikeCategoryLbl.Size = new Size(60, 20);

                bikeColorLbl.Text = item.color;
                bikeColorLbl.Top = position * 20 + 10;
                bikeColorLbl.Left = 80;
                bikeColorLbl.Size = new Size(60, 20);

                bikeSizeLbl.Text = item.size;
                bikeSizeLbl.Top = position * 20 + 10;
                bikeSizeLbl.Left = 150;
                bikeSizeLbl.Size = new Size(30, 20);

                quantityBtn.Value = item.quantity;
                quantityBtn.Top = position * 20 + 8 ;
                quantityBtn.Left = 200 ;
                quantityBtn.Minimum = 0;
                quantityBtn.Maximum = 100;
                quantityBtn.Size = new Size (70, 20);
                quantityBtn.ValueChanged += (sender, EventArgs) => { quantity_scroll(sender, EventArgs, item); };

                removeBtn.Text = "Remove";
                removeBtn.Top = position * 20 + 8 ;
                removeBtn.Left = 290 ;
                removeBtn.Size = new Size(70, 20);
                removeBtn.Click += (sender, EventArgs) 
                    => { removeBtn_Click(sender, EventArgs, item); };

                bikePriceLbl.Text = "" + item.price + " €";
                bikePriceLbl.Top = position * 20 + 12;
                bikePriceLbl.Left = 380;
                bikePriceLbl.Size = new Size(50, 20);
                bikePriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                position++;

                this.panel1.Controls.Add(bikeCategoryLbl);
                this.panel1.Controls.Add(bikeColorLbl);
                this.panel1.Controls.Add(bikeSizeLbl);
                this.panel1.Controls.Add(quantityBtn);
                this.panel1.Controls.Add(removeBtn);
                this.panel1.Controls.Add(bikePriceLbl);
            }
        }
        private void UpdateForm()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            showClient();
            showBasket();
            showPrice();
            showDeliveryDate()
        }
        private void showClient()
        {
            if (Bovelo.order.client != null)
            {
                this.label_clientName.Text = Bovelo.order.client.firstname + " " + Bovelo.order.client.lastname ;
            }
            else
            {
                this.label_clientName.Text = "";
            }
        }
        private void showPrice()
        {
            this.price.Text = "" + Bovelo.order.totalPrice + " €";
        }
        private void showDeliveryDate()
        {
            this.delivery_time_label.Text = "" + Bovelo.order.deliveryDate;
        }
        private void CheckEmptyCart()
        {
            if (Bovelo.order.content.Count == 0)
            {
                DialogResult result = MessageBox.Show("Your cart is empty! Would you like to go back to catalog?", "Cart Info", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    UpdateForm();
                }
            }
        }
        private void removeBtn_Click(object sender, EventArgs e, BuyableItem item)
        {
            Bovelo.order.Remove(item);
            //MessageBox.Show("Item Removed");
            this.StatusLabel1.Text = "Item Removed";
            UpdateForm();
            CheckEmptyCart();
        }
        private void quantity_scroll(object sender, EventArgs e, BuyableItem item)
        {
            NumericUpDown quantityBtn = sender as NumericUpDown;
            int newQuantity = Decimal.ToInt32(quantityBtn.Value);
            if (newQuantity == 0)
            {
                Bovelo.order.Remove(item);
                //MessageBox.Show("Item Removed");
                this.StatusLabel1.Text = "Item Removed";
                UpdateForm();
            }
            else
            {
                item.quantity = newQuantity;
                //MessageBox.Show("New item quantity : " + item.quantity.ToString());
                this.StatusLabel1.Text = "New item quantity : " + item.quantity.ToString();
                Bovelo.order.UpdatePrice();
                showPrice();
                showDeliveryDate();
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
            Bovelo.order.Empty();
            UpdateForm();
            CheckEmptyCart();
        }
        private void validate_btn_Click(object sender, EventArgs e)
        {
            Bovelo.order.Save();
            if (Bovelo.order.content.Count == 0)
            {
                this.Close();
            }
            this.DialogResult = DialogResult.OK;
        }
        private void select_Client_Click(object sender, EventArgs e)
        {
            var selectclient = new ClientSearch();
            selectclient.Location = this.Location;
            selectclient.StartPosition = FormStartPosition.Manual;
            selectclient.FormClosing += delegate { this.UpdateForm(); this.Show(); };
            selectclient.Show();
            this.Hide();
        }
        private void new_Client_Click(object sender, EventArgs e)
        {
            var newclient = new AddClient();
            newclient.Location = this.Location;
            newclient.StartPosition = FormStartPosition.Manual;
            newclient.FormClosing += delegate {  this.Show(); };
            newclient.Show();
            this.Hide();
        }
    }
}