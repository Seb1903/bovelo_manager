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
                    Part part = new Part(reference_texte.Text, name_texte.Text);
                    part.SaveNewPart();
                    validation_label.Text = "Part added to system.";
                    validation_label.Visible = true;
                }
                catch
                {
                    validation_label.Text = "Error : maybe try another reference. ";
                    validation_label.Visible = true;
                }
            }
            else
            {
                validation_label.Text = "Your reference does not correspond to the standard.";
                validation_label.Visible = true;
            }

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}