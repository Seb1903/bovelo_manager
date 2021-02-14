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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
            show_table();
        }

        private void show_table()
        {
            Database db1 = new Database();
            MySqlConnection conn = new MySqlConnection(db1.MyConnection);
       
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Console.WriteLine("Connected");

                string sql = "SELECT * FROM table_client;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                label_db_clients.Items.Clear();

                while (rdr.Read())
                {
                    
                    label_db_clients.Items.Add(rdr[0] + " -- " + rdr[1]);
                }
                rdr.Close();
            }

            catch (Exception ex)

            {
                label_first_name.Text = ex.ToString();
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();   //Let's us protect the password by having a class database with a public string containing the credentials

                //This is my connection string i have assigned the database file address path  
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into table_client(client_lastname,client_firstname,client_country,client_city,client_street,client_number,client_zipcode,client_phoneNumber,client_emailAddress) values('" + this.textBox_lastname.Text + "','" + this.textBox_firstname.Text + "','" + this.textBox_country.Text + "','" + this.textBox_city.Text + "','" + this.textBox_street.Text + "','" + this.numericUpDown1.Value + "','" + this.numericUpDown_zipcode.Value + "','" + this.label_phonenumber.Text + "','" + this.label_email.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(db.MyConnection);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            show_table(); //call function defined earlier to connect to database and show data on a label 
            }

        
    }
}
