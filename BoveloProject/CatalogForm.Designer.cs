
namespace Bovelo
{
    partial class CatalogForm
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
            this.category = new System.Windows.Forms.ComboBox();
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
            this.table_colors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // category
            // 
            this.category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "City",
            "Explorer",
            "Adventure"});
            this.category.Location = new System.Drawing.Point(13, 40);
            this.category.MaximumSize = new System.Drawing.Size(300, 0);
            this.category.MinimumSize = new System.Drawing.Size(300, 0);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(300, 21);
            this.category.TabIndex = 1;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_choice);
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
            this.table_colors.Location = new System.Drawing.Point(421, 40);
            this.table_colors.Name = "table_colors";
            this.table_colors.RowCount = 1;
            this.table_colors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_colors.Size = new System.Drawing.Size(290, 59);
            this.table_colors.TabIndex = 3;
            // 
            // color1
            // 
            this.color1.Appearance = System.Windows.Forms.Appearance.Button;
            this.color1.BackColor = System.Drawing.Color.Black;
            this.color1.ForeColor = System.Drawing.Color.White;
            this.color1.Location = new System.Drawing.Point(3, 3);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(90, 53);
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
            this.color2.ForeColor = System.Drawing.Color.White;
            this.color2.Location = new System.Drawing.Point(99, 3);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(90, 53);
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
            this.color3.Location = new System.Drawing.Point(195, 3);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(91, 53);
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
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(13, 13);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(49, 13);
            this.category_label.TabIndex = 4;
            this.category_label.Text = "Category";
            // 
            // color_label
            // 
            this.color_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color_label.AutoSize = true;
            this.color_label.Location = new System.Drawing.Point(424, 13);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(31, 13);
            this.color_label.TabIndex = 5;
            this.color_label.Text = "Color";
            // 
            // size_label
            // 
            this.size_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.size_label.AutoSize = true;
            this.size_label.Location = new System.Drawing.Point(424, 131);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(27, 13);
            this.size_label.TabIndex = 6;
            this.size_label.Text = "Size";
            // 
            // quantity_label
            // 
            this.quantity_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity_label.AutoSize = true;
            this.quantity_label.Location = new System.Drawing.Point(424, 221);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(46, 13);
            this.quantity_label.TabIndex = 9;
            this.quantity_label.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity.Location = new System.Drawing.Point(418, 255);
            this.quantity.MaximumSize = new System.Drawing.Size(301, 0);
            this.quantity.MinimumSize = new System.Drawing.Size(301, 0);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(301, 20);
            this.quantity.TabIndex = 10;
            this.quantity.ValueChanged += new System.EventHandler(this.quantity_scroll);
            // 
            // addBasket
            // 
            this.addBasket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBasket.Location = new System.Drawing.Point(614, 334);
            this.addBasket.MaximumSize = new System.Drawing.Size(105, 23);
            this.addBasket.MinimumSize = new System.Drawing.Size(105, 23);
            this.addBasket.Name = "addBasket";
            this.addBasket.Size = new System.Drawing.Size(105, 23);
            this.addBasket.TabIndex = 11;
            this.addBasket.Text = "Add to basket";
            this.addBasket.UseVisualStyleBackColor = true;
            this.addBasket.Click += new System.EventHandler(this.addBasket_button);
            // 
            // showBasket
            // 
            this.showBasket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showBasket.Location = new System.Drawing.Point(485, 334);
            this.showBasket.MaximumSize = new System.Drawing.Size(105, 23);
            this.showBasket.MinimumSize = new System.Drawing.Size(105, 23);
            this.showBasket.Name = "showBasket";
            this.showBasket.Size = new System.Drawing.Size(105, 23);
            this.showBasket.TabIndex = 12;
            this.showBasket.Text = "Show basket";
            this.showBasket.UseVisualStyleBackColor = true;
            this.showBasket.Click += new System.EventHandler(this.showBasket_button);
            // 
            // size1
            // 
            this.size1.AutoSize = true;
            this.size1.Location = new System.Drawing.Point(418, 166);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(42, 17);
            this.size1.TabIndex = 15;
            this.size1.TabStop = true;
            this.size1.Text = "26\"";
            this.size1.UseVisualStyleBackColor = true;
            this.size1.CheckedChanged += new System.EventHandler(this.size1_check);
            // 
            // size2
            // 
            this.size2.AutoSize = true;
            this.size2.Location = new System.Drawing.Point(568, 166);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(42, 17);
            this.size2.TabIndex = 16;
            this.size2.TabStop = true;
            this.size2.Text = "28\"";
            this.size2.UseVisualStyleBackColor = true;
            this.size2.CheckedChanged += new System.EventHandler(this.size2_check);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(13, 96);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(0, 13);
            this.description.TabIndex = 17;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 420);
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
            this.Controls.Add(this.category);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(760, 459);
            this.MinimumSize = new System.Drawing.Size(760, 459);
            this.Name = "CatalogForm";
            this.Text = "Bovelo";
            this.table_colors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox category;
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
        private System.Windows.Forms.Label label1;
    }
}

