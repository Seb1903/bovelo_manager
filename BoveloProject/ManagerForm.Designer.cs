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
            this.month_calendar = new System.Windows.Forms.MonthCalendar();
            this.day_planning_panel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.day_planning_panel.SuspendLayout();
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
            // day_planning_panel
            // 
            this.day_planning_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day_planning_panel.AutoScroll = true;
            this.day_planning_panel.Controls.Add(this.dateTimePicker1);
            this.day_planning_panel.Controls.Add(this.button1);
            this.day_planning_panel.Controls.Add(this.label3);
            this.day_planning_panel.Controls.Add(this.label2);
            this.day_planning_panel.Controls.Add(this.label1);
            this.day_planning_panel.Location = new System.Drawing.Point(184, 13);
            this.day_planning_panel.Name = "day_planning_panel";
            this.day_planning_panel.Size = new System.Drawing.Size(611, 535);
            this.day_planning_panel.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "28\"";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dark blue";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adventure";
            this.label1.Visible = false;
            // 
            // ManagerForm
            // 
            this.ClientSize = new System.Drawing.Size(875, 586);
            this.Controls.Add(this.day_planning_panel);
            this.Controls.Add(this.month_calendar);
            this.Name = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.day_planning_panel.ResumeLayout(false);
            this.day_planning_panel.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private MonthCalendar month_calendar;
        private Panel day_planning_panel;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}