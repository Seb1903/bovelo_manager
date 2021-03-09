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
            //  foreach ()
            //  {
            //
            List <Bike> bikeList = Planning.BikeListGenerator(date);
            int bikeCount = Planning.BikeByDay(date);
            //Console.WriteLine("serial num " + Convert.ToString(bikeList.Count));
            for (int i = 0; i < bikeCount; i++)
            {
                //Console.WriteLine("serial num "+Convert.ToString(bikeList[i].serial_number));
                Label bikeIDLbl = new Label();
                Label bikeCategoryLbl = new Label();
                Label bikeColorLbl = new Label();
                Label bikeSizeLbl = new Label();
                DateTimePicker newDatePicker = new DateTimePicker();
                Button validateBtn = new Button();

                bikeIDLbl.Text = Convert.ToString(bikeList[i].serial_number);
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
                newDatePicker.Value = date;

                position = position + 2;

                day_panel.Controls.Add(bikeIDLbl);
                day_panel.Controls.Add(bikeCategoryLbl);
                day_panel.Controls.Add(bikeColorLbl);
                day_panel.Controls.Add(bikeSizeLbl);
                day_panel.Controls.Add(newDatePicker);
            }
            // }
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            ShowDayPlanning(day_panel1,DateTime.Now);
            ShowDayPlanning(day_panel2,DateTime.Now.AddDays(1));
            ShowDayPlanning(day_panel3,DateTime.Now.AddDays(2));
            ShowDayPlanning(day_panel4,DateTime.Now.AddDays(3));
            ShowDayPlanning(day_panel5,DateTime.Now.AddDays(4));
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
            DateTime dateMonday;
            DateTime dateTuesday;
            DateTime dateWednesday;
            DateTime dateThursday;
            DateTime dateFriday;
            DateTime dateSaturday;
            DateTime dateSunday;

            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dateMonday = date.AddDays(0);
                    dateTuesday = date.AddDays(1);
                    dateWednesday = date.AddDays(2);
                    dateThursday = date.AddDays(3);
                    dateFriday = date.AddDays(4);
                    dateSaturday = date.AddDays(5);
                    dateSunday = date.AddDays(6);
                    break;
                case DayOfWeek.Tuesday:
                    dateMonday = date.AddDays(-1);
                    dateTuesday = date.AddDays(0);
                    dateWednesday = date.AddDays(1);
                    dateThursday = date.AddDays(2);
                    dateFriday = date.AddDays(3);
                    dateSaturday = date.AddDays(4);
                    dateSunday = date.AddDays(5);
                    break;
                case DayOfWeek.Wednesday:
                    dateMonday = date.AddDays(-2);
                    dateTuesday = date.AddDays(-1);
                    dateWednesday = date.AddDays(0);
                    dateThursday = date.AddDays(1);
                    dateFriday = date.AddDays(2);
                    dateSaturday = date.AddDays(3);
                    dateSunday = date.AddDays(4);
                    break;
                case DayOfWeek.Thursday:
                    dateMonday = date.AddDays(-3);
                    dateTuesday = date.AddDays(-2);
                    dateWednesday = date.AddDays(-1);
                    dateThursday = date.AddDays(0);
                    dateFriday = date.AddDays(1);
                    dateSaturday = date.AddDays(2);
                    dateSunday = date.AddDays(3);
                    break;
                case DayOfWeek.Friday:
                    dateMonday = date.AddDays(-4);
                    dateTuesday = date.AddDays(-3);
                    dateWednesday = date.AddDays(-2);
                    dateThursday = date.AddDays(-1);
                    dateFriday = date.AddDays(0);
                    dateSaturday = date.AddDays(1);
                    dateSunday = date.AddDays(2);
                    break;
                case DayOfWeek.Saturday:
                    dateMonday = date.AddDays(-5);
                    dateTuesday = date.AddDays(-4);
                    dateWednesday = date.AddDays(-3);
                    dateThursday = date.AddDays(-2);
                    dateFriday = date.AddDays(-1);
                    dateSaturday = date.AddDays(0);
                    dateSunday = date.AddDays(1);
                    break;
                case DayOfWeek.Sunday:
                    dateMonday = date.AddDays(-6);
                    dateTuesday = date.AddDays(-5);
                    dateWednesday = date.AddDays(-4);
                    dateThursday = date.AddDays(-3);
                    dateFriday = date.AddDays(-2);
                    dateSaturday = date.AddDays(-1);
                    dateSunday = date.AddDays(0);
                    break;
                default:
                    dateMonday = date.AddDays(0);
                    dateTuesday = date.AddDays(1);
                    dateWednesday = date.AddDays(2);
                    dateThursday = date.AddDays(3);
                    dateFriday = date.AddDays(4);
                    dateSaturday = date.AddDays(5);
                    dateSunday = date.AddDays(6);
                    break;
            }
            this.monday_label.Text = dateMonday.ToString("dddd, dd MMMM");
            this.tuesday_label.Text = dateTuesday.ToString("dddd, dd MMMM");
            this.wednesday_label.Text = dateWednesday.ToString("dddd, dd MMMM");
            this.thursday_label.Text = dateThursday.ToString("dddd, dd MMMM");
            this.friday_label.Text = dateFriday.ToString("dddd, dd MMMM");
        }
    }
}