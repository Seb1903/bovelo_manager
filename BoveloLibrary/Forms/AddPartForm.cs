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

            //try
            //{
                // Check TODO.txt Issue #1
                Part part = new Part(reference_texte.Text, name_texte.Text);
                part.SaveNewPart(name_texte.Text, provider_box.Text, description_box.Text);
                validation_label.Text = "Part successfully added to the system";
                validation_label.Visible = true;
            //}
            /*catch (Exception x)
            {
                Console.WriteLine(x);
                validation_label.Text = "Error: try another reference";
                validation_label.Visible = true;
            }*/
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}