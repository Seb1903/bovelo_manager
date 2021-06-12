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
        public string address;
        public string phoneNumber;
        public string emailAddress;

        public Client( string lastname, string firstname, string country, string city, string street, int number, int zipcode, string phoneNumber, string emailAddress)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.country = country;
            this.city = city;
            this.street = street;
            this.number = number;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }
        public Client(int id, string lastname, string firstname, string country, string city, string street, int number, int zipcode, string phoneNumber, string emailAddress)
        {
            this.clientID = id; //Create method to search from known elements ... 
            this.firstname = firstname;
            this.lastname = lastname;
            this.country = country;
            this.city = city;
            this.street = street;
            this.number = number;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }
        public void Save()
        {
            try
            {
                Database db = new Database();   
                // Protect the password by having a class database with a public string containing the credentials
                //This is my connection string i have assigned the database file address path  
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into client(lastname,firstname,country,city,street,number,zipcode,phoneNumber,emailAddress) values('" + this.lastname + "','" + this.firstname + "','" + this.country+ "','" + this.city+ "','" + this.street+ "','" + this.number + "','" + this.zipcode + "','" + this.phoneNumber + "','" + emailAddress + "');";
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
