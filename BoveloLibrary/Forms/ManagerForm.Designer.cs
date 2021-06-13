using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bovelo
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.month_calendar = new System.Windows.Forms.MonthCalendar();
            this.day_panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.day_panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.day_panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.day_panel5 = new System.Windows.Forms.Panel();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.monday_label = new System.Windows.Forms.Label();
            this.tuesday_label = new System.Windows.Forms.Label();
            this.wednesday_label = new System.Windows.Forms.Label();
            this.thursday_label = new System.Windows.Forms.Label();
            this.friday_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.day_panel1 = new System.Windows.Forms.Panel();
            this.AutoPlanner_Btn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.autoplanner_label = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.day_panel2.SuspendLayout();
            this.day_panel3.SuspendLayout();
            this.day_panel4.SuspendLayout();
            this.day_panel5.SuspendLayout();
            this.day_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // month_calendar
            // 
            this.month_calendar.AllowDrop = true;
            this.month_calendar.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.month_calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.month_calendar.Location = new System.Drawing.Point(13, 13);
            this.month_calendar.MaxSelectionCount = 1;
            this.month_calendar.Name = "month_calendar";
            this.month_calendar.ShowToday = false;
            this.month_calendar.ShowTodayCircle = false;
            this.month_calendar.TabIndex = 0;
            this.month_calendar.TabStop = false;
            this.month_calendar.TitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.month_calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.date_changed_calendar);
            // 
            // day_panel2
            // 
            this.day_panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day_panel2.AutoScroll = true;
            this.day_panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.day_panel2.Controls.Add(this.dateTimePicker2);
            this.day_panel2.Controls.Add(this.label4);
            this.day_panel2.Controls.Add(this.label5);
            this.day_panel2.Controls.Add(this.label6);
            this.day_panel2.Location = new System.Drawing.Point(302, 192);
            this.day_panel2.Name = "day_panel2";
            this.day_panel2.Size = new System.Drawing.Size(946, 144);
            this.day_panel2.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker2.Location = new System.Drawing.Point(230, 7);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "28\"";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dark blue";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adventure";
            this.label6.Visible = false;
            // 
            // day_panel3
            // 
            this.day_panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day_panel3.AutoScroll = true;
            this.day_panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.day_panel3.Controls.Add(this.dateTimePicker3);
            this.day_panel3.Controls.Add(this.label7);
            this.day_panel3.Controls.Add(this.label8);
            this.day_panel3.Controls.Add(this.label9);
            this.day_panel3.Location = new System.Drawing.Point(302, 355);
            this.day_panel3.Name = "day_panel3";
            this.day_panel3.Size = new System.Drawing.Size(946, 144);
            this.day_panel3.TabIndex = 3;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker3.Location = new System.Drawing.Point(230, 7);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 4;
            this.dateTimePicker3.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "28\"";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dark blue";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Adventure";
            this.label9.Visible = false;
            // 
            // day_panel4
            // 
            this.day_panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day_panel4.AutoScroll = true;
            this.day_panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.day_panel4.Controls.Add(this.dateTimePicker4);
            this.day_panel4.Controls.Add(this.label10);
            this.day_panel4.Controls.Add(this.label11);
            this.day_panel4.Controls.Add(this.label12);
            this.day_panel4.Location = new System.Drawing.Point(302, 518);
            this.day_panel4.Name = "day_panel4";
            this.day_panel4.Size = new System.Drawing.Size(946, 144);
            this.day_panel4.TabIndex = 4;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker4.Location = new System.Drawing.Point(230, 7);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker4.TabIndex = 4;
            this.dateTimePicker4.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "28\"";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Dark blue";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Adventure";
            this.label12.Visible = false;
            // 
            // day_panel5
            // 
            this.day_panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day_panel5.AutoScroll = true;
            this.day_panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.day_panel5.Controls.Add(this.dateTimePicker5);
            this.day_panel5.Controls.Add(this.label13);
            this.day_panel5.Controls.Add(this.label14);
            this.day_panel5.Controls.Add(this.label15);
            this.day_panel5.Location = new System.Drawing.Point(302, 681);
            this.day_panel5.Name = "day_panel5";
            this.day_panel5.Size = new System.Drawing.Size(946, 144);
            this.day_panel5.TabIndex = 5;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker5.Location = new System.Drawing.Point(230, 7);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker5.TabIndex = 4;
            this.dateTimePicker5.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "28\"";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(84, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Dark blue";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Adventure";
            this.label15.Visible = false;
            // 
            // monday_label
            // 
            this.monday_label.AutoSize = true;
            this.monday_label.Location = new System.Drawing.Point(306, 13);
            this.monday_label.Name = "monday_label";
            this.monday_label.Size = new System.Drawing.Size(0, 17);
            this.monday_label.TabIndex = 6;
            // 
            // tuesday_label
            // 
            this.tuesday_label.AutoSize = true;
            this.tuesday_label.Location = new System.Drawing.Point(306, 176);
            this.tuesday_label.Name = "tuesday_label";
            this.tuesday_label.Size = new System.Drawing.Size(0, 17);
            this.tuesday_label.TabIndex = 7;
            // 
            // wednesday_label
            // 
            this.wednesday_label.AutoSize = true;
            this.wednesday_label.Location = new System.Drawing.Point(306, 339);
            this.wednesday_label.Name = "wednesday_label";
            this.wednesday_label.Size = new System.Drawing.Size(0, 17);
            this.wednesday_label.TabIndex = 8;
            // 
            // thursday_label
            // 
            this.thursday_label.AutoSize = true;
            this.thursday_label.Location = new System.Drawing.Point(306, 502);
            this.thursday_label.Name = "thursday_label";
            this.thursday_label.Size = new System.Drawing.Size(0, 17);
            this.thursday_label.TabIndex = 7;
            // 
            // friday_label
            // 
            this.friday_label.AutoSize = true;
            this.friday_label.Location = new System.Drawing.Point(306, 665);
            this.friday_label.Name = "friday_label";
            this.friday_label.Size = new System.Drawing.Size(0, 17);
            this.friday_label.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adventure";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dark blue";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "28\"";
            this.label3.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 7);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2021, 3, 10, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // day_panel1
            // 
            this.day_panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day_panel1.AutoScroll = true;
            this.day_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.day_panel1.Controls.Add(this.dateTimePicker1);
            this.day_panel1.Controls.Add(this.label3);
            this.day_panel1.Controls.Add(this.label2);
            this.day_panel1.Controls.Add(this.label1);
            this.day_panel1.Location = new System.Drawing.Point(302, 29);
            this.day_panel1.Name = "day_panel1";
            this.day_panel1.Size = new System.Drawing.Size(946, 144);
            this.day_panel1.TabIndex = 1;
            // 
            // AutoPlanner_Btn
            // 
            this.AutoPlanner_Btn.Location = new System.Drawing.Point(19, 617);
            this.AutoPlanner_Btn.Name = "AutoPlanner_Btn";
            this.AutoPlanner_Btn.Size = new System.Drawing.Size(183, 36);
            this.AutoPlanner_Btn.TabIndex = 9;
            this.AutoPlanner_Btn.Text = "Auto Manage";
            this.AutoPlanner_Btn.UseVisualStyleBackColor = true;
            this.AutoPlanner_Btn.Click += new System.EventHandler(this.AutoPlanner_Btn_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(18, 772);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(183, 30);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // autoplanner_label
            // 
            this.autoplanner_label.AutoSize = true;
            this.autoplanner_label.Location = new System.Drawing.Point(15, 681);
            this.autoplanner_label.Name = "autoplanner_label";
            this.autoplanner_label.Size = new System.Drawing.Size(54, 17);
            this.autoplanner_label.TabIndex = 11;
            this.autoplanner_label.Text = "label16";
            this.autoplanner_label.Visible = false;
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(18, 733);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(183, 29);
            this.refresh_button.TabIndex = 12;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // ManagerForm
            // 
            this.ClientSize = new System.Drawing.Size(1260, 834);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.autoplanner_label);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AutoPlanner_Btn);
            this.Controls.Add(this.friday_label);
            this.Controls.Add(this.thursday_label);
            this.Controls.Add(this.wednesday_label);
            this.Controls.Add(this.tuesday_label);
            this.Controls.Add(this.monday_label);
            this.Controls.Add(this.day_panel5);
            this.Controls.Add(this.day_panel4);
            this.Controls.Add(this.day_panel3);
            this.Controls.Add(this.day_panel2);
            this.Controls.Add(this.day_panel1);
            this.Controls.Add(this.month_calendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planning";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.day_panel2.ResumeLayout(false);
            this.day_panel2.PerformLayout();
            this.day_panel3.ResumeLayout(false);
            this.day_panel3.PerformLayout();
            this.day_panel4.ResumeLayout(false);
            this.day_panel4.PerformLayout();
            this.day_panel5.ResumeLayout(false);
            this.day_panel5.PerformLayout();
            this.day_panel1.ResumeLayout(false);
            this.day_panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private MonthCalendar month_calendar;
        private Panel day_panel2;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel day_panel3;
        private DateTimePicker dateTimePicker3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel day_panel4;
        private DateTimePicker dateTimePicker4;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel day_panel5;
        private DateTimePicker dateTimePicker5;
        private Label label13;
        private Label label14;
        private Label label15;
        public Label monday_label;
        public Label tuesday_label;
        public Label wednesday_label;
        public Label thursday_label;
        public Label friday_label;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Panel day_panel1;
        private Button AutoPlanner_Btn;
        private Button Back;
        private Label autoplanner_label;
        private Button refresh_button;
    }
}