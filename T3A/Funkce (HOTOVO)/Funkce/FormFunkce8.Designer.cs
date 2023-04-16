namespace Funkce
{
    partial class FormFunkce8
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
            this.LblCislo2 = new System.Windows.Forms.Label();
            this.LblCislo1 = new System.Windows.Forms.Label();
            this.NumUD2 = new System.Windows.Forms.NumericUpDown();
            this.NumUD1 = new System.Windows.Forms.NumericUpDown();
            this.Butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCislo2
            // 
            this.LblCislo2.AutoSize = true;
            this.LblCislo2.Location = new System.Drawing.Point(138, 9);
            this.LblCislo2.Name = "LblCislo2";
            this.LblCislo2.Size = new System.Drawing.Size(42, 15);
            this.LblCislo2.TabIndex = 18;
            this.LblCislo2.Text = "Číslo 2";
            // 
            // LblCislo1
            // 
            this.LblCislo1.AutoSize = true;
            this.LblCislo1.Location = new System.Drawing.Point(12, 9);
            this.LblCislo1.Name = "LblCislo1";
            this.LblCislo1.Size = new System.Drawing.Size(42, 15);
            this.LblCislo1.TabIndex = 17;
            this.LblCislo1.Text = "Číslo 1";
            // 
            // NumUD2
            // 
            this.NumUD2.Location = new System.Drawing.Point(138, 27);
            this.NumUD2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUD2.Name = "NumUD2";
            this.NumUD2.Size = new System.Drawing.Size(120, 23);
            this.NumUD2.TabIndex = 12;
            this.NumUD2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumUD1
            // 
            this.NumUD1.Location = new System.Drawing.Point(12, 27);
            this.NumUD1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUD1.Name = "NumUD1";
            this.NumUD1.Size = new System.Drawing.Size(120, 23);
            this.NumUD1.TabIndex = 11;
            this.NumUD1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(12, 56);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(246, 33);
            this.Butt.TabIndex = 10;
            this.Butt.Text = "Dělit";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // FormFunkce8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 103);
            this.Controls.Add(this.LblCislo2);
            this.Controls.Add(this.LblCislo1);
            this.Controls.Add(this.NumUD2);
            this.Controls.Add(this.NumUD1);
            this.Controls.Add(this.Butt);
            this.Name = "FormFunkce8";
            this.Text = "Bez zbytkové dělení";
            ((System.ComponentModel.ISupportInitialize)(this.NumUD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblCislo2;
        private Label LblCislo1;
        private NumericUpDown NumUD2;
        private NumericUpDown NumUD1;
        private Button Butt;
    }
}