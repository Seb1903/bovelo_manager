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
        }
        private void ShowDayPlanning(Panel day_panel)
        {
            int position = 1;
            DateTime date = DateTime.Now;
            int count = Planning.BikeByDay(date);
            //List<Bike> bikeList = Planning.BikeListGenerator();
            foreach (Bike bike in InternalApp.bikeList)
            {

                if (bike.cstr_date.Date == date.Date)
                {
                    //Planning.ModifyState(bikeList[i].id,"active");
                    Label bikeIDLbl = new Label();
                    Label bikeCategoryLbl = new Label();
                    Label bikeColorLbl = new Label();
                    Label bikeSizeLbl = new Label();
                    CheckBox checkBox = new CheckBox();
                    CheckBox checkBox2 = new CheckBox();

                    int stockage = bike.id;
                    bikeIDLbl.Text = Convert.ToString(bike.id);
                    bikeIDLbl.Top = position * 20 + 10;
                    bikeIDLbl.Left = 10;
                    bikeIDLbl.Size = new Size(30, 20);

                    bikeCategoryLbl.Text = bike.type;
                    bikeCategoryLbl.Top = position * 20 + 10;
                    bikeCategoryLbl.Left = 60;
                    bikeCategoryLbl.Size = new Size(60, 20);

                    bikeColorLbl.Text = bike.color;
                    bikeColorLbl.Top = position * 20 + 10;
                    bikeColorLbl.Left = 150;
                    bikeColorLbl.Size = new Size(60, 20);

                    bikeSizeLbl.Text = bike.size;
                    bikeSizeLbl.Top = position * 20 + 10;
                    bikeSizeLbl.Left = 220;
                    bikeSizeLbl.Size = new Size(30, 20);

                    checkBox.AutoSize = true;
                    checkBox.Text = "Start construction";
                    checkBox.UseVisualStyleBackColor = true;
                    checkBox.Top = position * 20 + 10;
                    checkBox.Name = Convert.ToString(bike.id);
                    checkBox.Left = 300;
                    checkBox.Visible = true;
                    checkBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateActive);
                    //
                    checkBox2.AutoSize = true;
                    checkBox2.Text = "Done";
                    checkBox2.UseVisualStyleBackColor = true;
                    checkBox2.Top = position * 20 + 10;
                    checkBox2.Name = Convert.ToString(bike.id);
                    checkBox2.Left = 300;
                    checkBox2.Visible = true;
                    checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateDone);

                    position = position + 2;

                    day_panel.Controls.Add(bikeIDLbl);
                    day_panel.Controls.Add(bikeCategoryLbl);
                    day_panel.Controls.Add(bikeColorLbl);
                    day_panel.Controls.Add(bikeSizeLbl);
                    day_panel.Controls.Add(checkBox);
                    day_panel.Controls.Add(checkBox2);
                }
            }

        }
        
        private void checkBox_CheckStateDone(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            int id = Convert.ToInt32(check.Name);
             foreach(Bike bike in InternalApp.bikeList)
            {
                if(bike.id == id)
                {
                    bike.Build();
                }
            }

            fitterPanel.Controls.Remove(check);       
        }
        private void checkBox_CheckStateActive(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            int id = Convert.ToInt32(check.Name);
            foreach (Bike bike in InternalApp.bikeList)
            {
                if (bike.id == id)
                {
                    bike.ModifyState("Active");
                }
            }
            fitterPanel.Controls.Remove(check);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
