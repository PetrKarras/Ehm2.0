﻿namespace Ohmův_Zákon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumUDU = new System.Windows.Forms.NumericUpDown();
            this.NumUDI = new System.Windows.Forms.NumericUpDown();
            this.NumUDR = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ohmova kalkulačka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Napětí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Odpor";
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(12, 224);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(272, 58);
            this.Button.TabIndex = 4;
            this.Button.Text = "Vypočítej";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(257, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ω";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(257, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(257, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "V";
            // 
            // NumUDU
            // 
            this.NumUDU.DecimalPlaces = 3;
            this.NumUDU.Location = new System.Drawing.Point(100, 87);
            this.NumUDU.Name = "NumUDU";
            this.NumUDU.Size = new System.Drawing.Size(133, 23);
            this.NumUDU.TabIndex = 14;
            // 
            // NumUDI
            // 
            this.NumUDI.DecimalPlaces = 3;
            this.NumUDI.Location = new System.Drawing.Point(100, 122);
            this.NumUDI.Name = "NumUDI";
            this.NumUDI.Size = new System.Drawing.Size(133, 23);
            this.NumUDI.TabIndex = 15;
            // 
            // NumUDR
            // 
            this.NumUDR.DecimalPlaces = 3;
            this.NumUDR.Location = new System.Drawing.Point(100, 157);
            this.NumUDR.Name = "NumUDR";
            this.NumUDR.Size = new System.Drawing.Size(133, 23);
            this.NumUDR.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 294);
            this.Controls.Add(this.NumUDR);
            this.Controls.Add(this.NumUDI);
            this.Controls.Add(this.NumUDU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Button;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown NumUDU;
        private NumericUpDown NumUDI;
        private NumericUpDown NumUDR;
    }
}