namespace Bovelo
{
    partial class Form2
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
            this.bike_list_label = new System.Windows.Forms.Label();
            this.validate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bike_list_label
            // 
            this.bike_list_label.AutoSize = true;
            this.bike_list_label.Location = new System.Drawing.Point(13, 13);
            this.bike_list_label.Name = "bike_list_label";
            this.bike_list_label.Size = new System.Drawing.Size(35, 13);
            this.bike_list_label.TabIndex = 0;
            this.bike_list_label.Text = "label1";
            this.bike_list_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // validate
            // 
            this.validate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validate.Location = new System.Drawing.Point(607, 370);
            this.validate.MaximumSize = new System.Drawing.Size(105, 23);
            this.validate.MinimumSize = new System.Drawing.Size(105, 23);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(105, 23);
            this.validate.TabIndex = 14;
            this.validate.Text = "Validate";
            this.validate.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 426);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.bike_list_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(762, 465);
            this.MinimumSize = new System.Drawing.Size(762, 465);
            this.Name = "Form2";
            this.Text = "Basket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bike_list_label;
        private System.Windows.Forms.Button validate;
    }
}