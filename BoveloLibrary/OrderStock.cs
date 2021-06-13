using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bovelo
{
    class OrderStock
    {
        public static List<Part> partList = new List<Part>();

        public static void GetPartCatalog()
        {
            string quantityQuery = $"SELECT * FROM parts_stock";
            string nameQuery = $"SELECT * FROM parts_catalog";
            string supplierQuery = $"SELECT * FROM supplier";
            DataTable quantityReader = InternalApp.GetDataTable(quantityQuery);
            DataTable nameReader = InternalApp.GetDataTable(nameQuery);
            DataTable supplierReader = InternalApp.GetDataTable(supplierQuery);
            int size_datatable = quantityReader.Rows.Count;
            try
            {
                for (int i = 0; i < size_datatable; i++)
                {
                    string partID = quantityReader.Rows[i]["reference"].ToString();
                    int partStock = Convert.ToInt32(quantityReader.Rows[i]["quantity"].ToString());
                    int partOrdered = Convert.ToInt32(quantityReader.Rows[i]["ordered"].ToString());
                    int partsNcryStock = Convert.ToInt32(quantityReader.Rows[i]["necessary"].ToString());
                    string partName = nameReader.Rows[i]["name"].ToString();

                    int partTotalStock = partStock + partOrdered;

                    partList.Add(new Part(partID, partName, partTotalStock, partsNcryStock));
                }
            }
            catch
            {
            }
        }

        public static void ChangeQuantity(string id, int quantity)
        {
            foreach (Part part in partList)
            {
                if(part.reference == id)
                {
                    part.ChangeQuantity(quantity);
                }
            }
        }
        public static void OrderToSupplier(string partID, int quantity)
        {
            Database db = new Database();
            MySqlConnection MyConn = new MySqlConnection(db.MyConnection);
            using (var command = new MySqlCommand("part_order", MyConn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                command.Parameters.AddWithValue("@id_part", partID);
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
        public static void SetNewNecessaryStock(string partID, int quantity, int stock)
        {
            string quantityQuery = $"SELECT * FROM parts_stock WHERE reference='{partID}'";
            DataTable quantityReader = InternalApp.GetDataTable(quantityQuery);
            int necessaryStock = Convert.ToInt32(quantityReader.Rows[0]["necessary"].ToString());
            if (quantity <= necessaryStock)
            {
                Database db = new Database();
                MySqlConnection MyConn = new MySqlConnection(db.MyConnection);
                using (var command = new MySqlCommand("UPDATE parts_stock SET necessary = necessary - @quantity - @stock WHERE reference = @id_part", MyConn)
                {
                    CommandType = CommandType.Text
                })
                {
                    command.Parameters.AddWithValue("@id_part", partID);
                    command.Parameters.AddWithValue("@stock", stock);
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
            else if(quantity > necessaryStock)
            {
                Database db = new Database();
                MySqlConnection MyConn = new MySqlConnection(db.MyConnection);
                using (var command = new MySqlCommand("UPDATE parts_stock SET necessary = 0 WHERE reference = @id_part", MyConn)
                {
                    CommandType = CommandType.Text
                })
                {
                    command.Parameters.AddWithValue("@id_part", partID);
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
            else
            {
                Database db = new Database();
                MySqlConnection MyConn = new MySqlConnection(db.MyConnection);
                using (var command = new MySqlCommand("UPDATE parts_stock SET necessary = @necessary WHERE reference = @id_part", MyConn)
                {
                    CommandType = CommandType.Text
                })
                {
                    command.Parameters.AddWithValue("@id_part", partID);
                    command.Parameters.AddWithValue("@necessary", necessaryStock);
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
}
