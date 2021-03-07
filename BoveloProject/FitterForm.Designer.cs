
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
            this.dataGridViewFitter = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateOfToday_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFitter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFitter
            // 
            this.dataGridViewFitter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFitter.Location = new System.Drawing.Point(77, 74);
            this.dataGridViewFitter.Name = "dataGridViewFitter";
            this.dataGridViewFitter.RowHeadersWidth = 51;
            this.dataGridViewFitter.RowTemplate.Height = 24;
            this.dataGridViewFitter.Size = new System.Drawing.Size(631, 364);
            this.dataGridViewFitter.TabIndex = 0;
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
            // FitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateOfToday_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFitter);
            this.Name = "FitterForm";
            this.Text = "FitterForm";
            this.Load += new System.EventHandler(this.FitterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateOfToday_label;
    }
}