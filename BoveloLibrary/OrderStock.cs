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
            catch (Exception e)
            {
                Console.WriteLine(e);
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
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                MyConn.Close();
            }
        }
    }
}
