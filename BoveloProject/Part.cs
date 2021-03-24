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
    /*
        Every single argument get requested in database and placed as a 
        parameter in the constructor.

        The part gets fours parameters
            > The name of the part
            > The color
            > The quantity
            > The characteristics : contains bike specific specifications
    */
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
            this.stock = partDataTable.Rows[0].Field<int>("quantity");
        }
        public void Use()
        {
            stock-=quantity;
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
        public static void AddNewPart(string name)
        {
            int intReference = CountPart() + 1;
            string formatedReference = Convert.ToString(intReference);
            while (formatedReference.Length < 5)
            {
                formatedReference = "0" + formatedReference;
            }
            string query = $"INSERT INTO `parts_catalog` (`reference`, `name`) VALUES ('{formatedReference}', '{name}')";
            InternalApp.ExecuteQuery(query);
        }
        public static int CountPart()
        {
            Database db = new Database();
            using (var conn = new MySqlConnection(db.MyConnection))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM parts_catalog", conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    return count;
                }
            }
        }
    }
}