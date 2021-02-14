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
    partial class AddClient
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
        public void InitializeComponent()
        {
            this.label_first_name = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.label_db_clients = new System.Windows.Forms.ListBox();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label_last_name = new System.Windows.Forms.Label();
            this.label_country = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_adress = new System.Windows.Forms.Label();
            this.label_zipcode = new System.Windows.Forms.Label();
            this.label_phonenumber = new System.Windows.Forms.Label();
            this.label_client_title = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.numericUpDown_zipcode = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_zipcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Location = new System.Drawing.Point(72, 75);
            this.label_first_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(55, 13);
            this.label_first_name.TabIndex = 0;
            this.label_first_name.Text = "First name";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(324, 250);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(96, 47);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save client";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_db_clients
            // 
            this.label_db_clients.FormattingEnabled = true;
            this.label_db_clients.Location = new System.Drawing.Point(324, 46);
            this.label_db_clients.Margin = new System.Windows.Forms.Padding(2);
            this.label_db_clients.Name = "label_db_clients";
            this.label_db_clients.Size = new System.Drawing.Size(175, 108);
            this.label_db_clients.TabIndex = 3;
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Location = new System.Drawing.Point(156, 75);
            this.textBox_firstname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(68, 20);
            this.textBox_firstname.TabIndex = 4;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Location = new System.Drawing.Point(156, 105);
            this.textBox_lastname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(68, 20);
            this.textBox_lastname.TabIndex = 5;
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(156, 134);
            this.textBox_country.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(68, 20);
            this.textBox_country.TabIndex = 6;
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(156, 160);
            this.textBox_city.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(68, 20);
            this.textBox_city.TabIndex = 7;
            // 
            // textBox_street
            // 
            this.textBox_street.Location = new System.Drawing.Point(156, 189);
            this.textBox_street.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(149, 20);
            this.textBox_street.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(156, 250);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(111, 20);
            this.textBox7.TabIndex = 10;
            // 
            // label_last_name
            // 
            this.label_last_name.AutoSize = true;
            this.label_last_name.Location = new System.Drawing.Point(72, 105);
            this.label_last_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(56, 13);
            this.label_last_name.TabIndex = 14;
            this.label_last_name.Text = "Last name";
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Location = new System.Drawing.Point(72, 134);
            this.label_country.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(43, 13);
            this.label_country.TabIndex = 15;
            this.label_country.Text = "Country";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(72, 163);
            this.label_city.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(24, 13);
            this.label_city.TabIndex = 16;
            this.label_city.Text = "City";
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(72, 192);
            this.label_adress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(59, 13);
            this.label_adress.TabIndex = 17;
            this.label_adress.Text = "Street + Nº";
            // 
            // label_zipcode
            // 
            this.label_zipcode.AutoSize = true;
            this.label_zipcode.Location = new System.Drawing.Point(72, 221);
            this.label_zipcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_zipcode.Name = "label_zipcode";
            this.label_zipcode.Size = new System.Drawing.Size(46, 13);
            this.label_zipcode.TabIndex = 18;
            this.label_zipcode.Text = "Zipcode";
            // 
            // label_phonenumber
            // 
            this.label_phonenumber.AutoSize = true;
            this.label_phonenumber.Location = new System.Drawing.Point(72, 253);
            this.label_phonenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_phonenumber.Name = "label_phonenumber";
            this.label_phonenumber.Size = new System.Drawing.Size(76, 13);
            this.label_phonenumber.TabIndex = 19;
            this.label_phonenumber.Text = "Phone number";
            // 
            // label_client_title
            // 
            this.label_client_title.AutoSize = true;
            this.label_client_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_client_title.Location = new System.Drawing.Point(69, 24);
            this.label_client_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_client_title.Name = "label_client_title";
            this.label_client_title.Size = new System.Drawing.Size(147, 31);
            this.label_client_title.TabIndex = 22;
            this.label_client_title.Text = "New client ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(324, 192);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 23;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(72, 278);
            this.label_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(35, 13);
            this.label_email.TabIndex = 24;
            this.label_email.Text = "E-mail";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(156, 278);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(111, 20);
            this.textBox_email.TabIndex = 25;
            // 
            // numericUpDown_zipcode
            // 
            this.numericUpDown_zipcode.Location = new System.Drawing.Point(156, 219);
            this.numericUpDown_zipcode.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_zipcode.Name = "numericUpDown_zipcode";
            this.numericUpDown_zipcode.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown_zipcode.TabIndex = 26;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 347);
            this.Controls.Add(this.numericUpDown_zipcode);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label_client_title);
            this.Controls.Add(this.label_phonenumber);
            this.Controls.Add(this.label_zipcode);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.label_country);
            this.Controls.Add(this.label_last_name);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox_street);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.textBox_country);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.label_db_clients);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_first_name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddClient";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_zipcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_first_name;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ListBox label_db_clients;
        private TextBox textBox_firstname;
        private TextBox textBox_lastname;
        private TextBox textBox_country;
        private TextBox textBox_city;
        private TextBox textBox_street;
        private TextBox textBox7;
        private Label label_last_name;
        private Label label_country;
        private Label label_city;
        private Label label_adress;
        private Label label_zipcode;
        private Label label_phonenumber;
        private Label label_client_title;
        private NumericUpDown numericUpDown1;
        private Label label_email;
        private TextBox textBox_email;
        private NumericUpDown numericUpDown_zipcode;
    }
}