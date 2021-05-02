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
            {CommandType = CommandType.StoredProcedure})
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
                }
            }
        }      
        public static DataTable GetDataTable(string sqlCommand)
        {
            var connection = new MySqlConnection(new Database().MyConnection);
            DataTable planning = new DataTable("table");
            planning.Columns.Add("date");
            planning.Columns.Add("bike");
            planning.Columns.Add("maker_id");
            try
            {
                connection.Open();
                var command = new MySqlCommand(sqlCommand, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    planning.Rows.Add(reader[0], reader[1], reader[2]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return planning;
        }        
        public static bool UpdateMaker(int idBike, int idMaker)
        {
            var connection = new MySqlConnection(new Database().MyConnection);
            try
            {
                connection.Open();
                var command = new MySqlCommand($"UPDATE planning SET maker_id={idMaker} WHERE bike={idBike}", connection);
                command.ExecuteReader();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}