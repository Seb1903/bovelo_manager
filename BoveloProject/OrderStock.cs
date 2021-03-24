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
        public static List<string> partsNames = new List<string>();
        public static List<string> partsIDs = new List<string>();
        public static List<int> partsSuppliersID = new List<int>();
        public static List<string> partsSuppliersNames = new List<string>();
        public static Dictionary<string, int> partsQuantityOrder = new Dictionary<string, int>();

        public static void GetPartCatalog()
        {
            string quantityQuery = $"SELECT * FROM parts_catalog";
            DataTable quantityReader = InternalApp.GetDataTable(quantityQuery);
            int size_datatable = quantityReader.Rows.Count;
            for (int i = 0; i < size_datatable; i++)
            {
                partsNames.Add(quantityReader.Rows[i]["name"].ToString());
                partsIDs.Add(quantityReader.Rows[i]["reference"].ToString());
                int supplierID = Convert.ToInt32(quantityReader.Rows[i]["provider"].ToString());
                partsSuppliersID.Add(supplierID);
            }
            
            foreach (int supplierID in partsSuppliersID)
            {
                string qtyQuery = $"SELECT * FROM supplier WHERE id_supplier='{supplierID}'";
                DataTable qtyReader = InternalApp.GetDataTable(qtyQuery);
                int size_table = qtyReader.Rows.Count;
                if (size_table <= 0)
                {
                    partsSuppliersNames.Add("No supplier");
                }
                else
                {
                    partsSuppliersNames.Add(qtyReader.Rows[0]["supplier_name"].ToString());
                }
            }
        }
        public static int GetPartStock(string ID)
        {
            string quantityQuery = $"SELECT * FROM parts_stock WHERE reference='{ID}'";
            DataTable quantityReader = InternalApp.GetDataTable(quantityQuery);
            int size_datatable = quantityReader.Rows.Count;
            if (size_datatable <= 0)
            {
                return 10;
            }
            else
            {
                return Convert.ToInt32(quantityReader.Rows[0]["quantity"].ToString());
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
                command.Parameters.AddWithValue("@id_part", Convert.ToInt32(partID));
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
