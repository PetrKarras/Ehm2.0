namespace Funkce
{
    partial class FormFunkce1
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
            this.NumUD1 = new System.Windows.Forms.NumericUpDown();
            this.NumUD2 = new System.Windows.Forms.NumericUpDown();
            this.NumUD3 = new System.Windows.Forms.NumericUpDown();
            this.RadButVze = new System.Windows.Forms.RadioButton();
            this.RadButSes = new System.Windows.Forms.RadioButton();
            this.LblOut = new System.Windows.Forms.Label();
            this.LblCislo1 = new System.Windows.Forms.Label();
            this.LblCislo2 = new System.Windows.Forms.Label();
            this.LblCislo3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD3)).BeginInit();
            this.SuspendLayout();
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(12, 65);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(75, 23);
            this.Butt.TabIndex = 0;
            this.Butt.Text = "Srovnat";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // NumUD1
            // 
            this.NumUD1.Location = new System.Drawing.Point(12, 27);
            this.NumUD1.Name = "NumUD1";
            this.NumUD1.Size = new System.Drawing.Size(120, 23);
            this.NumUD1.TabIndex = 1;
            // 
            // NumUD2
            // 
            this.NumUD2.Location = new System.Drawing.Point(138, 27);
            this.NumUD2.Name = "NumUD2";
            this.NumUD2.Size = new System.Drawing.Size(120, 23);
            this.NumUD2.TabIndex = 2;
            // 
            // NumUD3
            // 
            this.NumUD3.Location = new System.Drawing.Point(264, 27);
            this.NumUD3.Name = "NumUD3";
            this.NumUD3.Size = new System.Drawing.Size(120, 23);
            this.NumUD3.TabIndex = 3;
            // 
            // RadButVze
            // 
            this.RadButVze.AutoSize = true;
            this.RadButVze.Checked = true;
            this.RadButVze.Location = new System.Drawing.Point(138, 67);
            this.RadButVze.Name = "RadButVze";
            this.RadButVze.Size = new System.Drawing.Size(79, 19);
            this.RadButVze.TabIndex = 4;
            this.RadButVze.TabStop = true;
            this.RadButVze.Text = "Vzestupně";
            this.RadButVze.UseVisualStyleBackColor = true;
            // 
            // RadButSes
            // 
            this.RadButSes.AutoSize = true;
            this.RadButSes.Location = new System.Drawing.Point(264, 65);
            this.RadButSes.Name = "RadButSes";
            this.RadButSes.Size = new System.Drawing.Size(73, 19);
            this.RadButSes.TabIndex = 5;
            this.RadButSes.Text = "Sestupně";
            this.RadButSes.UseVisualStyleBackColor = true;
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOut.Location = new System.Drawing.Point(12, 115);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(372, 32);
            this.LblOut.TabIndex = 6;
            this.LblOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCislo1
            // 
            this.LblCislo1.AutoSize = true;
            this.LblCislo1.Location = new System.Drawing.Point(12, 9);
            this.LblCislo1.Name = "LblCislo1";
            this.LblCislo1.Size = new System.Drawing.Size(42, 15);
            this.LblCislo1.TabIndex = 7;
            this.LblCislo1.Text = "Číslo 1";
            // 
            // LblCislo2
            // 
            this.LblCislo2.AutoSize = true;
            this.LblCislo2.Location = new System.Drawing.Point(138, 9);
            this.LblCislo2.Name = "LblCislo2";
            this.LblCislo2.Size = new System.Drawing.Size(42, 15);
            this.LblCislo2.TabIndex = 8;
            this.LblCislo2.Text = "Číslo 2";
            // 
            // LblCislo3
            // 
            this.LblCislo3.AutoSize = true;
            this.LblCislo3.Location = new System.Drawing.Point(264, 9);
            this.LblCislo3.Name = "LblCislo3";
            this.LblCislo3.Size = new System.Drawing.Size(42, 15);
            this.LblCislo3.TabIndex = 9;
            this.LblCislo3.Text = "Číslo 3";
            // 
            // FormFunkce1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 169);
            this.Controls.Add(this.LblCislo3);
            this.Controls.Add(this.LblCislo2);
            this.Controls.Add(this.LblCislo1);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.RadButSes);
            this.Controls.Add(this.RadButVze);
            this.Controls.Add(this.NumUD3);
            this.Controls.Add(this.NumUD2);
            this.Controls.Add(this.NumUD1);
            this.Controls.Add(this.Butt);
            this.Name = "FormFunkce1";
            this.Text = "Seřazovač";
            ((System.ComponentModel.ISupportInitialize)(this.NumUD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Butt;
        private NumericUpDown NumUD1;
        private NumericUpDown NumUD2;
        private NumericUpDown NumUD3;
        private RadioButton RadButVze;
        private RadioButton RadButSes;
        private Label LblOut;
        private Label LblCislo1;
        private Label LblCislo2;
        private Label LblCislo3;
    }
}