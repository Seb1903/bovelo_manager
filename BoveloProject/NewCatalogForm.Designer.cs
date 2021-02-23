
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
            this.adventureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBox
            // 
            this.cityBox.Image = global::Bovelo.Properties.Resources.city;
            this.cityBox.Location = new System.Drawing.Point(41, 139);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(195, 128);
            this.cityBox.TabIndex = 0;
            this.cityBox.TabStop = false;
            // 
            // explorerBox
            // 
            this.explorerBox.Image = global::Bovelo.Properties.Resources.explorer;
            this.explorerBox.Location = new System.Drawing.Point(297, 139);
            this.explorerBox.Name = "explorerBox";
            this.explorerBox.Size = new System.Drawing.Size(195, 128);
            this.explorerBox.TabIndex = 1;
            this.explorerBox.TabStop = false;
            // 
            // adventureBox
            // 
            this.adventureBox.Image = global::Bovelo.Properties.Resources.adventure;
            this.adventureBox.Location = new System.Drawing.Point(548, 139);
            this.adventureBox.Name = "adventureBox";
            this.adventureBox.Size = new System.Drawing.Size(195, 128);
            this.adventureBox.TabIndex = 2;
            this.adventureBox.TabStop = false;
            // 
            // NewCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adventureBox);
            this.Controls.Add(this.explorerBox);
            this.Controls.Add(this.cityBox);
            this.Name = "NewCatalogForm";
            this.Text = "NewCatalogForm";
            this.Load += new System.EventHandler(this.NewCatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cityBox;
        private System.Windows.Forms.PictureBox explorerBox;
        private System.Windows.Forms.PictureBox adventureBox;
    }
}