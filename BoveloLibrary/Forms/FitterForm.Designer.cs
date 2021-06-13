
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
            this.report_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Today:";
            // 
            // dateOfToday_label
            // 
            this.dateOfToday_label.AutoSize = true;
            this.dateOfToday_label.Location = new System.Drawing.Point(170, 40);
            this.dateOfToday_label.Name = "dateOfToday_label";
            this.dateOfToday_label.Size = new System.Drawing.Size(51, 20);
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
            this.fitterPanel.Location = new System.Drawing.Point(80, 80);
            this.fitterPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fitterPanel.Name = "fitterPanel";
            this.fitterPanel.Size = new System.Drawing.Size(858, 390);
            this.fitterPanel.TabIndex = 3;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(80, 489);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(93, 36);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // report_button
            // 
            this.report_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report_button.Location = new System.Drawing.Point(793, 489);
            this.report_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(145, 36);
            this.report_button.TabIndex = 5;
            this.report_button.Text = "Report Part";
            this.report_button.UseVisualStyleBackColor = true;
            this.report_button.Click += new System.EventHandler(this.report_button_Click);
            // 
            // FitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 558);
            this.Controls.Add(this.report_button);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.fitterPanel);
            this.Controls.Add(this.dateOfToday_label);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1067, 614);
            this.MinimumSize = new System.Drawing.Size(918, 575);
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
        private System.Windows.Forms.Button report_button;
    }
}