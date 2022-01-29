
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
            this.TxtBoxVaha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumPev = new System.Windows.Forms.NumericUpDown();
            this.NumVol = new System.Windows.Forms.NumericUpDown();
            this.LblOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumPev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVol)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtVyp
            // 
            this.ButtVyp.Location = new System.Drawing.Point(338, 136);
            this.ButtVyp.Name = "ButtVyp";
            this.ButtVyp.Size = new System.Drawing.Size(75, 23);
            this.ButtVyp.TabIndex = 0;
            this.ButtVyp.Text = "Vypočítej";
            this.ButtVyp.UseVisualStyleBackColor = true;
            this.ButtVyp.Click += new System.EventHandler(this.ButtVyp_Click);
            // 
            // TxtBoxVaha
            // 
            this.TxtBoxVaha.Location = new System.Drawing.Point(192, 104);
            this.TxtBoxVaha.Name = "TxtBoxVaha";
            this.TxtBoxVaha.Size = new System.Drawing.Size(120, 23);
            this.TxtBoxVaha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Váha závaží (kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pevné kladky";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Volné kladky";
            // 
            // NumPev
            // 
            this.NumPev.Location = new System.Drawing.Point(192, 136);
            this.NumPev.Name = "NumPev";
            this.NumPev.Size = new System.Drawing.Size(120, 23);
            this.NumPev.TabIndex = 7;
            // 
            // NumVol
            // 
            this.NumVol.Location = new System.Drawing.Point(192, 165);
            this.NumVol.Name = "NumVol";
            this.NumVol.Size = new System.Drawing.Size(120, 23);
            this.NumVol.TabIndex = 8;
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOut.Location = new System.Drawing.Point(433, 104);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(171, 84);
            this.LblOut.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.NumVol);
            this.Controls.Add(this.NumPev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxVaha);
            this.Controls.Add(this.ButtVyp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumPev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtVyp;
        private System.Windows.Forms.TextBox TxtBoxVaha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumPev;
        private System.Windows.Forms.NumericUpDown NumVol;
        private System.Windows.Forms.Label LblOut;
    }
}

