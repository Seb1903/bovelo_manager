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
    public partial class OrderPartForm : Form
    {
        Part part;
        public OrderPartForm(Part part, int stock_necessary)
        {
            this.part = part; 
            InitializeComponent();
            label_text.Text = "How many " + part.name + " do you want to order ? ";
            numericUpDown1.Value = stock_necessary; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you want to order {numericUpDown1.Value} {part.name} for the stocks ?", "Order for stocks", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.part.Order(Convert.ToInt32(numericUpDown1.Value));
            }

        }
    }
}
