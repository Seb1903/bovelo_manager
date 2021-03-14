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
using System.Data;
using System.Globalization;

namespace Bovelo
{
    public partial class ManagerForm : Form
    {
        private List<Bike> bikelist = new List<Bike>();

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ShowDayPlanning(Panel day_panel, DateTime date)
        {
            int position = 1;
        
            List <Bike> bikeList = Planning.BikeListGenerator(date);
            int bikeCount = Planning.BikeByDay(date);
            for (int i = 0; i < bikeCount; i++)
            {
                Label bikeIDLbl = new Label();
                Label bikeCategoryLbl = new Label();
                Label bikeColorLbl = new Label();
                Label bikeSizeLbl = new Label();
                idDatePicker newDatePicker = new idDatePicker(bikeList[i].id);

                bikeIDLbl.Text = Convert.ToString(bikeList[i].id);
                bikeIDLbl.Top = position * 20 + 10;
                bikeIDLbl.Left = 10;
                bikeIDLbl.Size = new Size(30, 20);

                bikeCategoryLbl.Text = Convert.ToString(bikeList[i].type);
                bikeCategoryLbl.Top = position * 20 + 10;
                bikeCategoryLbl.Left = 60;
                bikeCategoryLbl.Size = new Size(60, 20);

                bikeColorLbl.Text = Convert.ToString(bikeList[i].color);
                bikeColorLbl.Top = position * 20 + 10;
                bikeColorLbl.Left = 150;
                bikeColorLbl.Size = new Size(60, 20);

                bikeSizeLbl.Text = Convert.ToString(bikeList[i].size);
                bikeSizeLbl.Top = position * 20 + 10;
                bikeSizeLbl.Left = 220;
                bikeSizeLbl.Size = new Size(30, 20);

                newDatePicker.Top = position * 20 + 7;
                newDatePicker.Left = 270;
                newDatePicker.Size = new Size(200, 20);
                newDatePicker.Value = date;
                newDatePicker.ValueChanged += newDatePicker_ValueChanged;

                


                position = position + 2;

                day_panel.Controls.Add(bikeIDLbl);
                day_panel.Controls.Add(bikeCategoryLbl);
                day_panel.Controls.Add(bikeColorLbl);
                day_panel.Controls.Add(bikeSizeLbl);
                day_panel.Controls.Add(newDatePicker);
            }
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            
            DateTime actualTime = DateTime.Now;
            UpdateFormDate(actualTime);
        }

        private void date_changed_calendar(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine(month_calendar.SelectionRange.Start.ToShortDateString()); // DD-MM-YY
            Console.WriteLine(month_calendar.SelectionRange.Start.Year);

            DateTime date_chosen = month_calendar.SelectionRange.Start.Date;
            UpdateFormDate(date_chosen);
        }
        private void UpdateFormDate(DateTime date)
        {
            DateTime startdate = date;
            int offset = dateOffset(startdate);
            startdate = startdate.AddDays(offset);
            Console.WriteLine(Convert.ToString(startdate));
            this.Controls.Clear();
            this.InitializeComponent();
            monday_label.Text = startdate.ToString("D", CultureInfo.CreateSpecificCulture("fr-FR"));
            tuesday_label.Text = startdate.AddDays(1).ToString("D", CultureInfo.CreateSpecificCulture("fr-FR"));
            wednesday_label.Text = startdate.AddDays(2).ToString("D", CultureInfo.CreateSpecificCulture("fr-FR"));
            thursday_label.Text = startdate.AddDays(3).ToString("D", CultureInfo.CreateSpecificCulture("fr-FR"));
            friday_label.Text = startdate.AddDays(4).ToString("D", CultureInfo.CreateSpecificCulture("fr-FR"));
            Controls.Add(monday_label);
            Controls.Add(tuesday_label);
            Controls.Add(wednesday_label);
            Controls.Add(thursday_label);
            Controls.Add(friday_label);
            ShowDayPlanning(day_panel1, startdate);
            ShowDayPlanning(day_panel2, startdate.AddDays(1));
            ShowDayPlanning(day_panel3, startdate.AddDays(2));
            ShowDayPlanning(day_panel4, startdate.AddDays(3));
            ShowDayPlanning(day_panel5, startdate.AddDays(4));
        }

        private int dateOffset(DateTime date)
        {
            int offset;
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Tuesday:
                    offset = (-1);
                    break;
                case DayOfWeek.Wednesday:
                    offset = (-2);
                    break;
                case DayOfWeek.Thursday:
                    offset = (-3);
                    break;
                case DayOfWeek.Friday:
                    offset = (-4);
                    break;
                case DayOfWeek.Saturday:
                    offset = (-5);
                    break;
                case DayOfWeek.Sunday:
                    offset = (-6);
                    break;
                default:
                    offset = (0);
                    break;
            }
            return offset;
        }
        private void newDatePicker_ValueChanged(object sender, EventArgs e)
        {
            string date = (sender as idDatePicker).Value.ToString("yyyy-MM-dd");
            int id = (sender as idDatePicker).id;
            Planning.ModifyDate(id, date);

        }

        private void AutoPlanner_Btn_Click(object sender, EventArgs e)
        {
            Planning.AutoPlanning(8);
            autoplanner_label.Text = "Planning done";
            autoplanner_label.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            
            ManagerForm form = new ManagerForm();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            this.Close();
            this.Show();
            
        }

        private void button_production_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stocks form = new Stocks();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
        }
    }
    public class idDatePicker : DateTimePicker
    {
        public int id;
        public idDatePicker(int id)
        {
            this.id = id;
        }
    }
}