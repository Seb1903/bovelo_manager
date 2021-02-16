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
            int position = 1;
            foreach(BasketItem item in CatalogForm.basket)
            {
                Label bikeCategoryLbl = new Label();
                NumericUpDown quantityBtn = new NumericUpDown();
                Button removeBtn = new Button();

                bikeCategoryLbl.Text = item.category;
                bikeCategoryLbl.Top = position * 25;
                bikeCategoryLbl.Left = 10;

                quantityBtn.Value = item.quantity;
                quantityBtn.Top = position * 25;
                quantityBtn.Left = 200;

                removeBtn.Text = "remove";
                removeBtn.Top = position * 25;
                removeBtn.Left = 400;

                position++;

                this.Controls.Add(bikeCategoryLbl);
                this.Controls.Add(quantityBtn);
                this.Controls.Add(removeBtn);
            }
            
        }

        private void validate_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.OK;
        }

        private void empty_cart_btn_Click(object sender, EventArgs e)
        {
            CatalogForm.basket.Clear();
        }
    }
}