using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    public class Bovelo
    {
        public static Order order = new Order();
        public Bovelo()
        {
        }
        public void Run()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NewCatalogForm());
            */

            var b = Part.GetPart("brakes");
            Console.WriteLine(b.characteristic);

            var f = Part.GetPart("frame");
            Console.WriteLine(f.color);

        }
    }
}
