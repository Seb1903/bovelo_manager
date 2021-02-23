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
        string searchCriteria = "lastname";
        string clientInfo = "";
        List<string> clientParams = new List<string>();
        public ClientSearch()
        {
            InitializeComponent();
            DataTable datas;
            datas = GetData(String.Format("Select * From client"));
            datas.Columns.RemoveAt(0);
            dataGridView1.DataSource = datas;
            string[] searchCriterions;
            searchCriterions = new string[] { "lastname", "firstname", "city", "street", "emailAddress" };
            comboBox1.Items.AddRange(searchCriterions);
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
            if (clientParams.Count != 0)
            {
                Client client = new Client(clientParams[0], clientParams[1], clientParams[2], clientParams[3], clientParams[4], Convert.ToInt32(clientParams[5]), Convert.ToInt32(clientParams[6]), clientParams[7], clientParams[8]);
                label2.Text = "Client selected";
                Console.WriteLine(client.phoneNumber);
                DataTable id_data = GetData(String.Format("Select id From client where phoneNumber like '{0}'", client.phoneNumber));
                string instr= id_data.Rows[0]["id"].ToString();
                Console.WriteLine(instr);
                int clientID = Convert.ToInt32(instr);
                Bovelo.order.AddClient(client,clientID);
            }
            else
            {
                label2.Text = "Please select a client";
            }
            
            clientParams.Clear();
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clientInfo = "";
            int column = 0;
            try
            {
                while (column < dataGridView1.ColumnCount)
                {
                    clientInfo+=(dataGridView1.Rows[e.RowIndex].Cells[column].Value.ToString());
                    clientParams.Add(dataGridView1.Rows[e.RowIndex].Cells[column].Value.ToString());
                    clientInfo += " ";                  
                    column++;
                }
                label2.Text = clientInfo;
            }
            catch{
                label2.Text = "";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable datas;
            datas = GetData(String.Format("Select * From client where {0} like '{1}%'", searchCriteria, textBox1.Text));
            datas.Columns.RemoveAt(0);
            dataGridView1.DataSource = datas;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCriteria = comboBox1.SelectedItem.ToString();
        }
    }
}
