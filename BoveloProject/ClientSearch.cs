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
    public partial class ClientSearch : Form
    {
        string search_criteria = "client_lastname";
        string client_info = "";
        List<string> client_params = new List<string>();
        public ClientSearch()
        {
            InitializeComponent();
            dataGridView1.DataSource = GetData(String.Format("Select * From table_client"));
            string[] search_criterions;
            search_criterions = new string[] { "client_lastname", "client_firstname", "client_city", "client_street", "client_emailAddress" };
            comboBox1.Items.AddRange(search_criterions);
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
            Client client = new Client(client_params[1], client_params[0], client_params[2], client_params[3], client_params[4], Convert.ToInt32(client_params[5]), Convert.ToInt32(client_params[6]), client_params[7], client_params[8]);
            /*
            //set the client atribute of order class when order class will be fully implemented
            Order order.client=client;
            */
            client_params.Clear();
            Bovelo.order.client = client;    // defines the static client of the Bovelo application
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            client_info = "";
            int column = 0;
            try
            {
                while (column < dataGridView1.ColumnCount)
                {
                    client_info+=(dataGridView1.Rows[e.RowIndex].Cells[column].Value.ToString());
                    if (column > 0)
                    {
                        client_params.Add(dataGridView1.Rows[e.RowIndex].Cells[column].Value.ToString());
                    }
                    client_info += " ";                  
                    column++;
                }
                label2.Text = client_info;
            }
            catch{
                label2.Text = "";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData(String.Format("Select * From table_client where {0} like '{1}%'",search_criteria ,textBox1.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_criteria = comboBox1.SelectedItem.ToString();
        }
    }
}
