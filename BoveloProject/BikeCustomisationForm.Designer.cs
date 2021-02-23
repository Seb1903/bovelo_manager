
namespace Bovelo
{
    partial class BikeCustomisationForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.table_colors = new System.Windows.Forms.TableLayoutPanel();
            this.color1 = new System.Windows.Forms.RadioButton();
            this.color2 = new System.Windows.Forms.RadioButton();
            this.color3 = new System.Windows.Forms.RadioButton();
            this.category_label = new System.Windows.Forms.Label();
            this.color_label = new System.Windows.Forms.Label();
            this.size_label = new System.Windows.Forms.Label();
            this.quantity_label = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.addBasket = new System.Windows.Forms.Button();
            this.showBasket = new System.Windows.Forms.Button();
            this.size1 = new System.Windows.Forms.RadioButton();
            this.size2 = new System.Windows.Forms.RadioButton();
            this.description = new System.Windows.Forms.Label();
            this.thumbnailBox = new System.Windows.Forms.PictureBox();
            this.button_back = new System.Windows.Forms.Button();
            this.table_colors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // table_colors
            // 
            this.table_colors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_colors.ColumnCount = 3;
            this.table_colors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_colors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_colors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_colors.Controls.Add(this.color1, 0, 0);
            this.table_colors.Controls.Add(this.color2, 1, 0);
            this.table_colors.Controls.Add(this.color3, 2, 0);
            this.table_colors.Location = new System.Drawing.Point(632, 73);
            this.table_colors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.table_colors.Name = "table_colors";
            this.table_colors.RowCount = 1;
            this.table_colors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_colors.Size = new System.Drawing.Size(435, 91);
            this.table_colors.TabIndex = 3;
            // 
            // color1
            // 
            this.color1.Appearance = System.Windows.Forms.Appearance.Button;
            this.color1.BackColor = System.Drawing.Color.Black;
            this.color1.ForeColor = System.Drawing.Color.White;
            this.color1.Location = new System.Drawing.Point(4, 5);
            this.color1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(135, 81);
            this.color1.TabIndex = 0;
            this.color1.TabStop = true;
            this.color1.Text = "Black";
            this.color1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.color1.UseVisualStyleBackColor = false;
            this.color1.CheckedChanged += new System.EventHandler(this.color1_check);
            // 
            // color2
            // 
            this.color2.Appearance = System.Windows.Forms.Appearance.Button;
            this.color2.BackColor = System.Drawing.Color.MidnightBlue;
            this.color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color2.ForeColor = System.Drawing.Color.White;
            this.color2.Location = new System.Drawing.Point(149, 5);
            this.color2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(135, 81);
            this.color2.TabIndex = 1;
            this.color2.TabStop = true;
            this.color2.Text = "Dark blue";
            this.color2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.color2.UseVisualStyleBackColor = false;
            this.color2.CheckedChanged += new System.EventHandler(this.color2_check);
            // 
            // color3
            // 
            this.color3.Appearance = System.Windows.Forms.Appearance.Button;
            this.color3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.color3.Location = new System.Drawing.Point(294, 5);
            this.color3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(136, 81);
            this.color3.TabIndex = 2;
            this.color3.TabStop = true;
            this.color3.Text = "Light Blue";
            this.color3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.color3.UseVisualStyleBackColor = false;
            this.color3.CheckedChanged += new System.EventHandler(this.color3_check);
            // 
            // category_label
            // 
            this.category_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.category_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.category_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_label.Location = new System.Drawing.Point(58, 17);
            this.category_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(416, 31);
            this.category_label.TabIndex = 4;
            this.category_label.Text = "Category";
            this.category_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // color_label
            // 
            this.color_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.color_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_label.Location = new System.Drawing.Point(638, 17);
            this.color_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(424, 31);
            this.color_label.TabIndex = 5;
            this.color_label.Text = "Color";
            this.color_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // size_label
            // 
            this.size_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.size_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.size_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_label.Location = new System.Drawing.Point(638, 217);
            this.size_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(424, 34);
            this.size_label.TabIndex = 6;
            this.size_label.Text = "Size";
            this.size_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantity_label
            // 
            this.quantity_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quantity_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.Location = new System.Drawing.Point(638, 354);
            this.quantity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(424, 33);
            this.quantity_label.TabIndex = 9;
            this.quantity_label.Text = "Quantity ";
            this.quantity_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantity
            // 
            this.quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity.Location = new System.Drawing.Point(638, 405);
            this.quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantity.MaximumSize = new System.Drawing.Size(452, 0);
            this.quantity.MinimumSize = new System.Drawing.Size(50, 0);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(424, 26);
            this.quantity.TabIndex = 10;
            this.quantity.ValueChanged += new System.EventHandler(this.quantity_scroll);
            // 
            // addBasket
            // 
            this.addBasket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBasket.Location = new System.Drawing.Point(921, 514);
            this.addBasket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBasket.MaximumSize = new System.Drawing.Size(158, 35);
            this.addBasket.MinimumSize = new System.Drawing.Size(158, 35);
            this.addBasket.Name = "addBasket";
            this.addBasket.Size = new System.Drawing.Size(158, 35);
            this.addBasket.TabIndex = 11;
            this.addBasket.Text = "Add to basket";
            this.addBasket.UseVisualStyleBackColor = true;
            this.addBasket.Click += new System.EventHandler(this.addBasket_button);
            // 
            // showBasket
            // 
            this.showBasket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showBasket.Location = new System.Drawing.Point(728, 514);
            this.showBasket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showBasket.MaximumSize = new System.Drawing.Size(158, 35);
            this.showBasket.MinimumSize = new System.Drawing.Size(158, 35);
            this.showBasket.Name = "showBasket";
            this.showBasket.Size = new System.Drawing.Size(158, 35);
            this.showBasket.TabIndex = 12;
            this.showBasket.Text = "Show basket";
            this.showBasket.UseVisualStyleBackColor = true;
            this.showBasket.Click += new System.EventHandler(this.showBasket_button);
            // 
            // size1
            // 
            this.size1.AutoSize = true;
            this.size1.Location = new System.Drawing.Point(674, 282);
            this.size1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(58, 24);
            this.size1.TabIndex = 15;
            this.size1.TabStop = true;
            this.size1.Text = "26\"";
            this.size1.UseVisualStyleBackColor = true;
            this.size1.CheckedChanged += new System.EventHandler(this.size1_check);
            // 
            // size2
            // 
            this.size2.AutoSize = true;
            this.size2.Location = new System.Drawing.Point(926, 282);
            this.size2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(58, 24);
            this.size2.TabIndex = 16;
            this.size2.TabStop = true;
            this.size2.Text = "28\"";
            this.size2.UseVisualStyleBackColor = true;
            this.size2.CheckedChanged += new System.EventHandler(this.size2_check);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(33, 392);
            this.description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(518, 157);
            this.description.TabIndex = 17;
            // 
            // thumbnailBox
            // 
            this.thumbnailBox.Location = new System.Drawing.Point(58, 67);
            this.thumbnailBox.Name = "thumbnailBox";
            this.thumbnailBox.Size = new System.Drawing.Size(416, 310);
            this.thumbnailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumbnailBox.TabIndex = 18;
            this.thumbnailBox.TabStop = false;
            // 
            // button_back
            // 
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_back.Location = new System.Drawing.Point(618, 514);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(86, 35);
            this.button_back.TabIndex = 19;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // BikeCustomisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 620);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.thumbnailBox);
            this.Controls.Add(this.description);
            this.Controls.Add(this.size2);
            this.Controls.Add(this.size1);
            this.Controls.Add(this.showBasket);
            this.Controls.Add(this.addBasket);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.size_label);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.table_colors);
            this.MaximumSize = new System.Drawing.Size(1129, 676);
            this.MinimumSize = new System.Drawing.Size(1129, 676);
            this.Name = "BikeCustomisationForm";
            this.Text = "Bovelo";
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            this.table_colors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel table_colors;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Button addBasket;
        private System.Windows.Forms.Button showBasket;
        private System.Windows.Forms.RadioButton size2;
        private System.Windows.Forms.RadioButton size1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.RadioButton color1;
        private System.Windows.Forms.RadioButton color2;
        private System.Windows.Forms.RadioButton color3;
        private System.Windows.Forms.PictureBox thumbnailBox;
        private System.Windows.Forms.Button button_back;
    }
}

