
namespace Kladkostroj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtVyp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumPev = new System.Windows.Forms.NumericUpDown();
            this.NumVol = new System.Windows.Forms.NumericUpDown();
            this.LblOut = new System.Windows.Forms.Label();
            this.NumUDVaha = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumPev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDVaha)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtVyp
            // 
            this.ButtVyp.Location = new System.Drawing.Point(12, 105);
            this.ButtVyp.Name = "ButtVyp";
            this.ButtVyp.Size = new System.Drawing.Size(219, 52);
            this.ButtVyp.TabIndex = 0;
            this.ButtVyp.Text = "Vypočítej";
            this.ButtVyp.UseVisualStyleBackColor = true;
            this.ButtVyp.Click += new System.EventHandler(this.ButtVyp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Váha závaží (kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pevné kladky";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Volné kladky";
            // 
            // NumPev
            // 
            this.NumPev.DecimalPlaces = 2;
            this.NumPev.Location = new System.Drawing.Point(111, 47);
            this.NumPev.Name = "NumPev";
            this.NumPev.Size = new System.Drawing.Size(120, 23);
            this.NumPev.TabIndex = 7;
            // 
            // NumVol
            // 
            this.NumVol.DecimalPlaces = 2;
            this.NumVol.Location = new System.Drawing.Point(111, 76);
            this.NumVol.Name = "NumVol";
            this.NumVol.Size = new System.Drawing.Size(120, 23);
            this.NumVol.TabIndex = 8;
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOut.Location = new System.Drawing.Point(12, 173);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(219, 116);
            this.LblOut.TabIndex = 9;
            // 
            // NumUDVaha
            // 
            this.NumUDVaha.DecimalPlaces = 2;
            this.NumUDVaha.Location = new System.Drawing.Point(111, 14);
            this.NumUDVaha.Name = "NumUDVaha";
            this.NumUDVaha.Size = new System.Drawing.Size(120, 23);
            this.NumUDVaha.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 305);
            this.Controls.Add(this.NumUDVaha);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.NumVol);
            this.Controls.Add(this.NumPev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtVyp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumPev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDVaha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtVyp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumPev;
        private System.Windows.Forms.NumericUpDown NumVol;
        private System.Windows.Forms.Label LblOut;
        private System.Windows.Forms.NumericUpDown NumUDVaha;
    }
}

