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
        private int FacadeNumber;
        private int PostalCode;
        public string Adress;
        
        public void Client(string country,string city, string street,int facadenumber,int postalcode) 
        {
            ClientNumber++;
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.FacadeNumber = facadenumber;
            this.PostalCode = postalcode;
            this.SelfClientNumber = ClientNumber;
            this.Adress = SetAdress(country,city,street,facadenumber,postalcode);
        }
        
        private string SetAdresse(string country, string city, string street, int facadenumber, int postalcode)
        {
            string adress = country + " " + street + " " + "n°" + facadenumber.ToString() + " " + postalcode.ToString() + " " + city;
            return adress;
        }
    }
}