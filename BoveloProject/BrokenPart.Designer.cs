
namespace Bovelo
{
    partial class BrokenPart
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
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.validation_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectedPart_label = new System.Windows.Forms.Label();
            this.stock_dataGridView = new System.Windows.Forms.DataGridView();
            this.information_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stock_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(88, 51);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(128, 22);
            this.search_textbox.TabIndex = 1;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search part:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broken part :";
            // 
            // validation_button
            // 
            this.validation_button.Location = new System.Drawing.Point(456, 291);
            this.validation_button.Name = "validation_button";
            this.validation_button.Size = new System.Drawing.Size(75, 23);
            this.validation_button.TabIndex = 4;
            this.validation_button.Text = "Validate";
            this.validation_button.UseVisualStyleBackColor = true;
            this.validation_button.Click += new System.EventHandler(this.validation_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectedPart_label
            // 
            this.selectedPart_label.AutoSize = true;
            this.selectedPart_label.Location = new System.Drawing.Point(191, 291);
            this.selectedPart_label.Name = "selectedPart_label";
            this.selectedPart_label.Size = new System.Drawing.Size(46, 17);
            this.selectedPart_label.TabIndex = 6;
            this.selectedPart_label.Text = "label3";
            this.selectedPart_label.Visible = false;
            // 
            // stock_dataGridView
            // 
            this.stock_dataGridView.AllowUserToAddRows = false;
            this.stock_dataGridView.AllowUserToDeleteRows = false;
            this.stock_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_dataGridView.Location = new System.Drawing.Point(88, 100);
            this.stock_dataGridView.MultiSelect = false;
            this.stock_dataGridView.Name = "stock_dataGridView";
            this.stock_dataGridView.ReadOnly = true;
            this.stock_dataGridView.RowHeadersVisible = false;
            this.stock_dataGridView.RowHeadersWidth = 51;
            this.stock_dataGridView.RowTemplate.Height = 24;
            this.stock_dataGridView.RowTemplate.ReadOnly = true;
            this.stock_dataGridView.Size = new System.Drawing.Size(503, 167);
            this.stock_dataGridView.TabIndex = 7;
            this.stock_dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stock_dataGridView_CellMouseClick);
            // 
            // information_label
            // 
            this.information_label.AutoSize = true;
            this.information_label.Location = new System.Drawing.Point(453, 375);
            this.information_label.Name = "information_label";
            this.information_label.Size = new System.Drawing.Size(46, 17);
            this.information_label.TabIndex = 8;
            this.information_label.Text = "label4";
            this.information_label.Visible = false;
            // 
            // BrokenPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.information_label);
            this.Controls.Add(this.stock_dataGridView);
            this.Controls.Add(this.selectedPart_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.validation_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_textbox);
            this.Name = "BrokenPart";
            this.Text = "BrokenPart";
            ((System.ComponentModel.ISupportInitialize)(this.stock_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validation_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label selectedPart_label;
        private System.Windows.Forms.DataGridView stock_dataGridView;
        private System.Windows.Forms.Label information_label;
    }
}