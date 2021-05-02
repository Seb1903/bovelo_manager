
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitterForm));
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
            this.label1.Location = new System.Drawing.Point(169, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Today:";
            // 
            // dateOfToday_label
            // 
            this.dateOfToday_label.AutoSize = true;
            this.dateOfToday_label.Location = new System.Drawing.Point(359, 74);
            this.dateOfToday_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dateOfToday_label.Name = "dateOfToday_label";
            this.dateOfToday_label.Size = new System.Drawing.Size(102, 37);
            this.dateOfToday_label.TabIndex = 2;
            this.dateOfToday_label.Text = "label2";
            // 
            // fitterPanel
            // 
            this.fitterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fitterPanel.AutoScroll = true;
            this.fitterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fitterPanel.Location = new System.Drawing.Point(169, 148);
            this.fitterPanel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.fitterPanel.Name = "fitterPanel";
            this.fitterPanel.Size = new System.Drawing.Size(1856, 720);
            this.fitterPanel.TabIndex = 3;
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Location = new System.Drawing.Point(169, 905);
            this.Back.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(198, 67);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // validate_button
            // 
            this.validate_button.AutoSize = true;
            this.validate_button.Location = new System.Drawing.Point(1341, 905);
            this.validate_button.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.validate_button.Name = "validate_button";
            this.validate_button.Size = new System.Drawing.Size(260, 67);
            this.validate_button.TabIndex = 5;
            this.validate_button.Text = "Refresh";
            this.validate_button.UseVisualStyleBackColor = true;
            this.validate_button.Click += new System.EventHandler(this.validate_button_Click);
            // 
            // report_button
            // 
            this.report_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report_button.AutoSize = true;
            this.report_button.Location = new System.Drawing.Point(1649, 905);
            this.report_button.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(378, 67);
            this.report_button.TabIndex = 5;
            this.report_button.Text = "Report Part";
            this.report_button.UseVisualStyleBackColor = true;
            this.report_button.Click += new System.EventHandler(this.report_button_Click);
            // 
            // FitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2212, 1043);
            this.Controls.Add(this.validate_button);
            this.Controls.Add(this.report_button);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.fitterPanel);
            this.Controls.Add(this.dateOfToday_label);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximumSize = new System.Drawing.Size(2234, 1099);
            this.MinimumSize = new System.Drawing.Size(2234, 1099);
            this.Name = "FitterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fitter";
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