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

        }
        private void cityBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productCategory = Bovelo.catalogProduct[0];
            CatalogForm form = new CatalogForm(productCategory);
            form.ShowDialog();
            label1.Text = productCategory;
            Console.WriteLine("Bike Selected: " + productCategory);
        }

        private void explorerBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productCategory = Bovelo.catalogProduct[1];
            CatalogForm form = new CatalogForm(productCategory);
            form.ShowDialog();
            label2.Text = productCategory;
            Console.WriteLine("Bike Selected: " + productCategory);
        }

        private void adventureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productCategory = Bovelo.catalogProduct[2];
            CatalogForm form = new CatalogForm(productCategory);
            form.ShowDialog();
            label3.Text = productCategory;
            Console.WriteLine("Bike Selected: " + productCategory);
        }
    }
}