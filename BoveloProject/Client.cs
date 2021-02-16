using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
        public int phoneNumber;
        public string emailAdress;

        public Client(string firstname, string lastname, string country, string city, string street, int number, int zipcode, int phoneNumber, string emailAdress)
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
            //this.adress = SetAdress(country, city, street, number, zipcode);
        }

        /*
        private string SetAdress(string country, string city, string street, int number, int zipcode)
        {
            string adress = country + " " + street + " " + "n°" + number.ToString() + " " + zipcode.ToString() + " " + city;
            return adress;
        }
        */
    }
}
