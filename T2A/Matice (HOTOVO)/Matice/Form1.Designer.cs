﻿
namespace Matice
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
            this.components = new System.ComponentModel.Container();
            this.Txtbox = new System.Windows.Forms.TextBox();
            this.RadDEF = new System.Windows.Forms.RadioButton();
            this.RadRows = new System.Windows.Forms.RadioButton();
            this.RadColums = new System.Windows.Forms.RadioButton();
            this.Butt = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtbox
            // 
            this.Txtbox.Location = new System.Drawing.Point(75, 98);
            this.Txtbox.Multiline = true;
            this.Txtbox.Name = "Txtbox";
            this.Txtbox.Size = new System.Drawing.Size(249, 262);
            this.Txtbox.TabIndex = 0;
            // 
            // RadDEF
            // 
            this.RadDEF.AutoSize = true;
            this.RadDEF.Location = new System.Drawing.Point(350, 98);
            this.RadDEF.Name = "RadDEF";
            this.RadDEF.Size = new System.Drawing.Size(66, 19);
            this.RadDEF.TabIndex = 1;
            this.RadDEF.TabStop = true;
            this.RadDEF.Text = "Výchozí";
            this.RadDEF.UseVisualStyleBackColor = true;
            // 
            // RadRows
            // 
            this.RadRows.AutoSize = true;
            this.RadRows.Location = new System.Drawing.Point(350, 212);
            this.RadRows.Name = "RadRows";
            this.RadRows.Size = new System.Drawing.Size(101, 19);
            this.RadRows.TabIndex = 2;
            this.RadRows.TabStop = true;
            this.RadRows.Text = "Stejné sloupce";
            this.RadRows.UseVisualStyleBackColor = true;
            // 
            // RadColums
            // 
            this.RadColums.AutoSize = true;
            this.RadColums.Location = new System.Drawing.Point(350, 187);
            this.RadColums.Name = "RadColums";
            this.RadColums.Size = new System.Drawing.Size(89, 19);
            this.RadColums.TabIndex = 3;
            this.RadColums.TabStop = true;
            this.RadColums.Text = "Stejné řádky";
            this.RadColums.UseVisualStyleBackColor = true;
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(345, 313);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(125, 47);
            this.Butt.TabIndex = 4;
            this.Butt.Text = "Click";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // NumUpDown
            // 
            this.NumUpDown.Location = new System.Drawing.Point(350, 158);
            this.NumUpDown.Name = "NumUpDown";
            this.NumUpDown.Size = new System.Drawing.Size(120, 23);
            this.NumUpDown.TabIndex = 5;
            this.NumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Maximální hodnota";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumUpDown);
            this.Controls.Add(this.Butt);
            this.Controls.Add(this.RadColums);
            this.Controls.Add(this.RadRows);
            this.Controls.Add(this.RadDEF);
            this.Controls.Add(this.Txtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtbox;
        private System.Windows.Forms.RadioButton RadDEF;
        private System.Windows.Forms.RadioButton RadRows;
        private System.Windows.Forms.RadioButton RadColums;
        private System.Windows.Forms.Button Butt;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.NumericUpDown NumUpDown;
        private System.Windows.Forms.Label label1;
    }
}

