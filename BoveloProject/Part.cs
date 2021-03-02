using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;

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
        public string name;
        public string color;
        public int quantity;
        public string characteristic;

        private Part(string partName, string partColor, int partQuantity, string partCharacteristic) 
        {
            name = partName;
            color = partColor;
            quantity = partQuantity;
            characteristic = partCharacteristic;
        }

        public static void POST_REQUEST_MySQL(string DB_name, string DB_color, int DB_quantity, string DB_characteristic)
        {

        }

        private static Part BuildPart(string DB_name, MySqlDataReader dataReader)
        {
            //MySqlDataReader reader = GET_REQUEST_MySQLReader($"SELECT * FROM part WHERE name='{DB_name}'");
            
            Part p = new Part(
                dataReader.GetString(0),
                dataReader.GetString(1),
                dataReader.GetInt32(2),
                dataReader.GetString(3)
            );

            return p;
        }

        public static Part GetPart(string DB_name)
        {
            string connectionString = new Database().MyConnection;
            var connection = new MySqlConnection(connectionString);

            try
            {
                Console.WriteLine("Connecting to MySQL");
                connection.Open();

                var command = new MySqlCommand($"SELECT * FROM part WHERE name='{DB_name}'", connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                    continue;

                try
                {
                    Part p = BuildPart(DB_name, reader);
                    connection.Close();
                    return p;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    connection.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            connection.Close();
            Console.WriteLine("Connection closed");

            return null;
        }

        
    }
}