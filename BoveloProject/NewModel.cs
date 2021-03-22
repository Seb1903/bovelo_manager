using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Bovelo
{
    public partial class NewModel : Form
    {
        string searchCriteria = "reference";
        string partInfo = "";
        string model_partInfo = "";
        List<string> partParams = new List<string>();
        List<string> model_partParams = new List<string>();
        Bike bike = new Bike();

        public NewModel()
        {
            InitializeComponent();
            DataTable datas = GetData(String.Format("Select * from parts_stock_view"));
            dataGridView1.DataSource = datas;
            LoadModelTable();
            string[] searchCriterions = new string[] { "reference", "name" };
            comboBox1.Items.AddRange(searchCriterions);
        }

        private void LoadModelTable()  //updates the whole table with the added parts 
        {
            var bs = new BindingSource();   //not optimal but only works like this
            bs.DataSource = bike.partList;
            dataGridView2.DataSource = bs;
            dataGridView2.Update();
            dataGridView2.Refresh();

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
            //instancier client
            if (partParams.Count != 0)
            {
                Part part = new Part(partParams[0], Convert.ToInt32(numericUpDown_quantity.Value));
                bike.addPart(part);
            }
            else
            {
            }
            partParams.Clear();
            LoadModelTable();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            partInfo = "";
            int column = 0;
            try
            {
                while (column < dataGridView1.ColumnCount)
                {
                    partInfo += (dataGridView1.Rows[e.RowIndex].Cells[column].Value.ToString());
                    partParams.Add(dataGridView1.Rows[e.RowIndex].Cells[column].Value.ToString());
                    partInfo += " ";
                    column++;
                }
                label2.Text = partInfo;
            }
            catch
            {
                label2.Text = "";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable datas;
            datas = GetData(String.Format("Select * From parts_catalog where {0} like '{1}%'", searchCriteria, textBox1.Text));
            datas.Columns.RemoveAt(0);
            dataGridView1.DataSource = datas;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCriteria = comboBox1.SelectedItem.ToString();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            model_partInfo = "";
            int column = 0;
            try
            {
                while (column < dataGridView2.ColumnCount)
                {
                    model_partInfo += (dataGridView2.Rows[e.RowIndex].Cells[column].Value.ToString());
                    model_partParams.Add(dataGridView2.Rows[e.RowIndex].Cells[column].Value.ToString());
                    model_partInfo += " ";
                    column++;
                }
                label8.Text = model_partInfo;
            }
            catch
            {
                label2.Text = "";
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (model_partParams.Count != 0)
            {
                bike.deletePart(model_partParams[0]);
            }
            else
            {
            }
            model_partParams.Clear();
            LoadModelTable();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!(textBox_modelName.Text == null || numericUpDown1.Value == 0 )){
                bike.price = Convert.ToInt32(numericUpDown1.Value);
                bike.type = textBox_modelName.Text;
                bike.saveModel();
                this.bike = new Bike();
                LoadModelTable();
            }
            else
            {
                MessageBox.Show("Insert a name for the model and a price ");
            }
        }
    }
}
