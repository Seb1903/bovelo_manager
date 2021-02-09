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
        private static int ClientNumber = 0;
        public int SelfClientNumber;
        private string Country;
        private string City;
        private string Street;
        private int Number;
        private int PostalCode;
        public string Adress;

        public Client(string country, string city, string street, int number, int postalcode)
        {
            ClientNumber++;
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.Number = number;
            this.PostalCode = postalcode;
            this.SelfClientNumber = ClientNumber;
            this.Adress = SetAdress(country, city, street, number, postalcode);
        }

        private string SetAdress(string country, string city, string street, int number, int postalcode)
        {
            string adress = country + " " + street + " " + "n°" + number.ToString() + " " + postalcode.ToString() + " " + city;
            return adress;
        }
    }
}
