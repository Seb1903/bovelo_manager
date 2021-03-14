using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Bovelo
{
    public class Order
    {
        public List<BuyableItem> content;
        public int totalItems;
        public int orderNumber;
        public string date;
        public string deliveryDate;
        public Client client;
        public double totalPrice = 0;

        public Order()
        {
            this.date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"); // Formatted for SQL check for hours 
            this.deliveryDate = DateTime.Now.ToString("yyyy-MM-dd"); // TEMPORARY implementation, will be changed in next iterations
            this.content = new List<BuyableItem>();
        }
        public void Add(BuyableItem newItem)
        {
            bool itemAlreadyInBasket = false;
            foreach (BuyableItem item in content)
            {
                if (item.category == newItem.category && item.color == newItem.color && item.size == newItem.size)
                {
                    DialogResult result = MessageBox.Show("A bike with these features already exists. Do you still want to add it to basket?", "Cart Info", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        item.quantity += newItem.quantity;
                        Console.WriteLine("Quantity Updated Successfully!");
                    }
                    itemAlreadyInBasket = true;
                    break;
                }
            }
            if (!itemAlreadyInBasket)
            {
                content.Add(newItem);
                Console.WriteLine("Item Added successfully!");
            }

            UpdateTotalItems();
            UpdateDeliveryTime();
            UpdatePrice();
        }
        public void Remove(BuyableItem buyableItem)
        {
            content.Remove(buyableItem);
            Console.WriteLine("Item Removed");
            UpdateTotalItems();
            UpdateDeliveryTime();
            UpdatePrice();
        }
        public void Empty()
        {
            content.Clear();
            //Also delete selected client ? 
            UpdateDeliveryTime();
            UpdatePrice();
        }
        public void AddClient(Client client, int clientID)
        {
            this.client = client;
            this.client.clientID = clientID;
        }
        public void UpdatePrice()
        {
            this.totalPrice = 0; 
            foreach (BuyableItem item in content) //then we save each Item in the Bike table 
            {
                for (int i = 0; i < item.quantity; i++)
                {
                    this.totalPrice += item.price;
                }
            }
        }
        public void UpdateTotalItems()
        {
            this.totalItems = 0;
            foreach (BuyableItem buyableItem in this.content)
            {
                this.totalItems += buyableItem.quantity;
            }
        }
        public void UpdateDeliveryTime() // NOT READY YET
        {
            if (content.Count == 0)
            {
                this.deliveryDate = "";
            }
            else
            {
                UpdateTotalItems();
                string planningQuery = "SELECT * FROM planning"; // Acess planning to compute an estimate delivery time
                DataTable planningTable = GetDataTable(planningQuery);
                DataRow firstDateRow = planningTable.Rows[planningTable.Rows.Count - 1];
                DateTime firstDateAvailable = Convert.ToDateTime(firstDateRow["date"]);
                float speed = 9; // TEMPORARY speed fixed at 9 bikes per week
                float delay = (totalItems / speed) + 3; // Convert delay in days + add 3 days for the delivery
                DateTime newDeliveryDate = firstDateAvailable.AddDays(Math.Ceiling(delay));
                if (newDeliveryDate.DayOfWeek == DayOfWeek.Saturday) { newDeliveryDate = newDeliveryDate.AddDays(2); }
                if (newDeliveryDate.DayOfWeek == DayOfWeek.Sunday) { newDeliveryDate = newDeliveryDate.AddDays(1); }
                this.deliveryDate = newDeliveryDate.ToString("yyyy-MM-dd");
            }
        }
        public void Save()
        {
            if (content.Count >= 1 && client != null)
            {
                try //First we save the order in the order table. 
                {
                    Database db = new Database();
                    string Query = "insert into bovelo.order(client, date, deliveryDate, totalPrice)" +
                        "values('" + this.client.clientID + "','" + this.date + "','" + this.deliveryDate + "','" + this.totalPrice + "');";
                    MySqlConnection MyConn = new MySqlConnection(db.MyConnection);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    Console.WriteLine("Order Saved");
                    while (MyReader.Read())
                    {
                    }
                    MyConn.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                foreach (BuyableItem item in content) //then we save each Item in the Bike table 
                {
                    for (int i = 0; i < item.quantity; i++)
                    {
                        item.Save();
                        // once the item is saved, we save the mapping to the order thanks to a trigger in the bike table(AFTER INSERT)
                    }
                }
                this.Empty();
                this.client = null;
                MessageBox.Show("Order Confirmed!");
            }
            else
            {
                MessageBox.Show("Cart is empty or no client is selected");
            }
        }
        private static void ExecuteQuery(string query)
        {
            Database db = new Database();
            MySqlConnection connection = new MySqlConnection(db.MyConnection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read()) { }
            connection.Close();
        }
        private static DataTable GetDataTable(string sqlCommand)
        {
            Database db1 = new Database();
            MySqlConnection conn = new MySqlConnection(db1.MyConnection);
            MySqlCommand command = new MySqlCommand(sqlCommand, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            return table;
        }
    }
}