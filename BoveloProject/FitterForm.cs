using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    public partial class FitterForm : Form
    {
        public FitterForm()
        {
            InitializeComponent();
        }

        private void FitterForm_Load(object sender, EventArgs e)
        {
            this.dateOfToday_label.Text = DateTime.Now.ToString("dddd, dd MMMM");
            ScheduleDaily();
        }
        public void ScheduleDaily()
        {
            Database db1 = new Database();
            MySqlConnection conn = new MySqlConnection(db1.MyConnection);
            conn.Open();
            DateTime date = DateTime.Now;
            string sqlFormattedDate = date.ToString("yyyy-MM-dd");
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter($"SELECT type, color, size From manager WHERE date={sqlFormattedDate}",conn);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
        }
    }
}
