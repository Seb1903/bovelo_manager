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
    public partial class Stocks : Form
    {
        Order stock_order = new Order();
        //List<> = new List<>  

        public Stocks()
        {
            InitializeComponent();
            stock_order.client = get_stock_Client();
            stock_order.totalPrice = 0; 
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (comboBox_bike.SelectedItem != null && comboBox_color.SelectedItem != null && comboBox1.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show($"Do you want to add {numericUpDown1.Value} {comboBox_color.Text} {comboBox_bike.Text} bike(s), size {comboBox1.Text} to the production ?", "Add to stocks", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BuyableItem bike = new BuyableItem(comboBox_bike.Text, comboBox_color.Text, comboBox1.Text, Convert.ToInt32(numericUpDown1.Value));
                    stock_order.Add(bike);
                    stock_order.totalPrice = 0;
                    stock_order.Save();
                    add_to_Stock(Convert.ToInt32(numericUpDown1.Value)); //uses stocked procedure 
                    stock_order.client = get_stock_Client(); //Save method deletes current client
                }
                else
                {

                }
            }
            
        }
        private void add_to_Stock(int n) //put it in BuyableItem ? 
        {
            Database db = new Database();
            MySqlConnection MyConn = new MySqlConnection(db.MyConnection);
            using (var command = new MySqlCommand("AddToStock", MyConn)
            {
                CommandType = CommandType.StoredProcedure 
                
            })
            
            {
                command.Parameters.AddWithValue("@N", n);
                MyConn.Open();
                command.ExecuteNonQuery();
                MyConn.Close();
            }
        }

         private Client get_stock_Client()
        {
            try
            {
                Database db = new Database();
                string Query = "Select * from client where id = 1";
                MySqlConnection MyConn = new MySqlConnection(db.MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                MyReader.Read();           
                Client client = new Client(1 ,MyReader.GetString(1), MyReader.GetString(2), MyReader.GetString(3), MyReader.GetString(4), MyReader.GetString(5), MyReader.GetInt32(6), MyReader.GetInt32(7), MyReader.GetString(8), MyReader.GetString(9));
                MyConn.Close();
                return client; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
