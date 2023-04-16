namespace Funkce
{
    partial class FormFunkce7
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
            this.LblCislo4 = new System.Windows.Forms.Label();
            this.NumUP4 = new System.Windows.Forms.NumericUpDown();
            this.LblCislo3 = new System.Windows.Forms.Label();
            this.LblCislo2 = new System.Windows.Forms.Label();
            this.LblCislo1 = new System.Windows.Forms.Label();
            this.LblOut = new System.Windows.Forms.Label();
            this.NumUD3 = new System.Windows.Forms.NumericUpDown();
            this.NumUD2 = new System.Windows.Forms.NumericUpDown();
            this.NumUD1 = new System.Windows.Forms.NumericUpDown();
            this.Butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCislo4
            // 
            this.LblCislo4.AutoSize = true;
            this.LblCislo4.Location = new System.Drawing.Point(138, 53);
            this.LblCislo4.Name = "LblCislo4";
            this.LblCislo4.Size = new System.Drawing.Size(42, 15);
            this.LblCislo4.TabIndex = 31;
            this.LblCislo4.Text = "Číslo 4";
            // 
            // NumUP4
            // 
            this.NumUP4.Location = new System.Drawing.Point(138, 71);
            this.NumUP4.Name = "NumUP4";
            this.NumUP4.Size = new System.Drawing.Size(120, 23);
            this.NumUP4.TabIndex = 30;
            // 
            // LblCislo3
            // 
            this.LblCislo3.AutoSize = true;
            this.LblCislo3.Location = new System.Drawing.Point(12, 53);
            this.LblCislo3.Name = "LblCislo3";
            this.LblCislo3.Size = new System.Drawing.Size(42, 15);
            this.LblCislo3.TabIndex = 29;
            this.LblCislo3.Text = "Číslo 3";
            // 
            // LblCislo2
            // 
            this.LblCislo2.AutoSize = true;
            this.LblCislo2.Location = new System.Drawing.Point(138, 9);
            this.LblCislo2.Name = "LblCislo2";
            this.LblCislo2.Size = new System.Drawing.Size(42, 15);
            this.LblCislo2.TabIndex = 28;
            this.LblCislo2.Text = "Číslo 2";
            // 
            // LblCislo1
            // 
            this.LblCislo1.AutoSize = true;
            this.LblCislo1.Location = new System.Drawing.Point(12, 9);
            this.LblCislo1.Name = "LblCislo1";
            this.LblCislo1.Size = new System.Drawing.Size(42, 15);
            this.LblCislo1.TabIndex = 27;
            this.LblCislo1.Text = "Číslo 1";
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOut.Location = new System.Drawing.Point(12, 149);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(246, 32);
            this.LblOut.TabIndex = 26;
            this.LblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumUD3
            // 
            this.NumUD3.Location = new System.Drawing.Point(12, 71);
            this.NumUD3.Name = "NumUD3";
            this.NumUD3.Size = new System.Drawing.Size(120, 23);
            this.NumUD3.TabIndex = 25;
            // 
            // NumUD2
            // 
            this.NumUD2.BackColor = System.Drawing.Color.White;
            this.NumUD2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NumUD2.Location = new System.Drawing.Point(138, 27);
            this.NumUD2.Name = "NumUD2";
            this.NumUD2.Size = new System.Drawing.Size(120, 23);
            this.NumUD2.TabIndex = 24;
            // 
            // NumUD1
            // 
            this.NumUD1.Location = new System.Drawing.Point(12, 27);
            this.NumUD1.Name = "NumUD1";
            this.NumUD1.Size = new System.Drawing.Size(120, 23);
            this.NumUD1.TabIndex = 23;
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(12, 100);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(246, 35);
            this.Butt.TabIndex = 22;
            this.Butt.Text = "Průměr";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // FormFunkce7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 210);
            this.Controls.Add(this.LblCislo4);
            this.Controls.Add(this.NumUP4);
            this.Controls.Add(this.LblCislo3);
            this.Controls.Add(this.LblCislo2);
            this.Controls.Add(this.LblCislo1);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.NumUD3);
            this.Controls.Add(this.NumUD2);
            this.Controls.Add(this.NumUD1);
            this.Controls.Add(this.Butt);
            this.Name = "FormFunkce7";
            this.Text = "Průmšrovač 2";
            ((System.ComponentModel.ISupportInitialize)(this.NumUP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblCislo4;
        private NumericUpDown NumUP4;
        private Label LblCislo3;
        private Label LblCislo2;
        private Label LblCislo1;
        private Label LblOut;
        private NumericUpDown NumUD3;
        private NumericUpDown NumUD2;
        private NumericUpDown NumUD1;
        private Button Butt;
    }
}