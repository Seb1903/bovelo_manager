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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            if (password_txt.Text == Bovelo.managerPassword)
            {
                Text = "validation";
                MessageBox.Show(Text);

                this.Hide();
                ManagerForm form = new ManagerForm();
                form.Location = this.Location;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { this.Show(); };
                form.Show();

            }
            else
            {
                Text = "Password or username invalid";
                MessageBox.Show(Text);
            }
        }
    }
}