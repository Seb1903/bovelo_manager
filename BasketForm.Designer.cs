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
            this.SuspendLayout();
            // 
            // validate_btn
            // 
            this.validate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validate_btn.Location = new System.Drawing.Point(910, 569);
            this.validate_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.validate_btn.MaximumSize = new System.Drawing.Size(158, 35);
            this.validate_btn.MinimumSize = new System.Drawing.Size(158, 35);
            this.validate_btn.Name = "validate_btn";
            this.validate_btn.Size = new System.Drawing.Size(158, 35);
            this.validate_btn.TabIndex = 14;
            this.validate_btn.Text = "Confirm";
            this.validate_btn.UseVisualStyleBackColor = true;
            this.validate_btn.Click += new System.EventHandler(this.validate_Click);
            // 
            // bike_list_label
            // 
            this.bike_list_label.AutoSize = true;
            this.bike_list_label.Location = new System.Drawing.Point(19, 20);
            this.bike_list_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bike_list_label.Name = "bike_list_label";
            this.bike_list_label.Size = new System.Drawing.Size(0, 20);
            this.bike_list_label.TabIndex = 15;
            // 
            // back_btn
            // 
            this.back_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_btn.Location = new System.Drawing.Point(742, 569);
            this.back_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.empty_cart_btn.Margin = new System.Windows.Forms.Padding(5);
            this.empty_cart_btn.MaximumSize = new System.Drawing.Size(158, 35);
            this.empty_cart_btn.MinimumSize = new System.Drawing.Size(158, 35);
            this.empty_cart_btn.Name = "empty_cart_btn";
            this.empty_cart_btn.Size = new System.Drawing.Size(158, 35);
            this.empty_cart_btn.TabIndex = 17;
            this.empty_cart_btn.Text = "Empty Cart";
            this.empty_cart_btn.UseVisualStyleBackColor = true;
            this.empty_cart_btn.Click += new System.EventHandler(this.empty_cart_btn_Click);
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 629);
            this.Controls.Add(this.empty_cart_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.bike_list_label);
            this.Controls.Add(this.validate_btn);
            this.MaximumSize = new System.Drawing.Size(1132, 685);
            this.MinimumSize = new System.Drawing.Size(1132, 685);
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
    }
}