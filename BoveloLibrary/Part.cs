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
            > The part name
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
            string strQuantity;
            this.reference = reference;
            this.quantity = quantity;
            DataTable nameTable = InternalApp.GetDataTable($"SELECT * FROM parts_catalog WHERE reference='{reference}'"); //Facultatif
            this.name = nameTable.Rows[0].Field<string>("name");
            DataTable partDataTable = InternalApp.GetDataTable($"SELECT * FROM parts_stock WHERE reference='{reference}'");
            DataRow partDataRow = partDataTable.Rows[0];
            strQuantity = partDataRow["quantity"].ToString();
            this.stock = Int32.Parse(strQuantity);
        }
        // Check TODO.txt Issue #4
        public Part(string reference, string name)
        {
            this.reference = reference;
            this.name = name;
        }
        public void Use()
        {
            stock -= quantity;
            InternalApp.ExecuteQuery($"UPDATE parts_stock SET quantity={stock} WHERE reference='{reference}'");
        }      
        public void Order(int quantity)
        {
            string strQuantity; 
            DataTable temp_stock = InternalApp.GetDataTable($"SELECT * FROM parts_stock WHERE reference='{this.reference}'");
            DataRow partDataRow = temp_stock.Rows[0];
            strQuantity = partDataRow["quantity"].ToString();
            this.stock = Int32.Parse(strQuantity);
            this.stock += quantity;
            InternalApp.ExecuteQuery($"UPDATE parts_stock SET quantity={this.stock} WHERE reference='{reference}'");
            OrderToSupplier(quantity);

        }
        public void SaveNewPart(string name, string provider, string description)
        {
            this.name = name;
            string query = $"INSERT INTO `parts_catalog` (`reference`, `name`, `provider`, `description`) VALUES ('{this.reference}', '{this.name}', '{provider}', '{description}')";
            InternalApp.ExecuteQuery(query);
        }
        private void OrderToSupplier(int quantity)
        {
            Database db = new Database();
            MySqlConnection MyConn = new MySqlConnection(db.MyConnection);
            using (var command = new MySqlCommand("part_order", MyConn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                command.Parameters.AddWithValue("@id_part", this.reference);
                command.Parameters.AddWithValue("@quantity", quantity);
                MyConn.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                }
                MyConn.Close();
                
            }
        }
    }
}