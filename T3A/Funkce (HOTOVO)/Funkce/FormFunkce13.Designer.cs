namespace Funkce
{
    partial class FormFunkce13
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
            this.ButtAdd = new System.Windows.Forms.Button();
            this.ButHot = new System.Windows.Forms.Button();
            this.NumUDClen = new System.Windows.Forms.NumericUpDown();
            this.NumUDPole = new System.Windows.Forms.NumericUpDown();
            this.Butt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblOutClen = new System.Windows.Forms.Label();
            this.LblOutPole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDClen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPole)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtAdd
            // 
            this.ButtAdd.Enabled = false;
            this.ButtAdd.Location = new System.Drawing.Point(12, 94);
            this.ButtAdd.Name = "ButtAdd";
            this.ButtAdd.Size = new System.Drawing.Size(236, 23);
            this.ButtAdd.TabIndex = 15;
            this.ButtAdd.Text = "Přidat";
            this.ButtAdd.UseVisualStyleBackColor = true;
            this.ButtAdd.Click += new System.EventHandler(this.ButtAdd_Click);
            // 
            // ButHot
            // 
            this.ButHot.Location = new System.Drawing.Point(12, 36);
            this.ButHot.Name = "ButHot";
            this.ButHot.Size = new System.Drawing.Size(236, 23);
            this.ButHot.TabIndex = 14;
            this.ButHot.Text = "Potvrdit";
            this.ButHot.UseVisualStyleBackColor = true;
            this.ButHot.Click += new System.EventHandler(this.ButHot_Click);
            // 
            // NumUDClen
            // 
            this.NumUDClen.Location = new System.Drawing.Point(128, 65);
            this.NumUDClen.Name = "NumUDClen";
            this.NumUDClen.Size = new System.Drawing.Size(120, 23);
            this.NumUDClen.TabIndex = 13;
            // 
            // NumUDPole
            // 
            this.NumUDPole.Location = new System.Drawing.Point(128, 7);
            this.NumUDPole.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUDPole.Name = "NumUDPole";
            this.NumUDPole.Size = new System.Drawing.Size(120, 23);
            this.NumUDPole.TabIndex = 12;
            this.NumUDPole.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUDPole.DoubleClick += new System.EventHandler(this.ButHot_Click);
            // 
            // Butt
            // 
            this.Butt.Enabled = false;
            this.Butt.Location = new System.Drawing.Point(12, 153);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(236, 23);
            this.Butt.TabIndex = 11;
            this.Butt.Text = "Průměr";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Člen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Délka pole";
            // 
            // LblOutClen
            // 
            this.LblOutClen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOutClen.Location = new System.Drawing.Point(12, 120);
            this.LblOutClen.Name = "LblOutClen";
            this.LblOutClen.Size = new System.Drawing.Size(236, 30);
            this.LblOutClen.TabIndex = 16;
            // 
            // LblOutPole
            // 
            this.LblOutPole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOutPole.Location = new System.Drawing.Point(12, 179);
            this.LblOutPole.Name = "LblOutPole";
            this.LblOutPole.Size = new System.Drawing.Size(236, 38);
            this.LblOutPole.TabIndex = 17;
            this.LblOutPole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFunkce13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 228);
            this.Controls.Add(this.LblOutPole);
            this.Controls.Add(this.LblOutClen);
            this.Controls.Add(this.ButtAdd);
            this.Controls.Add(this.ButHot);
            this.Controls.Add(this.NumUDClen);
            this.Controls.Add(this.NumUDPole);
            this.Controls.Add(this.Butt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormFunkce13";
            this.Text = "Průměrovač";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDClen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtAdd;
        private Button ButHot;
        private NumericUpDown NumUDClen;
        private NumericUpDown NumUDPole;
        private Button Butt;
        private Label label2;
        private Label label1;
        private Label LblOutClen;
        private Label LblOutPole;
    }
}