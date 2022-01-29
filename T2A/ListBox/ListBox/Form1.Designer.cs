
namespace ListBox
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
            this.LboxDef = new System.Windows.Forms.ListBox();
            this.BFaze1 = new System.Windows.Forms.Button();
            this.TxtBoxCislo = new System.Windows.Forms.TextBox();
            this.BFaze2 = new System.Windows.Forms.Button();
            this.BFaze3 = new System.Windows.Forms.Button();
            this.BFaze4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxJmeno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxJmeno2 = new System.Windows.Forms.TextBox();
            this.CheckBsub = new System.Windows.Forms.CheckBox();
            this.LBoxSub = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LboxDef
            // 
            this.LboxDef.FormattingEnabled = true;
            this.LboxDef.ItemHeight = 15;
            this.LboxDef.Location = new System.Drawing.Point(634, 40);
            this.LboxDef.Name = "LboxDef";
            this.LboxDef.Size = new System.Drawing.Size(201, 484);
            this.LboxDef.TabIndex = 0;
            this.LboxDef.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BFaze1
            // 
            this.BFaze1.Location = new System.Drawing.Point(359, 40);
            this.BFaze1.Name = "BFaze1";
            this.BFaze1.Size = new System.Drawing.Size(161, 61);
            this.BFaze1.TabIndex = 1;
            this.BFaze1.Text = "Fáze 1";
            this.BFaze1.UseVisualStyleBackColor = true;
            this.BFaze1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBoxCislo
            // 
            this.TxtBoxCislo.Location = new System.Drawing.Point(359, 135);
            this.TxtBoxCislo.Name = "TxtBoxCislo";
            this.TxtBoxCislo.Size = new System.Drawing.Size(161, 23);
            this.TxtBoxCislo.TabIndex = 2;
            // 
            // BFaze2
            // 
            this.BFaze2.Location = new System.Drawing.Point(359, 173);
            this.BFaze2.Name = "BFaze2";
            this.BFaze2.Size = new System.Drawing.Size(161, 61);
            this.BFaze2.TabIndex = 3;
            this.BFaze2.Text = "Fáze 2";
            this.BFaze2.UseVisualStyleBackColor = true;
            this.BFaze2.Click += new System.EventHandler(this.Bfaze2_Click);
            // 
            // BFaze3
            // 
            this.BFaze3.Location = new System.Drawing.Point(359, 301);
            this.BFaze3.Name = "BFaze3";
            this.BFaze3.Size = new System.Drawing.Size(161, 61);
            this.BFaze3.TabIndex = 4;
            this.BFaze3.Text = "Fáze 3";
            this.BFaze3.UseVisualStyleBackColor = true;
            this.BFaze3.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BFaze4
            // 
            this.BFaze4.Location = new System.Drawing.Point(359, 462);
            this.BFaze4.Name = "BFaze4";
            this.BFaze4.Size = new System.Drawing.Size(161, 61);
            this.BFaze4.TabIndex = 5;
            this.BFaze4.Text = "Fáze 4";
            this.BFaze4.UseVisualStyleBackColor = true;
            this.BFaze4.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fáze 2: Zadej něco";
            // 
            // TxtBoxJmeno
            // 
            this.TxtBoxJmeno.Location = new System.Drawing.Point(359, 261);
            this.TxtBoxJmeno.Name = "TxtBoxJmeno";
            this.TxtBoxJmeno.Size = new System.Drawing.Size(161, 23);
            this.TxtBoxJmeno.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fáze 3: Jméno a příjmení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fáze 1: Random čísla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fáze 4: Předplatné";
            // 
            // TxtBoxJmeno2
            // 
            this.TxtBoxJmeno2.Location = new System.Drawing.Point(359, 385);
            this.TxtBoxJmeno2.Name = "TxtBoxJmeno2";
            this.TxtBoxJmeno2.Size = new System.Drawing.Size(161, 23);
            this.TxtBoxJmeno2.TabIndex = 10;
            // 
            // CheckBsub
            // 
            this.CheckBsub.AutoSize = true;
            this.CheckBsub.Location = new System.Drawing.Point(359, 427);
            this.CheckBsub.Name = "CheckBsub";
            this.CheckBsub.Size = new System.Drawing.Size(83, 19);
            this.CheckBsub.TabIndex = 12;
            this.CheckBsub.Text = "Předplatné";
            this.CheckBsub.UseVisualStyleBackColor = true;
            this.CheckBsub.CheckedChanged += new System.EventHandler(this.CheckBsub_CheckedChanged);
            // 
            // LBoxSub
            // 
            this.LBoxSub.FormattingEnabled = true;
            this.LBoxSub.ItemHeight = 15;
            this.LBoxSub.Location = new System.Drawing.Point(863, 40);
            this.LBoxSub.Name = "LBoxSub";
            this.LBoxSub.Size = new System.Drawing.Size(201, 484);
            this.LBoxSub.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 647);
            this.Controls.Add(this.LBoxSub);
            this.Controls.Add(this.CheckBsub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBoxJmeno2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxJmeno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BFaze4);
            this.Controls.Add(this.BFaze3);
            this.Controls.Add(this.BFaze2);
            this.Controls.Add(this.TxtBoxCislo);
            this.Controls.Add(this.BFaze1);
            this.Controls.Add(this.LboxDef);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LboxDef;
        private System.Windows.Forms.Button BFaze1;
        private System.Windows.Forms.TextBox TxtBoxCislo;
        private System.Windows.Forms.Button BFaze2;
        private System.Windows.Forms.Button BFaze3;
        private System.Windows.Forms.Button BFaze4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxJmeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBoxJmeno2;
        private System.Windows.Forms.CheckBox CheckBsub;
        private System.Windows.Forms.ListBox LBoxSub;
    }
}

