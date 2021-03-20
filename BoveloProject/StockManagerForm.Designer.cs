
namespace Bovelo
{
    partial class StockManagerForm
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
            this.part_stock_panel = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.order_button = new System.Windows.Forms.Button();
            this.partIDLbl = new System.Windows.Forms.Label();
            this.quantity_title = new System.Windows.Forms.Label();
            this.necessary_stock_title = new System.Windows.Forms.Label();
            this.current_stock_title = new System.Windows.Forms.Label();
            this.part_name_title = new System.Windows.Forms.Label();
            this.partID_title = new System.Windows.Forms.Label();
            this.part_stock_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // part_stock_panel
            // 
            this.part_stock_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.part_stock_panel.AutoScroll = true;
            this.part_stock_panel.Controls.Add(this.partIDLbl);
            this.part_stock_panel.Controls.Add(this.numericUpDown1);
            this.part_stock_panel.Location = new System.Drawing.Point(12, 37);
            this.part_stock_panel.Name = "part_stock_panel";
            this.part_stock_panel.Size = new System.Drawing.Size(795, 653);
            this.part_stock_panel.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(615, 35);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.Visible = false;
            // 
            // order_button
            // 
            this.order_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_button.Location = new System.Drawing.Point(671, 713);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(136, 32);
            this.order_button.TabIndex = 1;
            this.order_button.Text = "Order to supplier";
            this.order_button.UseVisualStyleBackColor = true;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // partIDLbl
            // 
            this.partIDLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partIDLbl.Location = new System.Drawing.Point(7, 41);
            this.partIDLbl.Name = "partIDLbl";
            this.partIDLbl.Size = new System.Drawing.Size(100, 23);
            this.partIDLbl.TabIndex = 6;
            this.partIDLbl.Text = "label1";
            this.partIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.partIDLbl.Visible = false;
            // 
            // quantity_title
            // 
            this.quantity_title.AutoSize = true;
            this.quantity_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_title.Location = new System.Drawing.Point(575, 9);
            this.quantity_title.Name = "quantity_title";
            this.quantity_title.Size = new System.Drawing.Size(180, 16);
            this.quantity_title.TabIndex = 10;
            this.quantity_title.Text = "Quantity of stock to order";
            // 
            // necessary_stock_title
            // 
            this.necessary_stock_title.AutoSize = true;
            this.necessary_stock_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.necessary_stock_title.Location = new System.Drawing.Point(341, 9);
            this.necessary_stock_title.Name = "necessary_stock_title";
            this.necessary_stock_title.Size = new System.Drawing.Size(198, 16);
            this.necessary_stock_title.TabIndex = 9;
            this.necessary_stock_title.Text = "Estimated  necessary stock";
            // 
            // current_stock_title
            // 
            this.current_stock_title.AutoSize = true;
            this.current_stock_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_stock_title.Location = new System.Drawing.Point(207, 9);
            this.current_stock_title.Name = "current_stock_title";
            this.current_stock_title.Size = new System.Drawing.Size(98, 16);
            this.current_stock_title.TabIndex = 8;
            this.current_stock_title.Text = "Current stock";
            // 
            // part_name_title
            // 
            this.part_name_title.AutoSize = true;
            this.part_name_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part_name_title.Location = new System.Drawing.Point(98, 9);
            this.part_name_title.Name = "part_name_title";
            this.part_name_title.Size = new System.Drawing.Size(78, 16);
            this.part_name_title.TabIndex = 7;
            this.part_name_title.Text = "Part name";
            // 
            // partID_title
            // 
            this.partID_title.AutoSize = true;
            this.partID_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partID_title.Location = new System.Drawing.Point(21, 9);
            this.partID_title.Name = "partID_title";
            this.partID_title.Size = new System.Drawing.Size(55, 16);
            this.partID_title.TabIndex = 6;
            this.partID_title.Text = "Part ID";
            // 
            // StockManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 766);
            this.Controls.Add(this.quantity_title);
            this.Controls.Add(this.necessary_stock_title);
            this.Controls.Add(this.current_stock_title);
            this.Controls.Add(this.part_name_title);
            this.Controls.Add(this.partID_title);
            this.Controls.Add(this.order_button);
            this.Controls.Add(this.part_stock_panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StockManagerForm";
            this.Text = "Order stock";
            this.Load += new System.EventHandler(this.StockManagerForm_Load);
            this.part_stock_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel part_stock_panel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Label partIDLbl;
        private System.Windows.Forms.Label quantity_title;
        private System.Windows.Forms.Label necessary_stock_title;
        private System.Windows.Forms.Label current_stock_title;
        private System.Windows.Forms.Label part_name_title;
        private System.Windows.Forms.Label partID_title;
    }
}