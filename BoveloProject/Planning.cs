using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    class Planning
    {
        public Planning()
        {

        }
        public void AddToPlanning(int capacity)
        {
            DateTime usedDate = DateTime.Now;
            while (VerifyDate() != 0)
            {
                try
                {
                    Database db = new Database();
                    MySqlConnection connection = new MySqlConnection(db.MyConnection);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("autoPlanner", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@capacity", MySqlDbType.Int32);
                    cmd.Parameters.Add("@currentDate", MySqlDbType.DateTime);
                    cmd.Parameters["@capacity"].Direction = System.Data.ParameterDirection.Input;
                    cmd.Parameters["@currentDate"].Direction = System.Data.ParameterDirection.Input;
                    cmd.Parameters["@capacity"].Value = Convert.ToInt32(capacity);
                    cmd.Parameters["@currentDate"].Value = Convert.ToDateTime(usedDate);
                    MySqlDataReader dataRead = cmd.ExecuteReader();
                    if (dataRead.Read())
                    {
                    }
                    connection.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                usedDate.AddDays(1);
            }
        }

        private int VerifyDate()
        {
            Database db = new Database();
            MySqlConnection connection = new MySqlConnection(db.MyConnection);
            string query = "SELECT COUNT(*) as numberOfUndated FROM manager WHERE date IS NOT NULL";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            int numberOfUndated;
            numberOfUndated = (int)reader["numberOfUndated"];
            connection.Close();
            return numberOfUndated;
        }
        public void ModifyDate(int id, DateTime date)
        {
            //peut etre un probleme niveau de la date
            Database db = new Database();
            MySqlConnection connection = new MySqlConnection(db.MyConnection);
            string query = $"UPDATE planning SET date={date} WHERE bike={id}";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            connection.Close();
        }

        public void ModifyState(int id, string state)
        {
            Database db = new Database();
            MySqlConnection connection = new MySqlConnection(db.MyConnection);
            string query = $"UPDATE bike SET cstr_status={state} WHERE id={id}";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            connection.Close();
        }

    }
}