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
    public partial class PartsStock : Form
    {
        string searchCriteria = "reference";
        string searchModelCriteria = "name";
        string partInfo = "";
        List<string> clientParams = new List<string>();
        public PartsStock()
        {
            InitializeComponent();
            DataTable parts = GetData(String.Format("Select * from parts_stock_view"));
            dataGridView1.DataSource = parts;

            DataTable bikes = GetData(String.Format("Select * from bike_models_view"));
            dataGridView2.DataSource = bikes;

            string[]  searchCriterions = new string[] { "reference", "name" };
            comboBox1.Items.AddRange(searchCriterions);
            string[] searchModelCriterions = new string[] { "name", "price" };
            comboBox2.Items.AddRange(searchModelCriterions);
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

        private void button1_Click(object sender, EventArgs e)
        {
            var newModel = new NewModel();
            newModel.Location = this.Location;
            newModel.StartPosition = FormStartPosition.Manual;
            newModel.FormClosing += delegate {this.Show(); UpdateBikesTable(); };
            newModel.Show();
            this.Hide();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            partInfo = "";
            clientParams = new List<string>();
            int column = 0;
            try
            {
                while (column < dataGridView1.ColumnCount)
                {
                    partInfo+=(dataGridView1.Rows[e.RowIndex].Cells[column].Value.ToString());
                    clientParams.Add(dataGridView1.Rows[e.RowIndex].Cells[column].Value.ToString());
                    partInfo += "  ";                  
                    column++;
                }
                label2.Text = partInfo;
            }
            catch{
                label2.Text = "";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable datas;
            datas = GetData(String.Format("Select * From parts_stock_view where {0} like '{1}%'", searchCriteria, textBox1.Text));
            //datas.Columns.RemoveAt(0);
            dataGridView1.DataSource = datas;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCriteria = comboBox1.SelectedItem.ToString();
        }

        private void dataGridView2CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            partInfo = "";
            int column = 0;
            try
            {
                while (column < dataGridView2.ColumnCount)
                {
                    partInfo += (dataGridView2.Rows[e.RowIndex].Cells[column].Value.ToString());
                    clientParams.Add(dataGridView2.Rows[e.RowIndex].Cells[column].Value.ToString());
                    partInfo += "  ";
                    column++;
                }
                label6.Text = partInfo;
            }
            catch
            {
                label6.Text = "";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataTable datas;
            datas = GetData(String.Format("Select * From bike_models_view where {0} like '{1}%'", searchModelCriteria, textBox2.Text));
            //datas.Columns.RemoveAt(0);
            dataGridView2.DataSource = datas;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchModelCriteria = comboBox2.SelectedItem.ToString();
        }

        private void UpdatePartsTable()
        {
            DataTable parts = GetData(String.Format("Select * from parts_stock_view"));
            dataGridView1.DataSource = parts;
        }

        private void UpdateBikesTable()
        {
            DataTable bikes = GetData(String.Format("Select * from bike_models_view"));
            dataGridView2.DataSource = bikes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newPart = new AddPart();
            newPart.Location = this.Location;
            newPart.StartPosition = FormStartPosition.Manual;
            newPart.FormClosing += delegate { this.Show(); UpdatePartsTable(); };
            newPart.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ManagerMenus();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ManagerForm();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Stocks();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); UpdateBikesTable(); };
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Part part = new Part(clientParams[0], clientParams[1]);
                if(clientParams[5] == "")
                {
                    clientParams[5] = "0" ; //Abit hardcoded, means that if no data for necessary, default 0 is given. (necessary is bot fixed because no models use that specific part yet)
                }
                var form = new OrderPartForm(part, Convert.ToInt32(clientParams[5]) - (Convert.ToInt32(clientParams[3]) + Convert.ToInt32(clientParams[4])));
                form.Location = this.Location;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { this.Show(); UpdatePartsTable(); InternalApp.SetRequiredPartsList(); };
                form.Show();
            }
            catch
            {
                partInfo = "Please select an item";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DataGridViewCellPaintingEventArgs(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null)
            {
                if (e.ColumnIndex == 5)
                {
                    Color c;
                    if (e.Value != null)
                    {
                        int necessary_value;
                        int to_order;
                        try
                        {
                            necessary_value = Convert.ToInt32(e.Value);
                            int p_ordered = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex -1].Value);
                            int p_stock = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value);
                            to_order = necessary_value - (p_stock + p_ordered); 
                        }
                        catch
                        {
                            to_order = 0;
                        }


                        if (to_order > 0)
                        {
                            c = Color.Salmon;
                        }

                        /* else if (value < 0)
                        {
                            c = Color.Salmon;
                        }
                        else
                        */
                        else 
                        {
                            c = dgv.DefaultCellStyle.BackColor;
                        } 
                        e.CellStyle.BackColor = c;
                    }
                }
            }
        }
    }
}
