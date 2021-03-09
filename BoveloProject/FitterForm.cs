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
            ShowDayPlanning(fitterPanel);
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
        private void ShowDayPlanning(Panel day_panel)
        {
            int position = 1;
            
            for (int i = 0; i <= 20; i++)
            {
                Label bikeIDLbl = new Label();
                Label bikeCategoryLbl = new Label();
                Label bikeColorLbl = new Label();
                Label bikeSizeLbl = new Label();
                DateTimePicker newDatePicker = new DateTimePicker();
                Button validateBtn = new Button();

                bikeIDLbl.Text = "ID";
                bikeIDLbl.Top = position * 20 + 10;
                bikeIDLbl.Left = 10;
                bikeIDLbl.Size = new Size(30, 20);

                bikeCategoryLbl.Text = "category";
                bikeCategoryLbl.Top = position * 20 + 10;
                bikeCategoryLbl.Left = 60;
                bikeCategoryLbl.Size = new Size(60, 20);

                bikeColorLbl.Text = "color";
                bikeColorLbl.Top = position * 20 + 10;
                bikeColorLbl.Left = 150;
                bikeColorLbl.Size = new Size(60, 20);

                bikeSizeLbl.Text = "size";
                bikeSizeLbl.Top = position * 20 + 10;
                bikeSizeLbl.Left = 220;
                bikeSizeLbl.Size = new Size(30, 20);

                newDatePicker.Top = position * 20 + 7;
                newDatePicker.Left = 270;
                newDatePicker.Size = new Size(200, 20);

                validateBtn.Text = "Validate";
                validateBtn.Top = position * 20 + 4;
                validateBtn.Left = 490;
                validateBtn.Size = new Size(80, 23);

                position = position + 2;

                day_panel.Controls.Add(bikeIDLbl);
                day_panel.Controls.Add(bikeCategoryLbl);
                day_panel.Controls.Add(bikeColorLbl);
                day_panel.Controls.Add(bikeSizeLbl);
                day_panel.Controls.Add(newDatePicker);
                day_panel.Controls.Add(validateBtn);
            }
        }
    }
}
