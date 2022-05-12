namespace Nákupní_košík
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
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.TxtBoxCena = new System.Windows.Forms.TextBox();
            this.TxtBoxSklad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblCena = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblOut = new System.Windows.Forms.Label();
            this.CBoxTyp = new System.Windows.Forms.ComboBox();
            this.CBoxPref = new System.Windows.Forms.ComboBox();
            this.ButtAdd = new System.Windows.Forms.Button();
            this.ButtRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(104, 100);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(100, 23);
            this.TxtBoxName.TabIndex = 0;
            // 
            // TxtBoxCena
            // 
            this.TxtBoxCena.Location = new System.Drawing.Point(104, 129);
            this.TxtBoxCena.Name = "TxtBoxCena";
            this.TxtBoxCena.Size = new System.Drawing.Size(100, 23);
            this.TxtBoxCena.TabIndex = 1;
            // 
            // TxtBoxSklad
            // 
            this.TxtBoxSklad.Location = new System.Drawing.Point(104, 245);
            this.TxtBoxSklad.Name = "TxtBoxSklad";
            this.TxtBoxSklad.Size = new System.Drawing.Size(100, 23);
            this.TxtBoxSklad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Název";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Určeno pro :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Skladování";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Typ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "cena";
            // 
            // LblCena
            // 
            this.LblCena.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblCena.Location = new System.Drawing.Point(104, 286);
            this.LblCena.Name = "LblCena";
            this.LblCena.Size = new System.Drawing.Size(100, 21);
            this.LblCena.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(144, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 40);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nákupní košík";
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Location = new System.Drawing.Point(218, 100);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(267, 225);
            this.LblOut.TabIndex = 13;
            // 
            // CBoxTyp
            // 
            this.CBoxTyp.FormattingEnabled = true;
            this.CBoxTyp.Items.AddRange(new object[] {
            "Drogerie",
            "Potravina",
            "IDK"});
            this.CBoxTyp.Location = new System.Drawing.Point(104, 165);
            this.CBoxTyp.Name = "CBoxTyp";
            this.CBoxTyp.Size = new System.Drawing.Size(100, 23);
            this.CBoxTyp.TabIndex = 14;
            // 
            // CBoxPref
            // 
            this.CBoxPref.FormattingEnabled = true;
            this.CBoxPref.Items.AddRange(new object[] {
            "Muže",
            "Ženy",
            "Děti",
            "Všechny"});
            this.CBoxPref.Location = new System.Drawing.Point(104, 208);
            this.CBoxPref.Name = "CBoxPref";
            this.CBoxPref.Size = new System.Drawing.Size(100, 23);
            this.CBoxPref.TabIndex = 15;
            // 
            // ButtAdd
            // 
            this.ButtAdd.Location = new System.Drawing.Point(34, 337);
            this.ButtAdd.Name = "ButtAdd";
            this.ButtAdd.Size = new System.Drawing.Size(205, 23);
            this.ButtAdd.TabIndex = 16;
            this.ButtAdd.Text = "Přidej";
            this.ButtAdd.UseVisualStyleBackColor = true;
            this.ButtAdd.Click += new System.EventHandler(this.ButtAdd_Click);
            // 
            // ButtRes
            // 
            this.ButtRes.Location = new System.Drawing.Point(265, 337);
            this.ButtRes.Name = "ButtRes";
            this.ButtRes.Size = new System.Drawing.Size(220, 23);
            this.ButtRes.TabIndex = 17;
            this.ButtRes.Text = "Reset";
            this.ButtRes.UseVisualStyleBackColor = true;
            this.ButtRes.Click += new System.EventHandler(this.ButtRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtRes);
            this.Controls.Add(this.ButtAdd);
            this.Controls.Add(this.CBoxPref);
            this.Controls.Add(this.CBoxTyp);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblCena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxSklad);
            this.Controls.Add(this.TxtBoxCena);
            this.Controls.Add(this.TxtBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtBoxName;
        private TextBox TxtBoxCena;
        private TextBox TxtBoxSklad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label LblCena;
        private Label label9;
        private Label LblOut;
        private ComboBox CBoxTyp;
        private ComboBox CBoxPref;
        private Button ButtAdd;
        private Button ButtRes;
    }
}