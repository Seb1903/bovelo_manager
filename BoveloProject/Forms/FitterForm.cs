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

            var databaseConnection = new Database();
            var connection = new MySqlConnection(databaseConnection.MyConnection);
            DataTable tableMakers = new DataTable("tableEmployee");
            tableMakers.Columns.Add("id");
            tableMakers.Columns.Add("firstname");
            tableMakers.Columns.Add("lastname");
            tableMakers.Columns.Add("status");

            try
            {
                connection.Open();

                var command = new MySqlCommand("SELECT * FROM employee WHERE status='maker'", connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                    tableMakers.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
                reader.Close();
            }
            catch
            {
                throw;
            }
            connection.Close();

            foreach (Bike bike in InternalApp.bikeList)
            {

                if (bike.cstr_date.Date == date.Date)
                {
                    var idFieldLabel = new Label();
                    idFieldLabel.Text = "ID";
                    idFieldLabel.Location = new Point(10, 5);
                    idFieldLabel.AutoSize = true;
                    //idFieldLabel.BackColor = Color.Green;

                    var modelFieldLabel = new Label();
                    modelFieldLabel.Text = "MODEL";
                    modelFieldLabel.Location = new Point(60, 5);
                    modelFieldLabel.AutoSize = true;

                    var colorFieldLabel = new Label();
                    colorFieldLabel.Text = "COLOR";
                    colorFieldLabel.Location = new Point(150, 5);
                    colorFieldLabel.AutoSize = true;

                    var sizeFieldLabel = new Label();
                    sizeFieldLabel.Text = "SIZE";
                    sizeFieldLabel.Location = new Point(220, 5);
                    sizeFieldLabel.AutoSize = true;

                    var stateFieldLabel = new Label();
                    stateFieldLabel.Text = "STATE";
                    stateFieldLabel.Location = new Point(270, 5);
                    stateFieldLabel.AutoSize = true;
                    //stateFieldLabel.BackColor = Color.Green;

                    var makerFieldLabel = new Label();
                    makerFieldLabel.Text = "MAKER";
                    makerFieldLabel.Location = new Point(420, 5);
                    makerFieldLabel.AutoSize = true;
                    //makerFieldLabel.BackColor = Color.Blue;

                    /*---------------------------------------------------*/

                    var separatorLineLabel = new Label();
                    separatorLineLabel.BorderStyle = BorderStyle.Fixed3D;
                    separatorLineLabel.AutoSize = false;
                    separatorLineLabel.Text = "";
                    separatorLineLabel.Size = new Size(560, 2);
                    separatorLineLabel.Location = new Point(10, 20);

                    /*---------------------------------------------------*/

                    //Planning.ModifyState(bikeList[i].id,"active");
                    Label bikeIDLbl = new Label();
                    int stockage = bike.id;
                    bikeIDLbl.Text = Convert.ToString(bike.id);
                    bikeIDLbl.Top = position * 20 + 14;
                    bikeIDLbl.Left = 10;
                    bikeIDLbl.Size = new Size(30, 20);
                    //bikeIDLbl.BackColor = Color.Red;

                    Label bikeCategoryLbl = new Label();
                    bikeCategoryLbl.Text = bike.type;
                    bikeCategoryLbl.Top = position * 20 + 14;
                    bikeCategoryLbl.Left = 60;
                    bikeCategoryLbl.Size = new Size(60, 20);
                    //bikeCategoryLbl.BackColor = Color.Red;

                    Label bikeColorLbl = new Label();
                    bikeColorLbl.Text = bike.color;
                    bikeColorLbl.Top = position * 20 + 14;
                    bikeColorLbl.Left = 150;
                    bikeColorLbl.Size = new Size(60, 20);
                    
                    Label bikeSizeLbl = new Label();
                    bikeSizeLbl.Text = bike.size;
                    bikeSizeLbl.Top = position * 20 + 14;
                    bikeSizeLbl.Left = 220;
                    bikeSizeLbl.Size = new Size(30, 20);
                    
                    ComboBox stateBox = new ComboBox();
                    stateBox.Items.AddRange(InternalApp.bikeStateList);
                    stateBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    stateBox.Top = position * 20 + 10;
                    stateBox.Left = 270;
                    stateBox.Name = Convert.ToString(bike.id);
                    stateBox.Size = new Size(121, 24);
                    stateBox.SelectedItem = bike.state;




                    ComboBox makersComboBox = new ComboBox();
                    makersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    makersComboBox.Top = position * 20 + 10;
                    makersComboBox.Left = 420;
                    foreach (DataRow rowMaker in tableMakers.Rows)
                        makersComboBox.Items.Add($"{rowMaker["id"]}");


                    DataTable oneBike = Planning.GetDataTable($"SELECT * FROM planning WHERE bike={bikeIDLbl.Text}");
                    makersComboBox.SelectedItem = Convert.ToString(oneBike.Rows[0]["maker_id"]);

                    makersComboBox.SelectedIndexChanged += (s, e) =>
                    {
                        Console.Out.WriteLine(bikeIDLbl.Text);
                        Planning.UpdateMaker(Convert.ToInt32(bikeIDLbl.Text), Convert.ToInt32(makersComboBox.Text));
                    };

                    //try
                    //{
                    //    connection.Open();
                    //    var command = new MySqlCommand($"SELECT * FROM planning WHERE bike={bikeIDLbl}", connection);
                    //    var reader = command.ExecuteReader();
                    //    while (reader.Read())
                    //    {
                    //        Console.Out.WriteLine(reader[2]);
                    //        makersComboBox.SelectedText = "hello";
                    //    }
                    //    reader.Close();
                    //}
                    //catch (Exception)
                    //{

                    //}
                    //connection.Close();


                    //makersComboBox.SelectedValueChanged += (s, e) =>
                    //{
                    //    foreach (DataRow dataRow in tableMakers.Rows)
                    //    {

                    //        if ((string)dataRow["firstname"] == makersComboBox.Text.Split(' ')[0] && (string)dataRow["lastname"] == makersComboBox.Text.Split(' ')[1])
                    //        {
                    //            Console.Out.WriteLine($"{bikeIDLbl.Text} maker : {makersComboBox.Text}");
                    //            UpdateMaker($"UPDATE planning SET maker={dataRow["id"]} WHERE bike={bikeIDLbl}");
                    //        }
                    //    }
                    //    Console.Out.WriteLine(makersComboBox.Text.Split(' ')[0]);
                    //};
                    
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

                    day_panel.Controls.AddRange(new ComboBox[] { stateBox, makersComboBox });
                    
                    day_panel.Controls.AddRange(new Label[] {
                        bikeIDLbl,
                        bikeCategoryLbl,
                        bikeColorLbl,
                        bikeSizeLbl,
                        idFieldLabel,
                        modelFieldLabel,
                        colorFieldLabel,
                        sizeFieldLabel,
                        stateFieldLabel,
                        makerFieldLabel,
                        separatorLineLabel
                    });

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
            this.Hide();
            var chooseUser = new ChooseUser();
            chooseUser.ShowDialog();
            this.Close();
        }

        private void validate_button_Click(object sender, EventArgs e)
        {
            foreach (ComboBox box in stateBike)
            {
                string state = box.SelectedItem.ToString();
                int id = Convert.ToInt32(box.Name);
                UpdateState(state, id);
            }
            InternalApp.bikeList.Clear();
            InternalApp.SetBikeList();


            //this.Hide();
            //var fitterForm = new FitterForm();

            stateBike.Clear();
            this.Controls.Clear();
            InitializeComponent();
            FitterFormCharge();

            //fitterForm.ShowDialog();
            //this.Close();
            ShowDayPlanning(fitterPanel);
        }
        
        private void report_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var brokenPartsForm = new BrokenPart();
            brokenPartsForm.ShowDialog();
            this.Close();
        }

        public static DataTable DownloadEmployees()
        {
            var connection = new MySqlConnection(new Database().MyConnection);

            var tableEmployee = new DataTable("tableEmployee");
            tableEmployee.Columns.Add("id", typeof(int));
            tableEmployee.Columns.Add("firstname", typeof(string));
            tableEmployee.Columns.Add("lastname", typeof(string));
            tableEmployee.Columns.Add("status", typeof(int));

            try
            {
                connection.Open();

                var command = new MySqlCommand("SELECT * FROM employee", connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                    tableEmployee.Rows.Add(
                        reader[0], reader[1],
                        reader[2], reader[3]);

                foreach (DataRow dataRow in tableEmployee.Rows)
                {
                    Console.Out.WriteLine(String.Format("{0}, {1}, {2}, {3}",
                        dataRow["id"],
                        dataRow["firstname"],
                        dataRow["lastname"],
                        dataRow["status"]));
                }

                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return tableEmployee;
        }

        public static bool UpdateMaker(string request)
        {
            var connection = new MySqlConnection(new Database().MyConnection);

            try
            {
                connection.Open();

                var command = new MySqlCommand(request, connection);
                var reader = command.ExecuteReader();
                reader.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
