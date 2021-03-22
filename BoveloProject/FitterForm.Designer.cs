
namespace Bovelo
{
    partial class FitterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateOfToday_label = new System.Windows.Forms.Label();
            this.fitterPanel = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.validate_button = new System.Windows.Forms.Button();
            this.report_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Today :";
            // 
            // dateOfToday_label
            // 
            this.dateOfToday_label.AutoSize = true;
            this.dateOfToday_label.Location = new System.Drawing.Point(149, 31);
            this.dateOfToday_label.Name = "dateOfToday_label";
            this.dateOfToday_label.Size = new System.Drawing.Size(46, 17);
            this.dateOfToday_label.TabIndex = 2;
            this.dateOfToday_label.Text = "label2";
            // 
            // fitterPanel
            // 
            this.fitterPanel.AutoScroll = true;
            this.fitterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fitterPanel.Location = new System.Drawing.Point(77, 63);
            this.fitterPanel.Name = "fitterPanel";
            this.fitterPanel.Size = new System.Drawing.Size(640, 309);
            this.fitterPanel.TabIndex = 3;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(77, 405);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // validate_button
            // 
            this.validate_button.Location = new System.Drawing.Point(604, 405);
            this.validate_button.Name = "validate_button";
            this.validate_button.Size = new System.Drawing.Size(113, 23);
            this.validate_button.TabIndex = 5;
            this.validate_button.Text = "Validate";
            this.validate_button.UseVisualStyleBackColor = true;
            this.validate_button.Click += new System.EventHandler(this.validate_button_Click);
            // report_button
            // 
            this.report_button.Location = new System.Drawing.Point(546, 394);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(171, 34);
            this.report_button.TabIndex = 5;
            this.report_button.Text = "Report broken part";
            this.report_button.UseVisualStyleBackColor = true;
            this.report_button.Click += new System.EventHandler(this.report_button_Click);
            // 
            // FitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validate_button);
            this.Controls.Add(this.report_button);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.fitterPanel);
            this.Controls.Add(this.dateOfToday_label);
            this.Controls.Add(this.label1);
            this.Name = "FitterForm";
            this.Text = "FitterForm";
            this.Load += new System.EventHandler(this.FitterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateOfToday_label;
        private System.Windows.Forms.Panel fitterPanel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button validate_button;
        private System.Windows.Forms.Button report_button;
    }
}