using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bovelo
{
    class Planning
    {
        public Planning()
        {

        }
        public static void AddToPlanning(int capacity,DateTime usedDate)
        {
            Database db = new Database();
            MySqlConnection MyConn = new MySqlConnection(db.MyConnection);
            using (var command = new MySqlCommand("autoPlanner", MyConn)
            {
                CommandType = CommandType.StoredProcedure

             })
             {
                command.Parameters.AddWithValue("@capacity", capacity);
                command.Parameters.Add("@prodDate", MySqlDbType.DateTime);
                command.Parameters["@prodDate"].Value = usedDate;
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

        public static void AutoPlanning(int capacity)
        {
            DateTime usedDate = DateTime.Now;
            if (usedDate.DayOfWeek == DayOfWeek.Saturday)
            {
                usedDate = usedDate.AddDays(2);
            }
            else if (usedDate.DayOfWeek == DayOfWeek.Sunday)
            {
                usedDate = usedDate.AddDays(1);
            }
            else
            {
            }
            while (VerifyDate() != 0)   //use if instead of while ??
            {
                AddToPlanning(capacity, usedDate);
                if (usedDate.DayOfWeek == DayOfWeek.Friday)
                {
                    usedDate = usedDate.AddDays(3);
                }
                else
                {
                    usedDate = usedDate.AddDays(1);
                }
            }
            Console.WriteLine("Auto planning done ! Please wait a moment");
        }
        public static int VerifyDate()
        {
            Database db = new Database();
            using (var conn = new MySqlConnection(db.MyConnection))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM manager WHERE date IS NULL", conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    return count;
                    
                    
                }
            }
        }
         /* public static void ModifyDate(int id, String date)
        {
            Database db = new Database();
            MySqlConnection connection = new MySqlConnection(db.MyConnection);
            string query = $"UPDATE planning SET date='{date}' WHERE bike='{id}'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            connection.Close();
        }    //Method is in Bike class now 

        public static void ModifyState(int id, string state)
        {
            Database db = new Database();
            MySqlConnection connection = new MySqlConnection(db.MyConnection);
            string query = $"UPDATE bike SET cstr_status='{state}' WHERE id='{id}'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            connection.Close();
        } */
        public static int BikeByDay(DateTime date)
        {
            Database db = new Database();
            string sqlDate = date.ToString("yyyy-MM-dd");
            using (var conn = new MySqlConnection(db.MyConnection))
            {
                conn.Open();
                using (var cmd = new MySqlCommand($"SELECT COUNT(*) FROM manager WHERE date='{sqlDate}'", conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());    
                    return count;
                    Console.WriteLine(count);
                    conn.Close();
                }
            }

        }
        /*public static List<Bike> BikeListGenerator() // deleted parameter so we only call once this function 
        {
            //string sqlDate = date.ToString("yyyy-MM-dd");
            string bikeIDQuery = $"SELECT P.bike FROM planning P, bike B WHERE P.bike = B.id AND B.cstr_status != 'Done'";
            DataTable bikeIDReader = GetDataTable(bikeIDQuery);
            List<Bike> bikeList = new List<Bike>();
            for (int i = 0; i < bikeIDReader.Rows.Count; i++)
            {
                Console.WriteLine("test");
                int id = Convert.ToInt32(bikeIDReader.Rows[i]["bike"]);
                Bike bike = new Bike(id);
                bikeList.Add(bike);
            }
            return bikeList;
        }*/
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