using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bovelo
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ShowDayPlanning()
        {
            Panel day_planning_panel = new Panel();

            int position = 1;
            //  foreach ()
            //  {
            for(int i = 0; i <= 20; i++)
            {
                Label bikeCategoryLbl = new Label();
                Label bikeColorLbl = new Label();
                Label bikeSizeLbl = new Label();
                DateTimePicker newDatePicker = new DateTimePicker();
                Button validateBtn = new Button();

                bikeCategoryLbl.Text = "category";
                bikeCategoryLbl.Top = position * 20 + 10;
                bikeCategoryLbl.Left = 10;
                bikeCategoryLbl.Size = new Size(60, 20);

                bikeColorLbl.Text = "color";
                bikeColorLbl.Top = position * 20 + 10;
                bikeColorLbl.Left = 80;
                bikeColorLbl.Size = new Size(60, 20);

                bikeSizeLbl.Text = "size";
                bikeSizeLbl.Top = position * 20 + 10;
                bikeSizeLbl.Left = 150;
                bikeSizeLbl.Size = new Size(30, 20);

                newDatePicker.Top = position * 20 + 7;
                newDatePicker.Left = 190;
                newDatePicker.Size = new Size(200, 20);

                validateBtn.Text = "Validate";
                validateBtn.Top = position * 20 + 4;
                validateBtn.Left = 400;
                validateBtn.Size = new Size(80, 23);

                position = position + 2;

                this.day_planning_panel.Controls.Add(bikeCategoryLbl);
                this.day_planning_panel.Controls.Add(bikeColorLbl);
                this.day_planning_panel.Controls.Add(bikeSizeLbl);
                this.day_planning_panel.Controls.Add(newDatePicker);
                this.day_planning_panel.Controls.Add(validateBtn);
            }
            // }
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            ShowDayPlanning();
        }

        private void date_changed_calendar(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine(month_calendar.SelectionRange.Start.ToShortDateString()); // DD-MM-YY
        }
    }
}