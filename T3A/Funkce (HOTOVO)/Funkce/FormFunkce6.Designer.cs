namespace Funkce
{
    partial class FormFunkce6
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
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.Butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(12, 12);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.PlaceholderText = "Jméno";
            this.TxtBox.Size = new System.Drawing.Size(100, 23);
            this.TxtBox.TabIndex = 0;
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(118, 12);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(75, 23);
            this.Butt.TabIndex = 1;
            this.Butt.Text = "Ahoj";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // FormFunkce6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 54);
            this.Controls.Add(this.Butt);
            this.Controls.Add(this.TxtBox);
            this.Name = "FormFunkce6";
            this.Text = "Pozdrav";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtBox;
        private Button Butt;
    }
}