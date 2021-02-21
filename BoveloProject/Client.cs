using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    public class Client
    {
        public int clientID;
        public string firstname;
        public string lastname;
        public string country;
        public string city;
        public string street;
        public int number;
        public int zipcode;
        public string adress;
        public string phoneNumber;
        public string emailAdress;

        public Client(string firstname, string lastname, string country, string city, string street, int number, int zipcode, string phoneNumber, string emailAdress)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.country = country;
            this.city = city;
            this.street = street;
            this.number = number;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.emailAdress = emailAdress;
        }
        public void Save()
        {
            try
            {
                Database db = new Database();   //Let's us protect the password by having a class database with a public string containing the credentials

                //This is my connection string i have assigned the database file address path  
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into table_client(client_lastname,client_firstname,client_country,client_city,client_street,client_number,client_zipcode,client_phoneNumber,client_emailAddress) values('" + this.lastname + "','" + this.firstname + "','" + this.country+ "','" + this.city+ "','" + this.street+ "','" + this.number + "','" + this.zipcode + "','" + this.phoneNumber + "','" + emailAdress + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(db.MyConnection);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                Console.WriteLine("Saved client");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    
}
