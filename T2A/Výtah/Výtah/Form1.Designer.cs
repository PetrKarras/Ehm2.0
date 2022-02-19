
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
            this.TxtBoxOut = new System.Windows.Forms.TextBox();
            this.TxtBoxIN = new System.Windows.Forms.TextBox();
            this.ButtADD = new System.Windows.Forms.Button();
            this.ButtRess = new System.Windows.Forms.Button();
            this.LblVaha = new System.Windows.Forms.Label();
            this.LblPocet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBoxOut
            // 
            this.TxtBoxOut.Location = new System.Drawing.Point(100, 122);
            this.TxtBoxOut.Multiline = true;
            this.TxtBoxOut.Name = "TxtBoxOut";
            this.TxtBoxOut.Size = new System.Drawing.Size(100, 184);
            this.TxtBoxOut.TabIndex = 0;
            // 
            // TxtBoxIN
            // 
            this.TxtBoxIN.Location = new System.Drawing.Point(247, 171);
            this.TxtBoxIN.Name = "TxtBoxIN";
            this.TxtBoxIN.Size = new System.Drawing.Size(100, 23);
            this.TxtBoxIN.TabIndex = 1;
            // 
            // ButtADD
            // 
            this.ButtADD.Location = new System.Drawing.Point(247, 212);
            this.ButtADD.Name = "ButtADD";
            this.ButtADD.Size = new System.Drawing.Size(100, 23);
            this.ButtADD.TabIndex = 2;
            this.ButtADD.Text = "Přidej";
            this.ButtADD.UseVisualStyleBackColor = true;
            this.ButtADD.Click += new System.EventHandler(this.ButtADD_Click);
            // 
            // ButtRess
            // 
            this.ButtRess.Location = new System.Drawing.Point(247, 241);
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
            this.LblPocet.Location = new System.Drawing.Point(311, 122);
            this.LblPocet.Name = "LblPocet";
            this.LblPocet.Size = new System.Drawing.Size(37, 15);
            this.LblPocet.TabIndex = 5;
            this.LblPocet.Text = "Počet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblPocet);
            this.Controls.Add(this.LblVaha);
            this.Controls.Add(this.ButtRess);
            this.Controls.Add(this.ButtADD);
            this.Controls.Add(this.TxtBoxIN);
            this.Controls.Add(this.TxtBoxOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxOut;
        private System.Windows.Forms.TextBox TxtBoxIN;
        private System.Windows.Forms.Button ButtADD;
        private System.Windows.Forms.Button ButtRess;
        private System.Windows.Forms.Label LblVaha;
        private System.Windows.Forms.Label LblPocet;
    }
}

