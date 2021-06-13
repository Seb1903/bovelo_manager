namespace Bovelo
{
    partial class AddPart
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
            this.name_texte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.validation_label = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reference_texte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.provider_box = new System.Windows.Forms.TextBox();
            this.description_box = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_texte
            // 
            this.name_texte.Location = new System.Drawing.Point(182, 116);
            this.name_texte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_texte.Name = "name_texte";
            this.name_texte.Size = new System.Drawing.Size(168, 26);
            this.name_texte.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Part Form";
            // 
            // validation_label
            // 
            this.validation_label.AutoSize = true;
            this.validation_label.Location = new System.Drawing.Point(28, 240);
            this.validation_label.Name = "validation_label";
            this.validation_label.Size = new System.Drawing.Size(0, 20);
            this.validation_label.TabIndex = 4;
            this.validation_label.Visible = false;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(28, 297);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(84, 35);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reference";
            // 
            // reference_texte
            // 
            this.reference_texte.Location = new System.Drawing.Point(182, 79);
            this.reference_texte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reference_texte.Name = "reference_texte";
            this.reference_texte.Size = new System.Drawing.Size(168, 26);
            this.reference_texte.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Provider";
            // 
            // provider_box
            // 
            this.provider_box.Location = new System.Drawing.Point(182, 158);
            this.provider_box.Name = "provider_box";
            this.provider_box.Size = new System.Drawing.Size(168, 26);
            this.provider_box.TabIndex = 9;
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(182, 197);
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(168, 26);
            this.description_box.TabIndex = 10;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(28, 200);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(89, 20);
            this.Description.TabIndex = 11;
            this.Description.Text = "Description";
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 422);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.provider_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reference_texte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.validation_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_texte);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddPart";
            this.Text = "New Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_texte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label validation_label;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reference_texte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox provider_box;
        private System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.Label Description;
    }
}