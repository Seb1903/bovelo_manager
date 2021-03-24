using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    public partial class BrokenPart : Form
    {
        private string name;
        private string color;
        private int partDeleted = 0;
        public BrokenPart()
        {
            InitializeComponent();
            RefreshDataGriedView();
        }
        private void RefreshDataGriedView()
        {
            DataTable datas;
            datas = GetData(String.Format("Select * From part_stock"));
            //datas.Columns.RemoveAt(3);
            stock_dataGridView.DataSource = datas;
        }
        private static DataTable GetData(string sqlCommand)
        {
            Database db1 = new Database();
            MySqlConnection conn = new MySqlConnection(db1.MyConnection);


            MySqlCommand command = new MySqlCommand(sqlCommand, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }
        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            DataTable datas;
            datas = GetData(String.Format("Select * From part_stock where name like '{0}%'", search_textbox.Text));
            stock_dataGridView.DataSource = datas;
            //datas.Columns.RemoveAt(3);
        }

        private void stock_dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string partInformation = ""; 
            try
            {
                name = (stock_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                partInformation += name;

                /*
                partInformation += " ";
                
                color = (stock_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                partInformation += color;

                selectedPart_label.Text = partInformation;
                selectedPart_label.Visible = true;
                */
            }
            catch
            {
                selectedPart_label.Text = "";
            }
        }

        private void validation_button_Click(object sender, EventArgs e)
        {
            if (partDeleted == 0)
            {
                try
                {
                    Part part = new Part(name, color, 1);
                    part.Use();
                    information_label.Text = "Part removed from stock";
                    information_label.Visible = true;
                    partDeleted += 1;
                    RefreshDataGriedView();
                }
                catch
                {
                    information_label.Text = "Error, try again";
                    information_label.Visible = true;
                }
            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("A part has already been deleted. Do you want to delete 1 more ?","Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        Part part = new Part(name, color, 1);
                        part.Use();
                        information_label.Text = "Part removed from stock";
                        information_label.Visible = true;
                        partDeleted += 1;
                        RefreshDataGriedView();
                    }
                    catch
                    {
                        information_label.Text = "Error, try again";
                        information_label.Visible = true;
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
