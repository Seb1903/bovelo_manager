
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_title_lbl
            // 
            this.ID_title_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID_title_lbl.AutoSize = true;
            this.ID_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_title_lbl.Location = new System.Drawing.Point(13, 22);
            this.ID_title_lbl.Name = "ID_title_lbl";
            this.ID_title_lbl.Size = new System.Drawing.Size(60, 18);
            this.ID_title_lbl.TabIndex = 0;
            this.ID_title_lbl.Text = "Part ID";
            // 
            // name_title_lbl
            // 
            this.name_title_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_title_lbl.AutoSize = true;
            this.name_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_title_lbl.Location = new System.Drawing.Point(89, 22);
            this.name_title_lbl.Name = "name_title_lbl";
            this.name_title_lbl.Size = new System.Drawing.Size(85, 18);
            this.name_title_lbl.TabIndex = 1;
            this.name_title_lbl.Text = "Part name";
            // 
            // stock_title_lbl
            // 
            this.stock_title_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stock_title_lbl.AutoSize = true;
            this.stock_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_title_lbl.Location = new System.Drawing.Point(198, 22);
            this.stock_title_lbl.Name = "stock_title_lbl";
            this.stock_title_lbl.Size = new System.Drawing.Size(113, 18);
            this.stock_title_lbl.TabIndex = 2;
            this.stock_title_lbl.Text = "Current Stock";
            // 
            // necessary_title_lbl
            // 
            this.necessary_title_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.necessary_title_lbl.AutoSize = true;
            this.necessary_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.necessary_title_lbl.Location = new System.Drawing.Point(359, 13);
            this.necessary_title_lbl.Name = "necessary_title_lbl";
            this.necessary_title_lbl.Size = new System.Drawing.Size(135, 18);
            this.necessary_title_lbl.TabIndex = 3;
            this.necessary_title_lbl.Text = "Necessary stock";
            // 
            // quantity_title_lbl
            // 
            this.quantity_title_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity_title_lbl.AutoSize = true;
            this.quantity_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_title_lbl.Location = new System.Drawing.Point(548, 22);
            this.quantity_title_lbl.Name = "quantity_title_lbl";
            this.quantity_title_lbl.Size = new System.Drawing.Size(135, 18);
            this.quantity_title_lbl.TabIndex = 4;
            this.quantity_title_lbl.Text = "Quantity to order";
            // 
            // supplier_title_lbl
            // 
            this.supplier_title_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplier_title_lbl.AutoSize = true;
            this.supplier_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_title_lbl.Location = new System.Drawing.Point(726, 22);
            this.supplier_title_lbl.Name = "supplier_title_lbl";
            this.supplier_title_lbl.Size = new System.Drawing.Size(103, 18);
            this.supplier_title_lbl.TabIndex = 5;
            this.supplier_title_lbl.Text = "Part supplier";
            // 
            // part_stock_panel
            // 
            this.part_stock_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.part_stock_panel.AutoScroll = true;
            this.part_stock_panel.Location = new System.Drawing.Point(13, 53);
            this.part_stock_panel.Name = "part_stock_panel";
            this.part_stock_panel.Size = new System.Drawing.Size(869, 670);
            this.part_stock_panel.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(747, 745);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Order parts to suppliers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Order_Button_Click);
            // 
            // addPart_btn
            // 
            this.addPart_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPart_btn.Location = new System.Drawing.Point(592, 745);
            this.addPart_btn.Name = "addPart_btn";
            this.addPart_btn.Size = new System.Drawing.Size(135, 29);
            this.addPart_btn.TabIndex = 8;
            this.addPart_btn.Text = "Add another part";
            this.addPart_btn.UseVisualStyleBackColor = true;
            this.addPart_btn.Click += new System.EventHandler(this.Add_Part_Button_Click);
            // 
            // orderDone_Lbl
            // 
            this.orderDone_Lbl.AutoSize = true;
            this.orderDone_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDone_Lbl.Location = new System.Drawing.Point(13, 745);
            this.orderDone_Lbl.Name = "orderDone_Lbl";
            this.orderDone_Lbl.Size = new System.Drawing.Size(0, 18);
            this.orderDone_Lbl.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "to build ordered bikes";
            // 
            // StockManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 780);
            this.Controls.Add(this.label1);
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
            this.Name = "StockManagerForm";
            this.Text = "Part stock order";
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
        private System.Windows.Forms.Label label1;
    }
}