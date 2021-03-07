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
    public partial class ChooseUser : Form
    {
        public ChooseUser()
        {
            InitializeComponent();
        }

        private void Managerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Password form = new Password
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            form.FormClosing += delegate { this.Show(); };
            form.Show();
        }

        private void Fitterbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MON SAC EST FAIT");
            //add the new form
            /*
            this.Hide();
            BikeCustomisationForm form = new BikeCustomisationForm(category);
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            */
        }
    }
}