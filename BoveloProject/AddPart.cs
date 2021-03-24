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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Part.AddNewPart(textBox1.Text);
                validation_label.Text = "Part add to systeme";
                validation_label.Visible = true; 
            }
            catch
            {
                validation_label.Text = "Error";
                validation_label.Visible = true;
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}