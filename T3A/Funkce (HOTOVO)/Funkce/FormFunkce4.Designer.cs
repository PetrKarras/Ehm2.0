namespace Funkce
{
    partial class FormFunkce4
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
            this.LblOutPole = new System.Windows.Forms.Label();
            this.LblOutClen = new System.Windows.Forms.Label();
            this.ButtAdd = new System.Windows.Forms.Button();
            this.ButHot = new System.Windows.Forms.Button();
            this.NumUDClen = new System.Windows.Forms.NumericUpDown();
            this.NumUDPole = new System.Windows.Forms.NumericUpDown();
            this.Butt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDClen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPole)).BeginInit();
            this.SuspendLayout();
            // 
            // LblOutPole
            // 
            this.LblOutPole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOutPole.Location = new System.Drawing.Point(17, 184);
            this.LblOutPole.Name = "LblOutPole";
            this.LblOutPole.Size = new System.Drawing.Size(236, 38);
            this.LblOutPole.TabIndex = 26;
            this.LblOutPole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblOutClen
            // 
            this.LblOutClen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOutClen.Location = new System.Drawing.Point(17, 125);
            this.LblOutClen.Name = "LblOutClen";
            this.LblOutClen.Size = new System.Drawing.Size(236, 30);
            this.LblOutClen.TabIndex = 25;
            // 
            // ButtAdd
            // 
            this.ButtAdd.Enabled = false;
            this.ButtAdd.Location = new System.Drawing.Point(17, 99);
            this.ButtAdd.Name = "ButtAdd";
            this.ButtAdd.Size = new System.Drawing.Size(236, 23);
            this.ButtAdd.TabIndex = 24;
            this.ButtAdd.Text = "Přidat";
            this.ButtAdd.UseVisualStyleBackColor = true;
            this.ButtAdd.Click += new System.EventHandler(this.ButtAdd_Click);
            // 
            // ButHot
            // 
            this.ButHot.Location = new System.Drawing.Point(17, 41);
            this.ButHot.Name = "ButHot";
            this.ButHot.Size = new System.Drawing.Size(236, 23);
            this.ButHot.TabIndex = 23;
            this.ButHot.Text = "Potvrdit";
            this.ButHot.UseVisualStyleBackColor = true;
            this.ButHot.Click += new System.EventHandler(this.ButtHot_Click);
            // 
            // NumUDClen
            // 
            this.NumUDClen.Location = new System.Drawing.Point(133, 70);
            this.NumUDClen.Name = "NumUDClen";
            this.NumUDClen.Size = new System.Drawing.Size(120, 23);
            this.NumUDClen.TabIndex = 22;
            // 
            // NumUDPole
            // 
            this.NumUDPole.Location = new System.Drawing.Point(133, 12);
            this.NumUDPole.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUDPole.Name = "NumUDPole";
            this.NumUDPole.Size = new System.Drawing.Size(120, 23);
            this.NumUDPole.TabIndex = 21;
            this.NumUDPole.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Butt
            // 
            this.Butt.Enabled = false;
            this.Butt.Location = new System.Drawing.Point(17, 158);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(236, 23);
            this.Butt.TabIndex = 20;
            this.Butt.Text = "-1";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.ButtMinus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Člen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Délka pole";
            // 
            // FormFunkce4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 243);
            this.Controls.Add(this.LblOutPole);
            this.Controls.Add(this.LblOutClen);
            this.Controls.Add(this.ButtAdd);
            this.Controls.Add(this.ButHot);
            this.Controls.Add(this.NumUDClen);
            this.Controls.Add(this.NumUDPole);
            this.Controls.Add(this.Butt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "FormFunkce4";
            this.Text = "Odčítač ";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDClen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LblOutPole;
        private Label LblOutClen;
        private Button ButtAdd;
        private Button ButHot;
        private NumericUpDown NumUDClen;
        private NumericUpDown NumUDPole;
        private Button Butt;
        private Label label3;
        private Label label4;
    }
}