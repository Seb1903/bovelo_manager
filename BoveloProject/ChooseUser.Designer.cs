
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
            this.label1 = new System.Windows.Forms.Label();
            this.Managerbtn = new System.Windows.Forms.Button();
            this.Fitterbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(82, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "User selection : ";
            // 
            // Managerbtn
            // 
            this.Managerbtn.Location = new System.Drawing.Point(238, 110);
            this.Managerbtn.Name = "Managerbtn";
            this.Managerbtn.Size = new System.Drawing.Size(310, 108);
            this.Managerbtn.TabIndex = 1;
            this.Managerbtn.Text = "Manager";
            this.Managerbtn.UseVisualStyleBackColor = true;
            this.Managerbtn.Click += new System.EventHandler(this.Managerbtn_Click);
            // 
            // Fitterbtn
            // 
            this.Fitterbtn.Location = new System.Drawing.Point(238, 266);
            this.Fitterbtn.Name = "Fitterbtn";
            this.Fitterbtn.Size = new System.Drawing.Size(310, 112);
            this.Fitterbtn.TabIndex = 0;
            this.Fitterbtn.Text = "Fitter";
            this.Fitterbtn.Click += new System.EventHandler(this.Fitterbtn_Click);
            // 
            // UserSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fitterbtn);
            this.Controls.Add(this.Managerbtn);
            this.Controls.Add(this.label1);
            this.Name = "UserSelection";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Managerbtn;
        private System.Windows.Forms.Button Fitterbtn;
    }
}