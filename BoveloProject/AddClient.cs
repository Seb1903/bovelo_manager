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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();   //Let's us protect the password by having a class database with a public string containing the credentials

                //This is my connection string i have assigned the database file address path  
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into table_client(id_client,client_lastname,client_firstname,client_country,client_city,client_street,client_number,client_zipcode,client_phoneNumber,client_emailAddress) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "');";
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

            //string connStr = "server=localhost;user=root;database=bovelo;port=3306;password=root"; 

            string connStr = "server=193.191.240.67;user=3BE-GRP5;database=bovelo;port=63305;password=ECAMecam2020";

            MySqlConnection conn = new MySqlConnection(connStr);

            try

            {

                Console.WriteLine("Connecting to MySQL...");

                conn.Open();

                Console.WriteLine("Connected");

                string sql = "SELECT * FROM table_client;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();



                while (rdr.Read())

                {
                    listBox1.Items.Add(rdr[0] + " -- " + rdr[1]);
                }

                rdr.Close();

               

            }

            catch (Exception ex)

            {
                label1.Text = ex.ToString();
            }

            conn.Close();
            label1.Text = "Done";

            }

    
    }
}
