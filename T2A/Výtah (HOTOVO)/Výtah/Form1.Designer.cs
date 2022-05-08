
namespace Výtah
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
            this.TxtBoxIN = new System.Windows.Forms.TextBox();
            this.ButtADD = new System.Windows.Forms.Button();
            this.ButtRess = new System.Windows.Forms.Button();
            this.LblVaha = new System.Windows.Forms.Label();
            this.LblPocet = new System.Windows.Forms.Label();
            this.COMBgen = new System.Windows.Forms.ComboBox();
            this.LblFullVaha = new System.Windows.Forms.Label();
            this.PanBack = new System.Windows.Forms.Panel();
            this.PanPaint = new System.Windows.Forms.Panel();
            this.ListOut = new System.Windows.Forms.ListBox();
            this.PanBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBoxIN
            // 
            this.TxtBoxIN.Location = new System.Drawing.Point(247, 151);
            this.TxtBoxIN.Name = "TxtBoxIN";
            this.TxtBoxIN.Size = new System.Drawing.Size(100, 23);
            this.TxtBoxIN.TabIndex = 1;
            this.TxtBoxIN.Text = "0";
            // 
            // ButtADD
            // 
            this.ButtADD.Location = new System.Drawing.Point(247, 279);
            this.ButtADD.Name = "ButtADD";
            this.ButtADD.Size = new System.Drawing.Size(100, 23);
            this.ButtADD.TabIndex = 2;
            this.ButtADD.Text = "Přidej";
            this.ButtADD.UseVisualStyleBackColor = true;
            this.ButtADD.Click += new System.EventHandler(this.ButtADD_Click);
            // 
            // ButtRess
            // 
            this.ButtRess.Location = new System.Drawing.Point(247, 308);
            this.ButtRess.Name = "ButtRess";
            this.ButtRess.Size = new System.Drawing.Size(100, 23);
            this.ButtRess.TabIndex = 3;
            this.ButtRess.Text = "Reset";
            this.ButtRess.UseVisualStyleBackColor = true;
            this.ButtRess.Click += new System.EventHandler(this.ButtRess_Click);
            // 
            // LblVaha
            // 
            this.LblVaha.AutoSize = true;
            this.LblVaha.BackColor = System.Drawing.Color.Lime;
            this.LblVaha.Location = new System.Drawing.Point(247, 122);
            this.LblVaha.Name = "LblVaha";
            this.LblVaha.Size = new System.Drawing.Size(32, 15);
            this.LblVaha.TabIndex = 4;
            this.LblVaha.Text = "Váha";
            // 
            // LblPocet
            // 
            this.LblPocet.AutoSize = true;
            this.LblPocet.BackColor = System.Drawing.Color.Lime;
            this.LblPocet.Location = new System.Drawing.Point(310, 122);
            this.LblPocet.Name = "LblPocet";
            this.LblPocet.Size = new System.Drawing.Size(37, 15);
            this.LblPocet.TabIndex = 5;
            this.LblPocet.Text = "Počet";
            // 
            // COMBgen
            // 
            this.COMBgen.BackColor = System.Drawing.Color.White;
            this.COMBgen.FormattingEnabled = true;
            this.COMBgen.Items.AddRange(new object[] {
            "Žena",
            "Muž "});
            this.COMBgen.Location = new System.Drawing.Point(247, 180);
            this.COMBgen.Name = "COMBgen";
            this.COMBgen.Size = new System.Drawing.Size(100, 23);
            this.COMBgen.TabIndex = 6;
            this.COMBgen.Text = "Žena";
            // 
            // LblFullVaha
            // 
            this.LblFullVaha.BackColor = System.Drawing.Color.Lime;
            this.LblFullVaha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFullVaha.Location = new System.Drawing.Point(63, 311);
            this.LblFullVaha.Name = "LblFullVaha";
            this.LblFullVaha.Size = new System.Drawing.Size(168, 23);
            this.LblFullVaha.TabIndex = 7;
            // 
            // PanBack
            // 
            this.PanBack.BackColor = System.Drawing.Color.Black;
            this.PanBack.Controls.Add(this.PanPaint);
            this.PanBack.Location = new System.Drawing.Point(365, 115);
            this.PanBack.Name = "PanBack";
            this.PanBack.Size = new System.Drawing.Size(270, 219);
            this.PanBack.TabIndex = 8;
            // 
            // PanPaint
            // 
            this.PanPaint.BackColor = System.Drawing.Color.White;
            this.PanPaint.Location = new System.Drawing.Point(3, 3);
            this.PanPaint.Name = "PanPaint";
            this.PanPaint.Size = new System.Drawing.Size(264, 213);
            this.PanPaint.TabIndex = 0;
            this.PanPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.PanPaint_Paint);
            // 
            // ListOut
            // 
            this.ListOut.FormattingEnabled = true;
            this.ListOut.ItemHeight = 15;
            this.ListOut.Location = new System.Drawing.Point(63, 118);
            this.ListOut.Name = "ListOut";
            this.ListOut.Size = new System.Drawing.Size(168, 184);
            this.ListOut.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 363);
            this.Controls.Add(this.ListOut);
            this.Controls.Add(this.PanBack);
            this.Controls.Add(this.LblFullVaha);
            this.Controls.Add(this.COMBgen);
            this.Controls.Add(this.LblPocet);
            this.Controls.Add(this.LblVaha);
            this.Controls.Add(this.ButtRess);
            this.Controls.Add(this.ButtADD);
            this.Controls.Add(this.TxtBoxIN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanBack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBoxIN;
        private System.Windows.Forms.Button ButtADD;
        private System.Windows.Forms.Button ButtRess;
        private System.Windows.Forms.Label LblVaha;
        private System.Windows.Forms.Label LblPocet;
        private System.Windows.Forms.ComboBox COMBgen;
        private System.Windows.Forms.Label LblFullVaha;
        private System.Windows.Forms.Panel PanBack;
        private System.Windows.Forms.Panel PanPaint;
        private System.Windows.Forms.ListBox ListOut;
    }
}

