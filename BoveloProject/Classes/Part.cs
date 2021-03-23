using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data;
using System.ComponentModel;

namespace Bovelo
{
    public class Part
    {
        [DisplayName("Reference")]
        public string reference { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Quantity")]
        public int quantity { get; set; }
        [DisplayName("Stock")]
        public int stock { get; set; }

        public Part(string reference, int quantity)
        {
            this.reference = reference;
            this.quantity = quantity;

            DataTable nameTable = InternalApp.GetDataTable($"SELECT * FROM parts_catalog WHERE reference='{reference}'"); //Facultatif
            this.name = nameTable.Rows[0].Field<string>("name");

            DataTable partDataTable = InternalApp.GetDataTable($"SELECT * FROM parts_stock WHERE reference='{reference}'");
            this.stock = Convert.ToInt32(partDataTable.Rows[0]["quantity"]);
        }
        
        public void Use()
        {
            stock -= quantity;
            InternalApp.ExecuteQuery($"UPDATE parts_stock SET quantity={stock} WHERE reference='{reference}'");
        }
        
        public void Order(int quantity)
        {
            this.stock += quantity;
            InternalApp.ExecuteQuery($"UPDATE parts_stock SET quantity={this.stock} WHERE reference='{reference}'");
        }
        
        public void AutoOrder()
        {
            if(stock <= quantity * 50) //if stock under 50 bikes parts
            {
                Order(40 * quantity); //Order 40 bikes parts
            }
        }
    }
}