
namespace Opakovaní_pole
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
            this.NumUD = new System.Windows.Forms.NumericUpDown();
            this.LblPole = new System.Windows.Forms.Label();
            this.ButtPlus = new System.Windows.Forms.Button();
            this.ButtKrat = new System.Windows.Forms.Button();
            this.ButtMax = new System.Windows.Forms.Button();
            this.ButtMin = new System.Windows.Forms.Button();
            this.ButtGen = new System.Windows.Forms.Button();
            this.LblOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // NumUD
            // 
            this.NumUD.Location = new System.Drawing.Point(12, 17);
            this.NumUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumUD.Name = "NumUD";
            this.NumUD.Size = new System.Drawing.Size(75, 23);
            this.NumUD.TabIndex = 0;
            // 
            // LblPole
            // 
            this.LblPole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPole.Location = new System.Drawing.Point(12, 63);
            this.LblPole.Name = "LblPole";
            this.LblPole.Size = new System.Drawing.Size(174, 18);
            this.LblPole.TabIndex = 2;
            // 
            // ButtPlus
            // 
            this.ButtPlus.Location = new System.Drawing.Point(12, 107);
            this.ButtPlus.Name = "ButtPlus";
            this.ButtPlus.Size = new System.Drawing.Size(75, 23);
            this.ButtPlus.TabIndex = 3;
            this.ButtPlus.Text = "+";
            this.ButtPlus.UseVisualStyleBackColor = true;
            this.ButtPlus.Click += new System.EventHandler(this.ButtPlus_Click);
            // 
            // ButtKrat
            // 
            this.ButtKrat.Location = new System.Drawing.Point(111, 107);
            this.ButtKrat.Name = "ButtKrat";
            this.ButtKrat.Size = new System.Drawing.Size(75, 23);
            this.ButtKrat.TabIndex = 4;
            this.ButtKrat.Text = "*";
            this.ButtKrat.UseVisualStyleBackColor = true;
            this.ButtKrat.Click += new System.EventHandler(this.ButtKrat_Click);
            // 
            // ButtMax
            // 
            this.ButtMax.Location = new System.Drawing.Point(12, 150);
            this.ButtMax.Name = "ButtMax";
            this.ButtMax.Size = new System.Drawing.Size(75, 23);
            this.ButtMax.TabIndex = 5;
            this.ButtMax.Text = "Max";
            this.ButtMax.UseVisualStyleBackColor = true;
            this.ButtMax.Click += new System.EventHandler(this.ButtMax_Click);
            // 
            // ButtMin
            // 
            this.ButtMin.Location = new System.Drawing.Point(111, 150);
            this.ButtMin.Name = "ButtMin";
            this.ButtMin.Size = new System.Drawing.Size(75, 23);
            this.ButtMin.TabIndex = 6;
            this.ButtMin.Text = "Minimum";
            this.ButtMin.UseVisualStyleBackColor = true;
            this.ButtMin.Click += new System.EventHandler(this.ButtMin_Click);
            // 
            // ButtGen
            // 
            this.ButtGen.Location = new System.Drawing.Point(111, 17);
            this.ButtGen.Name = "ButtGen";
            this.ButtGen.Size = new System.Drawing.Size(75, 23);
            this.ButtGen.TabIndex = 8;
            this.ButtGen.Text = "Generovat";
            this.ButtGen.UseVisualStyleBackColor = true;
            this.ButtGen.Click += new System.EventHandler(this.ButtGen_Click);
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Location = new System.Drawing.Point(12, 187);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(174, 18);
            this.LblOut.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.ButtGen);
            this.Controls.Add(this.ButtMin);
            this.Controls.Add(this.ButtMax);
            this.Controls.Add(this.ButtKrat);
            this.Controls.Add(this.ButtPlus);
            this.Controls.Add(this.LblPole);
            this.Controls.Add(this.NumUD);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumUD;
        private System.Windows.Forms.Label LblPole;
        private System.Windows.Forms.Button ButtPlus;
        private System.Windows.Forms.Button ButtKrat;
        private System.Windows.Forms.Button ButtMax;
        private System.Windows.Forms.Button ButtMin;
        private System.Windows.Forms.Button ButtGen;
        private System.Windows.Forms.Label LblOut;
    }
}

