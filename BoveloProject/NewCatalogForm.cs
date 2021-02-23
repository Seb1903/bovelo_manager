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
    public partial class NewCatalogForm : Form
    {

        public NewCatalogForm()
        {
            InitializeComponent();
        }

        private void NewCatalogForm_Load(object sender, EventArgs e)
        {
            int position = 1;
            string productCategory = Bovelo.catalogProduct[0];

            Button product1Btn = new Button();
            product1Btn.Text = productCategory;
            product1Btn.Top = position * 20 + 10;
            product1Btn.Left = 50;
            product1Btn.Size = new Size(70, 20);
            product1Btn.Click += (s, EventArgs) 
                => { product1Btn_Click(sender, EventArgs, productCategory); };

            position++;
            this.Controls.Add(product1Btn);

        }
        private void product1Btn_Click(object sender, EventArgs e, string category)
        {
            CatalogForm form = new CatalogForm(category);
            form.ShowDialog();
            Console.WriteLine("Bike Selected: " + category);
        }
    }
}