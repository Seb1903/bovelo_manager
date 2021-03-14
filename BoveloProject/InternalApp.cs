using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Bovelo
{
    public class InternalApp
    {
        public static string managerPassword = "1234";
        public InternalApp()
        {
        }
        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChooseUser());
        }
    }
}
