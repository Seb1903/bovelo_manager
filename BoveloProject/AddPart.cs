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
            if (reference_texte.Text.Length == 5)
            {
                try
                {
                    // Check TODO.txt Issue #1
                    Part part = new Part(reference_texte.Text, 1);
                    part.SaveNewPart(name_texte.Text);
                    validation_label.Text = "Part successfully added to the system";
                    validation_label.Visible = true;
                }
                catch
                {
                    validation_label.Text = "Error: try another reference";
                    validation_label.Visible = true;
                }
            }
            else
            {
                validation_label.Text = "Error: reference does not match requirements";
                validation_label.Visible = true;
            }
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}