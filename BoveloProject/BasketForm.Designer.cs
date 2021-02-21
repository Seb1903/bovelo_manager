using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bovelo
{
    partial class BasketForm
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
            this.validate_btn = new System.Windows.Forms.Button();
            this.bike_list_label = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.empty_cart_btn = new System.Windows.Forms.Button();
            this.delivery_name = new System.Windows.Forms.Label();
            this.delivery_time_label = new System.Windows.Forms.Label();
            this.new_Client = new System.Windows.Forms.Button();
            this.select_Client = new System.Windows.Forms.Button();
            this.label_selectedClient = new System.Windows.Forms.Label();
            this.label_clientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validate_btn
            // 
            this.validate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validate_btn.Location = new System.Drawing.Point(910, 569);
            this.validate_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.validate_btn.MaximumSize = new System.Drawing.Size(158, 35);
            this.validate_btn.MinimumSize = new System.Drawing.Size(158, 35);
            this.validate_btn.Name = "validate_btn";
            this.validate_btn.Size = new System.Drawing.Size(158, 35);
            this.validate_btn.TabIndex = 14;
            this.validate_btn.Text = "Confirm";
            this.validate_btn.UseVisualStyleBackColor = true;
            this.validate_btn.Click += new System.EventHandler(this.validate_btn_Click);
            // 
            // bike_list_label
            // 
            this.bike_list_label.AutoSize = true;
            this.bike_list_label.Location = new System.Drawing.Point(20, 20);
            this.bike_list_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bike_list_label.Name = "bike_list_label";
            this.bike_list_label.Size = new System.Drawing.Size(0, 20);
            this.bike_list_label.TabIndex = 15;
            // 
            // back_btn
            // 
            this.back_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_btn.Location = new System.Drawing.Point(742, 569);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.MaximumSize = new System.Drawing.Size(158, 35);
            this.back_btn.MinimumSize = new System.Drawing.Size(158, 35);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(158, 35);
            this.back_btn.TabIndex = 16;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // empty_cart_btn
            // 
            this.empty_cart_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empty_cart_btn.Location = new System.Drawing.Point(14, 569);
            this.empty_cart_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.empty_cart_btn.MaximumSize = new System.Drawing.Size(158, 35);
            this.empty_cart_btn.MinimumSize = new System.Drawing.Size(158, 35);
            this.empty_cart_btn.Name = "empty_cart_btn";
            this.empty_cart_btn.Size = new System.Drawing.Size(158, 35);
            this.empty_cart_btn.TabIndex = 17;
            this.empty_cart_btn.Text = "Empty Cart";
            this.empty_cart_btn.UseVisualStyleBackColor = true;
            this.empty_cart_btn.Click += new System.EventHandler(this.empty_cart_btn_Click);
            // 
            // delivery_name
            // 
            this.delivery_name.AutoSize = true;
            this.delivery_name.Location = new System.Drawing.Point(14, 511);
            this.delivery_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delivery_name.Name = "delivery_name";
            this.delivery_name.Size = new System.Drawing.Size(179, 20);
            this.delivery_name.TabIndex = 18;
            this.delivery_name.Text = "Estimated delivery time :";
            // 
            // delivery_time_label
            // 
            this.delivery_time_label.AutoSize = true;
            this.delivery_time_label.Location = new System.Drawing.Point(204, 511);
            this.delivery_time_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delivery_time_label.Name = "delivery_time_label";
            this.delivery_time_label.Size = new System.Drawing.Size(0, 20);
            this.delivery_time_label.TabIndex = 19;
            // 
            // new_Client
            // 
            this.new_Client.Location = new System.Drawing.Point(742, 338);
            this.new_Client.Name = "new_Client";
            this.new_Client.Size = new System.Drawing.Size(158, 39);
            this.new_Client.TabIndex = 20;
            this.new_Client.Text = "New client";
            this.new_Client.UseVisualStyleBackColor = true;
            this.new_Client.Click += new System.EventHandler(this.new_Client_Click);
            // 
            // select_Client
            // 
            this.select_Client.Location = new System.Drawing.Point(910, 338);
            this.select_Client.Name = "select_Client";
            this.select_Client.Size = new System.Drawing.Size(158, 39);
            this.select_Client.TabIndex = 21;
            this.select_Client.Text = "Select client";
            this.select_Client.UseVisualStyleBackColor = true;
            this.select_Client.Click += new System.EventHandler(this.select_Client_Click);
            // 
            // label_selectedClient
            // 
            this.label_selectedClient.AutoSize = true;
            this.label_selectedClient.Location = new System.Drawing.Point(742, 397);
            this.label_selectedClient.Name = "label_selectedClient";
            this.label_selectedClient.Size = new System.Drawing.Size(125, 20);
            this.label_selectedClient.TabIndex = 22;
            this.label_selectedClient.Text = "Selected client : ";
            // 
            // label_clientName
            // 
            this.label_clientName.AutoSize = true;
            this.label_clientName.Location = new System.Drawing.Point(906, 397);
            this.label_clientName.Name = "label_clientName";
            this.label_clientName.Size = new System.Drawing.Size(51, 20);
            this.label_clientName.TabIndex = 23;
            if (Bovelo.order.client != null)
            {
                this.label_clientName.Text = Bovelo.order.client.lastname;
            }
            else { 
                this.label_clientName.Text = "";
            }

            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 620);
            this.Controls.Add(this.label_clientName);
            this.Controls.Add(this.label_selectedClient);
            this.Controls.Add(this.select_Client);
            this.Controls.Add(this.new_Client);
            this.Controls.Add(this.delivery_time_label);
            this.Controls.Add(this.delivery_name);
            this.Controls.Add(this.empty_cart_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.bike_list_label);
            this.Controls.Add(this.validate_btn);
            this.MaximumSize = new System.Drawing.Size(1129, 676);
            this.MinimumSize = new System.Drawing.Size(1129, 676);
            this.Name = "BasketForm";
            this.Text = "Basket";
            this.Load += new System.EventHandler(this.BasketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button validate_btn;
        private System.Windows.Forms.Label bike_list_label;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button empty_cart_btn;
        private System.Windows.Forms.Label delivery_name;
        private System.Windows.Forms.Label delivery_time_label;
        private System.Windows.Forms.Button new_Client;
        private System.Windows.Forms.Button select_Client;
        private System.Windows.Forms.Label label_selectedClient;
        private System.Windows.Forms.Label label_clientName;
    }
}