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
        public static Dictionary<string, int> partsNecessaryStock = new Dictionary<string, int>(); // part ID - necessary stock
        public static List<string> partsNames = new List<string>();
        public static List<int> partsStock = new List<int>();
        public static List<string> partsSuppliersNames = new List<string>();
        public static Dictionary<string, int> partsQuantityOrder = new Dictionary<string, int>(); // part ID - stock ordered

        public static void GetPartCatalog()
        {
            string quantityQuery = $"SELECT * FROM parts_stock";//WHERE necessary != 0";
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
                    string partsIDs = quantityReader.Rows[i]["reference"].ToString();
                    int partStock = Convert.ToInt32(quantityReader.Rows[i]["quantity"].ToString());
                    partsStock.Add(partStock);
                    int partsNcryStock = Convert.ToInt32(quantityReader.Rows[i]["necessary"].ToString());
                    partsNecessaryStock.Add(partsIDs, partsNcryStock);

                    string partName = nameReader.Rows[i]["name"].ToString();
                    partsNames.Add(partName);

                    string supplierID = nameReader.Rows[i]["provider"].ToString();
                    
                    foreach(DataRow supplierRow in supplierReader.Rows)
                    {
                        if (supplierRow.Field<string>("id_supplier") == supplierID)
                        {
                            partsSuppliersNames.Add(supplierRow.Field<string>("id_supplier"));
                        }
                    }
                    
                    

                }
            }
            catch
            {
            }
        }
        public static int GetPartStock(string ID)
        {
            string quantityQuery = $"SELECT * FROM parts_stock WHERE reference='{ID}'";
            DataTable quantityReader = InternalApp.GetDataTable(quantityQuery);
            try
            {
                return Convert.ToInt32(quantityReader.Rows[0]["quantity"].ToString());
            }
            catch
            {
                return 0;
            }
        }
        public static void ChangeQuantity(string id, int quantity)
        {
            try
            {
                partsQuantityOrder.Add(id, quantity);
            }

            catch
            {
                partsQuantityOrder[id] = quantity;
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
        public static void SetNewNecessaryStock(string partID, int quantity)
        {
            string quantityQuery = $"SELECT * FROM parts_stock WHERE reference='{partID}'";
            DataTable quantityReader = InternalApp.GetDataTable(quantityQuery);
            int necessaryStock = Convert.ToInt32(quantityReader.Rows[0]["necessary"].ToString());
            if (quantity <= necessaryStock)
            {
                Database db = new Database();
                MySqlConnection MyConn = new MySqlConnection(db.MyConnection);
                using (var command = new MySqlCommand("UPDATE parts_stock SET necessary = necessary - @quantity WHERE reference = @id_part", MyConn)
                {
                    CommandType = CommandType.Text
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
