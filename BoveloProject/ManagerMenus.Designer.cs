
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.planningcontrol = new ManagerForm();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1237, 890);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.allbikescontrol);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1229, 861);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Bikes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // allbikescontrol
            // 
            this.allbikescontrol.AutoScroll = true;
            this.allbikescontrol.AutoSize = true;
            this.allbikescontrol.Location = new System.Drawing.Point(0, 3);
            this.allbikescontrol.Name = "allbikescontrol";
            this.allbikescontrol.Size = new System.Drawing.Size(899, 474);
            this.allbikescontrol.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.supplier_orders_control);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1229, 861);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supplier orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // supplier_orders_control
            // 
            this.supplier_orders_control.Location = new System.Drawing.Point(0, 0);
            this.supplier_orders_control.Name = "supplier_orders_control";
            this.supplier_orders_control.Size = new System.Drawing.Size(786, 809);
            this.supplier_orders_control.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1229, 861);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Planning";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1229, 861);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // planningcontrol
            // 
            this.planningcontrol.AutoSize = true;
            this.planningcontrol.ClientSize = new System.Drawing.Size(1221, 828);
            this.planningcontrol.Location = new System.Drawing.Point(3, -128);
            this.planningcontrol.Name = "planningcontrol";
            this.planningcontrol.Visible = false;
            // 
            // ManagerMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 903);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerMenus";
            this.Text = "Manager_menus";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private AllBikes allbikescontrol;
        private supplier_orders supplier_orders_control;
        private ManagerForm planningcontrol;
    }
}