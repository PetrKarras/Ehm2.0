namespace Funkce
{
    partial class FormFunkce11
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
            this.Butt = new System.Windows.Forms.Button();
            this.LblOut = new System.Windows.Forms.Label();
            this.TxtBoxA = new System.Windows.Forms.TextBox();
            this.TxtBoxZnak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(22, 79);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(196, 23);
            this.Butt.TabIndex = 2;
            this.Butt.Text = "Hledej";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Location = new System.Drawing.Point(22, 115);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(196, 217);
            this.LblOut.TabIndex = 3;
            // 
            // TxtBoxA
            // 
            this.TxtBoxA.Location = new System.Drawing.Point(22, 21);
            this.TxtBoxA.Name = "TxtBoxA";
            this.TxtBoxA.PlaceholderText = "Řetezec";
            this.TxtBoxA.Size = new System.Drawing.Size(196, 23);
            this.TxtBoxA.TabIndex = 4;
            // 
            // TxtBoxZnak
            // 
            this.TxtBoxZnak.Location = new System.Drawing.Point(22, 50);
            this.TxtBoxZnak.MaxLength = 1;
            this.TxtBoxZnak.Name = "TxtBoxZnak";
            this.TxtBoxZnak.PlaceholderText = "Znak";
            this.TxtBoxZnak.Size = new System.Drawing.Size(196, 23);
            this.TxtBoxZnak.TabIndex = 5;
            // 
            // FormFunkce11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 341);
            this.Controls.Add(this.TxtBoxZnak);
            this.Controls.Add(this.TxtBoxA);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.Butt);
            this.Name = "FormFunkce11";
            this.Text = "Hledač znaků";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Butt;
        private Label LblOut;
        private TextBox TxtBoxA;
        private TextBox TxtBoxZnak;
    }
}