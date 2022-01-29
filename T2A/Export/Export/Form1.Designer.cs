
namespace Export
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
            this.Radtxt = new System.Windows.Forms.RadioButton();
            this.Radcsv = new System.Windows.Forms.RadioButton();
            this.Radxml = new System.Windows.Forms.RadioButton();
            this.TxtBOxNazev = new System.Windows.Forms.TextBox();
            this.TxtBoxObsah = new System.Windows.Forms.TextBox();
            this.ButtLoad = new System.Windows.Forms.Button();
            this.ButtExp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Radtxt
            // 
            this.Radtxt.AutoSize = true;
            this.Radtxt.Location = new System.Drawing.Point(452, 117);
            this.Radtxt.Name = "Radtxt";
            this.Radtxt.Size = new System.Drawing.Size(42, 19);
            this.Radtxt.TabIndex = 0;
            this.Radtxt.TabStop = true;
            this.Radtxt.Text = ".txt";
            this.Radtxt.UseVisualStyleBackColor = true;
            // 
            // Radcsv
            // 
            this.Radcsv.AutoSize = true;
            this.Radcsv.Location = new System.Drawing.Point(452, 142);
            this.Radcsv.Name = "Radcsv";
            this.Radcsv.Size = new System.Drawing.Size(45, 19);
            this.Radcsv.TabIndex = 1;
            this.Radcsv.TabStop = true;
            this.Radcsv.Text = ".csv";
            this.Radcsv.UseVisualStyleBackColor = true;
            // 
            // Radxml
            // 
            this.Radxml.AutoSize = true;
            this.Radxml.Location = new System.Drawing.Point(452, 167);
            this.Radxml.Name = "Radxml";
            this.Radxml.Size = new System.Drawing.Size(48, 19);
            this.Radxml.TabIndex = 2;
            this.Radxml.TabStop = true;
            this.Radxml.Text = ".xml";
            this.Radxml.UseVisualStyleBackColor = true;
            // 
            // TxtBOxNazev
            // 
            this.TxtBOxNazev.Location = new System.Drawing.Point(316, 117);
            this.TxtBOxNazev.Name = "TxtBOxNazev";
            this.TxtBOxNazev.Size = new System.Drawing.Size(100, 23);
            this.TxtBOxNazev.TabIndex = 3;
            // 
            // TxtBoxObsah
            // 
            this.TxtBoxObsah.Location = new System.Drawing.Point(316, 167);
            this.TxtBoxObsah.Multiline = true;
            this.TxtBoxObsah.Name = "TxtBoxObsah";
            this.TxtBoxObsah.Size = new System.Drawing.Size(100, 194);
            this.TxtBoxObsah.TabIndex = 4;
            this.TxtBoxObsah.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ButtLoad
            // 
            this.ButtLoad.Location = new System.Drawing.Point(452, 215);
            this.ButtLoad.Name = "ButtLoad";
            this.ButtLoad.Size = new System.Drawing.Size(75, 23);
            this.ButtLoad.TabIndex = 5;
            this.ButtLoad.Text = "Load";
            this.ButtLoad.UseVisualStyleBackColor = true;
            this.ButtLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtExp
            // 
            this.ButtExp.Location = new System.Drawing.Point(452, 255);
            this.ButtExp.Name = "ButtExp";
            this.ButtExp.Size = new System.Drawing.Size(75, 23);
            this.ButtExp.TabIndex = 6;
            this.ButtExp.Text = "Export";
            this.ButtExp.UseVisualStyleBackColor = true;
            this.ButtExp.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Název souboru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obsah souboru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Typ souboru";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtExp);
            this.Controls.Add(this.ButtLoad);
            this.Controls.Add(this.TxtBoxObsah);
            this.Controls.Add(this.TxtBOxNazev);
            this.Controls.Add(this.Radxml);
            this.Controls.Add(this.Radcsv);
            this.Controls.Add(this.Radtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Radtxt;
        private System.Windows.Forms.RadioButton Radcsv;
        private System.Windows.Forms.RadioButton Radxml;
        private System.Windows.Forms.TextBox TxtBOxNazev;
        private System.Windows.Forms.TextBox TxtBoxObsah;
        private System.Windows.Forms.Button ButtLoad;
        private System.Windows.Forms.Button ButtExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

