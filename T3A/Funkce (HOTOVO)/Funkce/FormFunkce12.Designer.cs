﻿namespace Funkce
{
    partial class FormFunkce12
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
            this.LblCislo3 = new System.Windows.Forms.Label();
            this.LblCislo2 = new System.Windows.Forms.Label();
            this.LblCislo1 = new System.Windows.Forms.Label();
            this.NumUD3 = new System.Windows.Forms.NumericUpDown();
            this.NumUD2 = new System.Windows.Forms.NumericUpDown();
            this.NumUD1 = new System.Windows.Forms.NumericUpDown();
            this.Butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCislo3
            // 
            this.LblCislo3.AutoSize = true;
            this.LblCislo3.Location = new System.Drawing.Point(264, 9);
            this.LblCislo3.Name = "LblCislo3";
            this.LblCislo3.Size = new System.Drawing.Size(49, 15);
            this.LblCislo3.TabIndex = 19;
            this.LblCislo3.Text = "Strana c";
            // 
            // LblCislo2
            // 
            this.LblCislo2.AutoSize = true;
            this.LblCislo2.Location = new System.Drawing.Point(138, 9);
            this.LblCislo2.Name = "LblCislo2";
            this.LblCislo2.Size = new System.Drawing.Size(50, 15);
            this.LblCislo2.TabIndex = 18;
            this.LblCislo2.Text = "Strana b";
            // 
            // LblCislo1
            // 
            this.LblCislo1.AutoSize = true;
            this.LblCislo1.Location = new System.Drawing.Point(12, 9);
            this.LblCislo1.Name = "LblCislo1";
            this.LblCislo1.Size = new System.Drawing.Size(49, 15);
            this.LblCislo1.TabIndex = 17;
            this.LblCislo1.Text = "Strana a";
            // 
            // NumUD3
            // 
            this.NumUD3.Location = new System.Drawing.Point(264, 27);
            this.NumUD3.Name = "NumUD3";
            this.NumUD3.Size = new System.Drawing.Size(120, 23);
            this.NumUD3.TabIndex = 13;
            // 
            // NumUD2
            // 
            this.NumUD2.Location = new System.Drawing.Point(138, 27);
            this.NumUD2.Name = "NumUD2";
            this.NumUD2.Size = new System.Drawing.Size(120, 23);
            this.NumUD2.TabIndex = 12;
            // 
            // NumUD1
            // 
            this.NumUD1.Location = new System.Drawing.Point(12, 27);
            this.NumUD1.Name = "NumUD1";
            this.NumUD1.Size = new System.Drawing.Size(120, 23);
            this.NumUD1.TabIndex = 11;
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(12, 65);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(372, 64);
            this.Butt.TabIndex = 10;
            this.Butt.Text = "Existuje?";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // FormFunkce12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 139);
            this.Controls.Add(this.LblCislo3);
            this.Controls.Add(this.LblCislo2);
            this.Controls.Add(this.LblCislo1);
            this.Controls.Add(this.NumUD3);
            this.Controls.Add(this.NumUD2);
            this.Controls.Add(this.NumUD1);
            this.Controls.Add(this.Butt);
            this.Name = "FormFunkce12";
            this.Text = "Sestrojovač trojůhelníků";
            ((System.ComponentModel.ISupportInitialize)(this.NumUD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblCislo3;
        private Label LblCislo2;
        private Label LblCislo1;
        private NumericUpDown NumUD3;
        private NumericUpDown NumUD2;
        private NumericUpDown NumUD1;
        private Button Butt;
    }
}