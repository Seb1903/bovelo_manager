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
            CustomizeBike("City");
        }

        private void explorerBox_Click(object sender, EventArgs e)
        {
            CustomizeBike("Explorer");
        }

        private void adventureBox_Click(object sender, EventArgs e)
        {
            CustomizeBike("Adventure");
        }
        private void CustomizeBike(string category)
        {
            this.Hide();
            BikeCustomisationForm form = new BikeCustomisationForm(category);
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
        }
        private void basketBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            BasketForm form = new BasketForm();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();

        }
    }
}