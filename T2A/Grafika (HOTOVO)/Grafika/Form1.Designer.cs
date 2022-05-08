namespace Grafika
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
            this.Panelos = new System.Windows.Forms.Panel();
            this.ChboxTRI = new System.Windows.Forms.CheckBox();
            this.ChboxSQ = new System.Windows.Forms.CheckBox();
            this.ChboxCIR = new System.Windows.Forms.CheckBox();
            this.Butt = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ButtCol = new System.Windows.Forms.Button();
            this.RADFull = new System.Windows.Forms.RadioButton();
            this.RADobr = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NUMupdown = new System.Windows.Forms.NumericUpDown();
            this.Tlouštka = new System.Windows.Forms.Label();
            this.CHboxRe = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // Panelos
            // 
            this.Panelos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panelos.Location = new System.Drawing.Point(3, 3);
            this.Panelos.Name = "Panelos";
            this.Panelos.Size = new System.Drawing.Size(687, 415);
            this.Panelos.TabIndex = 0;
            this.Panelos.Paint += new System.Windows.Forms.PaintEventHandler(this.Panelos_Paint);
            // 
            // ChboxTRI
            // 
            this.ChboxTRI.AutoSize = true;
            this.ChboxTRI.Location = new System.Drawing.Point(713, 293);
            this.ChboxTRI.Name = "ChboxTRI";
            this.ChboxTRI.Size = new System.Drawing.Size(84, 19);
            this.ChboxTRI.TabIndex = 1;
            this.ChboxTRI.Text = "Trojuhelník";
            this.ChboxTRI.UseVisualStyleBackColor = true;
            // 
            // ChboxSQ
            // 
            this.ChboxSQ.AutoSize = true;
            this.ChboxSQ.Location = new System.Drawing.Point(713, 318);
            this.ChboxSQ.Name = "ChboxSQ";
            this.ChboxSQ.Size = new System.Drawing.Size(66, 19);
            this.ChboxSQ.TabIndex = 2;
            this.ChboxSQ.Text = "Čtverec";
            this.ChboxSQ.UseVisualStyleBackColor = true;
            // 
            // ChboxCIR
            // 
            this.ChboxCIR.AutoSize = true;
            this.ChboxCIR.Location = new System.Drawing.Point(713, 343);
            this.ChboxCIR.Name = "ChboxCIR";
            this.ChboxCIR.Size = new System.Drawing.Size(51, 19);
            this.ChboxCIR.TabIndex = 3;
            this.ChboxCIR.Text = "Kruh";
            this.ChboxCIR.UseVisualStyleBackColor = true;
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(713, 389);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(75, 23);
            this.Butt.TabIndex = 4;
            this.Butt.Text = "Repeat";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // ButtCol
            // 
            this.ButtCol.Location = new System.Drawing.Point(713, 418);
            this.ButtCol.Name = "ButtCol";
            this.ButtCol.Size = new System.Drawing.Size(75, 23);
            this.ButtCol.TabIndex = 5;
            this.ButtCol.Text = "Barva";
            this.ButtCol.UseVisualStyleBackColor = true;
            this.ButtCol.Click += new System.EventHandler(this.ButtCol_Click);
            // 
            // RADFull
            // 
            this.RADFull.AutoSize = true;
            this.RADFull.Checked = true;
            this.RADFull.Location = new System.Drawing.Point(713, 25);
            this.RADFull.Name = "RADFull";
            this.RADFull.Size = new System.Drawing.Size(75, 19);
            this.RADFull.TabIndex = 6;
            this.RADFull.TabStop = true;
            this.RADFull.Text = "Vyplněno";
            this.RADFull.UseVisualStyleBackColor = true;
            // 
            // RADobr
            // 
            this.RADobr.AutoSize = true;
            this.RADobr.Location = new System.Drawing.Point(713, 50);
            this.RADobr.Name = "RADobr";
            this.RADobr.Size = new System.Drawing.Size(56, 19);
            this.RADobr.TabIndex = 7;
            this.RADobr.Text = "Obrys";
            this.RADobr.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Panelos);
            this.panel1.Location = new System.Drawing.Point(14, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 421);
            this.panel1.TabIndex = 1;
            // 
            // NUMupdown
            // 
            this.NUMupdown.Location = new System.Drawing.Point(710, 97);
            this.NUMupdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUMupdown.Name = "NUMupdown";
            this.NUMupdown.Size = new System.Drawing.Size(87, 23);
            this.NUMupdown.TabIndex = 8;
            this.NUMupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Tlouštka
            // 
            this.Tlouštka.AutoSize = true;
            this.Tlouštka.Location = new System.Drawing.Point(709, 75);
            this.Tlouštka.Name = "Tlouštka";
            this.Tlouštka.Size = new System.Drawing.Size(51, 15);
            this.Tlouštka.TabIndex = 9;
            this.Tlouštka.Text = "Tlouštka";
            // 
            // CHboxRe
            // 
            this.CHboxRe.AutoSize = true;
            this.CHboxRe.Location = new System.Drawing.Point(713, 268);
            this.CHboxRe.Name = "CHboxRe";
            this.CHboxRe.Size = new System.Drawing.Size(74, 19);
            this.CHboxRe.TabIndex = 10;
            this.CHboxRe.Text = "Obdelník";
            this.CHboxRe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.CHboxRe);
            this.Controls.Add(this.Tlouštka);
            this.Controls.Add(this.NUMupdown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RADobr);
            this.Controls.Add(this.RADFull);
            this.Controls.Add(this.ButtCol);
            this.Controls.Add(this.Butt);
            this.Controls.Add(this.ChboxCIR);
            this.Controls.Add(this.ChboxSQ);
            this.Controls.Add(this.ChboxTRI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUMupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel Panelos;
        private CheckBox ChboxTRI;
        private CheckBox ChboxSQ;
        private CheckBox ChboxCIR;
        private Button Butt;
        private ColorDialog colorDialog1;
        private Button ButtCol;
        private RadioButton RADFull;
        private RadioButton RADobr;
        private Panel panel1;
        private NumericUpDown NUMupdown;
        private Label Tlouštka;
        private CheckBox CHboxRe;
    }
}