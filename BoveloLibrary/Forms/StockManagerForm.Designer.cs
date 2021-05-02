
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
            this.ID_title_lbl = new System.Windows.Forms.Label();
            this.name_title_lbl = new System.Windows.Forms.Label();
            this.stock_title_lbl = new System.Windows.Forms.Label();
            this.necessary_title_lbl = new System.Windows.Forms.Label();
            this.quantity_title_lbl = new System.Windows.Forms.Label();
            this.supplier_title_lbl = new System.Windows.Forms.Label();
            this.part_stock_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.addPart_btn = new System.Windows.Forms.Button();
            this.orderDone_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_title_lbl
            // 
            this.ID_title_lbl.AutoSize = true;
            this.ID_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_title_lbl.Location = new System.Drawing.Point(45, 20);
            this.ID_title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_title_lbl.Name = "ID_title_lbl";
            this.ID_title_lbl.Size = new System.Drawing.Size(38, 29);
            this.ID_title_lbl.TabIndex = 0;
            this.ID_title_lbl.Text = "ID";
            // 
            // name_title_lbl
            // 
            this.name_title_lbl.AutoSize = true;
            this.name_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_title_lbl.Location = new System.Drawing.Point(142, 20);
            this.name_title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_title_lbl.Name = "name_title_lbl";
            this.name_title_lbl.Size = new System.Drawing.Size(82, 29);
            this.name_title_lbl.TabIndex = 1;
            this.name_title_lbl.Text = "Name";
            // 
            // stock_title_lbl
            // 
            this.stock_title_lbl.AutoSize = true;
            this.stock_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_title_lbl.Location = new System.Drawing.Point(297, 20);
            this.stock_title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stock_title_lbl.Name = "stock_title_lbl";
            this.stock_title_lbl.Size = new System.Drawing.Size(171, 29);
            this.stock_title_lbl.TabIndex = 2;
            this.stock_title_lbl.Text = "Current Stock";
            // 
            // necessary_title_lbl
            // 
            this.necessary_title_lbl.AutoSize = true;
            this.necessary_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.necessary_title_lbl.Location = new System.Drawing.Point(546, 20);
            this.necessary_title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.necessary_title_lbl.Name = "necessary_title_lbl";
            this.necessary_title_lbl.Size = new System.Drawing.Size(208, 29);
            this.necessary_title_lbl.TabIndex = 3;
            this.necessary_title_lbl.Text = "Necessary Stock";
            // 
            // quantity_title_lbl
            // 
            this.quantity_title_lbl.AutoSize = true;
            this.quantity_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_title_lbl.Location = new System.Drawing.Point(845, 20);
            this.quantity_title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity_title_lbl.Name = "quantity_title_lbl";
            this.quantity_title_lbl.Size = new System.Drawing.Size(81, 29);
            this.quantity_title_lbl.TabIndex = 4;
            this.quantity_title_lbl.Text = "Order";
            // 
            // supplier_title_lbl
            // 
            this.supplier_title_lbl.AutoSize = true;
            this.supplier_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_title_lbl.Location = new System.Drawing.Point(1076, 20);
            this.supplier_title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplier_title_lbl.Name = "supplier_title_lbl";
            this.supplier_title_lbl.Size = new System.Drawing.Size(112, 29);
            this.supplier_title_lbl.TabIndex = 5;
            this.supplier_title_lbl.Text = "Supplier";
            // 
            // part_stock_panel
            // 
            this.part_stock_panel.AutoScroll = true;
            this.part_stock_panel.Location = new System.Drawing.Point(20, 54);
            this.part_stock_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.part_stock_panel.Name = "part_stock_panel";
            this.part_stock_panel.Size = new System.Drawing.Size(1304, 1058);
            this.part_stock_panel.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1120, 1146);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Order_Button_Click);
            // 
            // addPart_btn
            // 
            this.addPart_btn.Location = new System.Drawing.Point(888, 1146);
            this.addPart_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPart_btn.Name = "addPart_btn";
            this.addPart_btn.Size = new System.Drawing.Size(202, 45);
            this.addPart_btn.TabIndex = 8;
            this.addPart_btn.Text = "Add";
            this.addPart_btn.UseVisualStyleBackColor = true;
            this.addPart_btn.Click += new System.EventHandler(this.Add_Part_Button_Click);
            // 
            // orderDone_Lbl
            // 
            this.orderDone_Lbl.AutoSize = true;
            this.orderDone_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDone_Lbl.Location = new System.Drawing.Point(20, 1146);
            this.orderDone_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderDone_Lbl.Name = "orderDone_Lbl";
            this.orderDone_Lbl.Size = new System.Drawing.Size(0, 29);
            this.orderDone_Lbl.TabIndex = 9;
            // 
            // StockManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 1218);
            this.Controls.Add(this.orderDone_Lbl);
            this.Controls.Add(this.addPart_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.part_stock_panel);
            this.Controls.Add(this.supplier_title_lbl);
            this.Controls.Add(this.quantity_title_lbl);
            this.Controls.Add(this.necessary_title_lbl);
            this.Controls.Add(this.stock_title_lbl);
            this.Controls.Add(this.name_title_lbl);
            this.Controls.Add(this.ID_title_lbl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockManagerForm";
            this.Text = "Supplier Order";
            this.Load += new System.EventHandler(this.StockManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_title_lbl;
        private System.Windows.Forms.Label name_title_lbl;
        private System.Windows.Forms.Label stock_title_lbl;
        private System.Windows.Forms.Label necessary_title_lbl;
        private System.Windows.Forms.Label quantity_title_lbl;
        private System.Windows.Forms.Label supplier_title_lbl;
        private System.Windows.Forms.Panel part_stock_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addPart_btn;
        private System.Windows.Forms.Label orderDone_Lbl;
    }
}