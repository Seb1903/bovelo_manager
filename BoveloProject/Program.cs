using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //InternalApp internalApp = new InternalApp();
            //internalApp.Run();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NewModel());

            //Bovelo bovelo = new Bovelo(); 
            //bovelo.Run();

            //Bike explorer = new Bike(1);
            //Bike city = new Bike(4);
            //Bike adventure = new Bike(7);

            //adventure.Build();
            //Console.WriteLine(adventure); // all bikes are working
        }
    }
}
