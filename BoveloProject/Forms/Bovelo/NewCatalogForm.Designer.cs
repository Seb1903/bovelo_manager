
namespace Bovelo
{
    partial class NewCatalogForm
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
            this.cityBox = new System.Windows.Forms.PictureBox();
            this.explorerBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.adventureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.basketBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adventureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBox
            // 
            this.cityBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityBox.Image = global::Bovelo.Properties.Resources.city_no_background;
            this.cityBox.Location = new System.Drawing.Point(3, 3);
            this.cityBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(371, 414);
            this.cityBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cityBox.TabIndex = 0;
            this.cityBox.TabStop = false;
            this.cityBox.Click += new System.EventHandler(this.cityBox_Click);
            // 
            // explorerBox
            // 
            this.explorerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.explorerBox.Image = global::Bovelo.Properties.Resources.explorer_no_background;
            this.explorerBox.Location = new System.Drawing.Point(379, 3);
            this.explorerBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.explorerBox.Name = "explorerBox";
            this.explorerBox.Size = new System.Drawing.Size(372, 414);
            this.explorerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.explorerBox.TabIndex = 1;
            this.explorerBox.TabStop = false;
            this.explorerBox.Click += new System.EventHandler(this.explorerBox_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.adventureBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cityBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.explorerBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 419F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1132, 420);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // adventureBox
            // 
            this.adventureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adventureBox.Image = global::Bovelo.Properties.Resources.adventure_no_background;
            this.adventureBox.Location = new System.Drawing.Point(756, 3);
            this.adventureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adventureBox.Name = "adventureBox";
            this.adventureBox.Size = new System.Drawing.Size(373, 414);
            this.adventureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adventureBox.TabIndex = 6;
            this.adventureBox.TabStop = false;
            this.adventureBox.Click += new System.EventHandler(this.adventureBox_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 515);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "City";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 515);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Explorer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(769, 515);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adventure";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bovelo Catalog";
            // 
            // basketBox
            // 
            this.basketBox.Image = global::Bovelo.Properties.Resources.basket;
            this.basketBox.Location = new System.Drawing.Point(1098, 16);
            this.basketBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.basketBox.Name = "basketBox";
            this.basketBox.Size = new System.Drawing.Size(47, 40);
            this.basketBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.basketBox.TabIndex = 8;
            this.basketBox.TabStop = false;
            this.basketBox.Click += new System.EventHandler(this.basketBox_Click);
            // 
            // NewCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 562);
            this.Controls.Add(this.basketBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewCatalogForm";
            this.Text = "NewCatalogForm";
            this.Load += new System.EventHandler(this.NewCatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adventureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cityBox;
        private System.Windows.Forms.PictureBox explorerBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox adventureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox basketBox;
    }
}