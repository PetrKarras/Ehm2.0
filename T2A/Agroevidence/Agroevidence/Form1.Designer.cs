namespace Agroevidence
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
            this.ButtSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtboxVYM = new System.Windows.Forms.TextBox();
            this.TxtboxNAZ = new System.Windows.Forms.TextBox();
            this.TxtboxPOZ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtZob = new System.Windows.Forms.Button();
            this.LblDatabaze = new System.Windows.Forms.Label();
            this.CmdCIN = new System.Windows.Forms.ComboBox();
            this.CmdJED = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtboxPro = new System.Windows.Forms.TextBox();
            this.TxtboxMno = new System.Windows.Forms.TextBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtSave
            // 
            this.ButtSave.Location = new System.Drawing.Point(269, 318);
            this.ButtSave.Name = "ButtSave";
            this.ButtSave.Size = new System.Drawing.Size(93, 51);
            this.ButtSave.TabIndex = 0;
            this.ButtSave.Text = "Uložit";
            this.ButtSave.UseVisualStyleBackColor = true;
            this.ButtSave.Click += new System.EventHandler(this.ButtSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Název";
            // 
            // TxtboxVYM
            // 
            this.TxtboxVYM.Location = new System.Drawing.Point(269, 73);
            this.TxtboxVYM.Name = "TxtboxVYM";
            this.TxtboxVYM.Size = new System.Drawing.Size(216, 23);
            this.TxtboxVYM.TabIndex = 2;
            // 
            // TxtboxNAZ
            // 
            this.TxtboxNAZ.Location = new System.Drawing.Point(269, 44);
            this.TxtboxNAZ.Name = "TxtboxNAZ";
            this.TxtboxNAZ.Size = new System.Drawing.Size(216, 23);
            this.TxtboxNAZ.TabIndex = 3;
            // 
            // TxtboxPOZ
            // 
            this.TxtboxPOZ.Location = new System.Drawing.Point(269, 226);
            this.TxtboxPOZ.Multiline = true;
            this.TxtboxPOZ.Name = "TxtboxPOZ";
            this.TxtboxPOZ.Size = new System.Drawing.Size(216, 67);
            this.TxtboxPOZ.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Výměra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Činnost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Poznámka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(244, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "AGROEVIDENCE";
            // 
            // ButtZob
            // 
            this.ButtZob.Location = new System.Drawing.Point(392, 318);
            this.ButtZob.Name = "ButtZob";
            this.ButtZob.Size = new System.Drawing.Size(93, 51);
            this.ButtZob.TabIndex = 10;
            this.ButtZob.Text = "Zobrazit";
            this.ButtZob.UseVisualStyleBackColor = true;
            this.ButtZob.Click += new System.EventHandler(this.ButtZob_Click);
            // 
            // LblDatabaze
            // 
            this.LblDatabaze.AutoSize = true;
            this.LblDatabaze.Location = new System.Drawing.Point(592, 44);
            this.LblDatabaze.Name = "LblDatabaze";
            this.LblDatabaze.Size = new System.Drawing.Size(93, 15);
            this.LblDatabaze.TabIndex = 11;
            this.LblDatabaze.Text = "pseudodatabáze";
            // 
            // CmdCIN
            // 
            this.CmdCIN.FormattingEnabled = true;
            this.CmdCIN.Items.AddRange(new object[] {
            "HNOJENÍ",
            " SETÍ",
            " KYPŘENÍ",
            "ORBA"});
            this.CmdCIN.Location = new System.Drawing.Point(269, 102);
            this.CmdCIN.Name = "CmdCIN";
            this.CmdCIN.Size = new System.Drawing.Size(216, 23);
            this.CmdCIN.TabIndex = 12;
            // 
            // CmdJED
            // 
            this.CmdJED.AutoCompleteCustomSource.AddRange(new string[] {
            "litr",
            "kilogram",
            "tuna"});
            this.CmdJED.FormattingEnabled = true;
            this.CmdJED.Items.AddRange(new object[] {
            "litr",
            "kilogram",
            "tuna"});
            this.CmdJED.Location = new System.Drawing.Point(269, 197);
            this.CmdJED.Name = "CmdJED";
            this.CmdJED.Size = new System.Drawing.Size(216, 23);
            this.CmdJED.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Jednotky";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Množství";
            // 
            // TxtboxPro
            // 
            this.TxtboxPro.Location = new System.Drawing.Point(269, 139);
            this.TxtboxPro.Name = "TxtboxPro";
            this.TxtboxPro.Size = new System.Drawing.Size(216, 23);
            this.TxtboxPro.TabIndex = 15;
            // 
            // TxtboxMno
            // 
            this.TxtboxMno.Location = new System.Drawing.Point(269, 168);
            this.TxtboxMno.Name = "TxtboxMno";
            this.TxtboxMno.Size = new System.Drawing.Size(216, 23);
            this.TxtboxMno.TabIndex = 14;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(199, 142);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(63, 15);
            this.lbl8.TabIndex = 13;
            this.lbl8.Text = "Prostředek";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(491, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 30);
            this.label8.TabIndex = 19;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(491, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(491, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 30);
            this.label10.TabIndex = 21;
            this.label10.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmdJED);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtboxPro);
            this.Controls.Add(this.TxtboxMno);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.CmdCIN);
            this.Controls.Add(this.LblDatabaze);
            this.Controls.Add(this.ButtZob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtboxPOZ);
            this.Controls.Add(this.TxtboxNAZ);
            this.Controls.Add(this.TxtboxVYM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtSave;
        private Label label1;
        private TextBox TxtboxVYM;
        private TextBox TxtboxNAZ;
        private TextBox TxtboxPOZ;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button ButtZob;
        private Label LblDatabaze;
        private ComboBox CmdCIN;
        private ComboBox CmdJED;
        private Label label6;
        private Label label7;
        private TextBox TxtboxPro;
        private TextBox TxtboxMno;
        private Label lbl8;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}