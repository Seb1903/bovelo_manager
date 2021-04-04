
namespace Bovelo
{
    partial class PartsStock1
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
            this.dataGridView_parts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_parts
            // 
            this.dataGridView_parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_parts.Location = new System.Drawing.Point(62, 145);
            this.dataGridView_parts.Name = "dataGridView_parts";
            this.dataGridView_parts.RowHeadersWidth = 82;
            this.dataGridView_parts.RowTemplate.Height = 33;
            this.dataGridView_parts.Size = new System.Drawing.Size(768, 624);
            this.dataGridView_parts.TabIndex = 0;
            // 
            // PartsStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 965);
            this.Controls.Add(this.dataGridView_parts);
            this.Name = "PartsStock";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_parts;
    }
}