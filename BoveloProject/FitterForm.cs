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
        List<ComboBox> stateBike = new List<ComboBox>();
        public FitterForm()
        {
            InitializeComponent();
        }

        private void FitterForm_Load(object sender, EventArgs e)
        {
            this.dateOfToday_label.Text = DateTime.Now.ToString("dddd, dd MMMM");
            ShowDayPlanning(fitterPanel);
        }
        private void FitterFormCharge()
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
                    ComboBox stateBox = new ComboBox();
                     
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

                    stateBox.Items.AddRange(InternalApp.bikeStateList);
                    stateBox.Top = position * 20 + 10;
                    stateBox.Left = 270;
                    stateBox.Name = Convert.ToString(bike.id);
                    stateBox.Size = new Size(121, 24);
                    stateBox.SelectedItem = bike.state;
                    
                    /*
                    checkBox.AutoSize = true;
                    checkBox.Text = "Start construction";
                    checkBox.UseVisualStyleBackColor = true;
                    checkBox.Top = position * 20 + 10;
                    checkBox.Name = Convert.ToString(bike.id);
                    checkBox.Left = 300;
                    checkBox.Visible = true;
                    checkBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateActive);
                    
                    checkBox2.AutoSize = true;
                    checkBox2.Text = "Done";
                    checkBox2.UseVisualStyleBackColor = true;
                    checkBox2.Top = position * 20 + 10;
                    checkBox2.Name = Convert.ToString(bike.id);
                    checkBox2.Left = 300;
                    checkBox2.Visible = true;
                    checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateDone);
                    */
                    position = position + 2;

                    day_panel.Controls.Add(bikeIDLbl);
                    day_panel.Controls.Add(bikeCategoryLbl);
                    day_panel.Controls.Add(bikeColorLbl);
                    day_panel.Controls.Add(bikeSizeLbl);
                    day_panel.Controls.Add(stateBox);
                    stateBike.Add(stateBox);
                }
            }

        }
        
        private void UpdateState(string state, int id)
        {
            foreach(Bike bike in InternalApp.bikeList)
            {
                if(bike.id == id)
                {
                    switch(state)
                    {
                        case "Active":
                            bike.ModifyState("Active");
                            break;
                        case "Done":
                            bike.Build();
                            break;
                        case "Not active":
                            bike.ModifyState("Not active");
                            break;
                        default:
                            break;
                    }

                }
            }   
        }
        
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validate_button_Click(object sender, EventArgs e)
        {
            foreach(ComboBox box in stateBike)
            {
                string state = box.SelectedItem.ToString();
                int id = Convert.ToInt32(box.Name);
                UpdateState(state,id);
            }
            InternalApp.bikeList.Clear();
            InternalApp.SetBikeList();
            stateBike.Clear();
            this.Controls.Clear();           
            InitializeComponent();
            FitterFormCharge();
            //ShowDayPlanning(fitterPanel);
        private void report_button_Click(object sender, EventArgs e)
        {
            BrokenPart form = new BrokenPart();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }
    }
}
