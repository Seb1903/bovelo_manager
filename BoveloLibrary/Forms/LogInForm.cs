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
            Console.WriteLine("Confirm button pushed");
            if (password_txt.Text == InternalApp.managerPassword)
            {
                Console.WriteLine("Password Confirmed");
                this.Hide();
                ManagerMenus form = new ManagerMenus();
                form.Location = this.Location;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { this.Close(); };
                form.Show();

            }
            else
            {
                Text = "Password or username invalid";
                MessageBox.Show(Text);
            }
        }

        private void password_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (password_txt.Text == InternalApp.managerPassword)
                {
                    this.Hide();
                    var form = new PartsStock();
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
}