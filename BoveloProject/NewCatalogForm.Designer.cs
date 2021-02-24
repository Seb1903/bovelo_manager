
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adventureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBox
            // 
            this.cityBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityBox.Image = global::Bovelo.Properties.Resources.city_no_background;
            this.cityBox.Location = new System.Drawing.Point(4, 4);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(558, 638);
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
            this.explorerBox.Location = new System.Drawing.Point(569, 4);
            this.explorerBox.Name = "explorerBox";
            this.explorerBox.Size = new System.Drawing.Size(558, 638);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 102);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 645F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1698, 646);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // adventureBox
            // 
            this.adventureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adventureBox.Image = global::Bovelo.Properties.Resources.adventure_no_background;
            this.adventureBox.Location = new System.Drawing.Point(1134, 4);
            this.adventureBox.Name = "adventureBox";
            this.adventureBox.Size = new System.Drawing.Size(560, 638);
            this.adventureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adventureBox.TabIndex = 6;
            this.adventureBox.TabStop = false;
            this.adventureBox.Click += new System.EventHandler(this.adventureBox_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 793);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "City";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 793);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Explorer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1153, 793);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(564, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adventure";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(719, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bovelo Catalog";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1647, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // NewCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 865);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewCatalogForm";
            this.Text = "NewCatalogForm";
            this.Load += new System.EventHandler(this.NewCatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adventureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}