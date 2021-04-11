
namespace Bovelo
{
    partial class ChooseUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseUser));
            this.label1 = new System.Windows.Forms.Label();
            this.Managerbtn = new System.Windows.Forms.Button();
            this.Fitterbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User selection ";
            // 
            // Managerbtn
            // 
            this.Managerbtn.AutoSize = true;
            this.Managerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Managerbtn.Location = new System.Drawing.Point(70, 114);
            this.Managerbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Managerbtn.Name = "Managerbtn";
            this.Managerbtn.Size = new System.Drawing.Size(142, 46);
            this.Managerbtn.TabIndex = 1;
            this.Managerbtn.Text = "Manager";
            this.Managerbtn.UseVisualStyleBackColor = true;
            this.Managerbtn.Click += new System.EventHandler(this.Managerbtn_Click);
            // 
            // Fitterbtn
            // 
            this.Fitterbtn.AutoSize = true;
            this.Fitterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fitterbtn.Location = new System.Drawing.Point(236, 114);
            this.Fitterbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Fitterbtn.Name = "Fitterbtn";
            this.Fitterbtn.Size = new System.Drawing.Size(142, 46);
            this.Fitterbtn.TabIndex = 0;
            this.Fitterbtn.Text = "Fitter";
            this.Fitterbtn.Click += new System.EventHandler(this.Fitterbtn_Click);
            // 
            // ChooseUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 264);
            this.Controls.Add(this.Fitterbtn);
            this.Controls.Add(this.Managerbtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(480, 320);
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "ChooseUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Managerbtn;
        private System.Windows.Forms.Button Fitterbtn;
    }
}