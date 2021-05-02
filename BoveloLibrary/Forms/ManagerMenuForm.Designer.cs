
namespace Bovelo
{
    partial class ManagerMenus
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.allbikescontrol = new AllBikes();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.supplier_orders_control = new supplier_orders();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.planningbutton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1392, 1112);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.allbikescontrol);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1384, 1079);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Bikes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // allbikescontrol
            // 
            this.allbikescontrol.AutoScroll = true;
            this.allbikescontrol.AutoSize = true;
            this.allbikescontrol.Location = new System.Drawing.Point(0, 4);
            this.allbikescontrol.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.allbikescontrol.Name = "allbikescontrol";
            this.allbikescontrol.Size = new System.Drawing.Size(1011, 889);
            this.allbikescontrol.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.supplier_orders_control);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1384, 1079);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supplier";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // supplier_orders_control
            // 
            this.supplier_orders_control.Location = new System.Drawing.Point(0, 0);
            this.supplier_orders_control.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.supplier_orders_control.Name = "supplier_orders_control";
            this.supplier_orders_control.Size = new System.Drawing.Size(884, 1011);
            this.supplier_orders_control.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.planningbutton);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1384, 1079);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Planning";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // planningbutton
            // 
            this.planningbutton.AutoSize = true;
            this.planningbutton.Location = new System.Drawing.Point(27, 37);
            this.planningbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.planningbutton.Name = "planningbutton";
            this.planningbutton.Size = new System.Drawing.Size(200, 38);
            this.planningbutton.TabIndex = 0;
            this.planningbutton.Text = "Open planning window";
            this.planningbutton.Click += new System.EventHandler(this.planningbutton_Click);
            // 
            // ManagerMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 1129);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagerMenus";
            this.Text = "Menu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private AllBikes allbikescontrol;
        private supplier_orders supplier_orders_control;
        private System.Windows.Forms.Button planningbutton;
    }
}