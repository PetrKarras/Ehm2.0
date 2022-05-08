
namespace Opakovač
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
            this.TxtBoxWord = new System.Windows.Forms.TextBox();
            this.Butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.TxtBoxOut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBoxWord
            // 
            this.TxtBoxWord.Location = new System.Drawing.Point(325, 194);
            this.TxtBoxWord.Name = "TxtBoxWord";
            this.TxtBoxWord.Size = new System.Drawing.Size(100, 23);
            this.TxtBoxWord.TabIndex = 1;
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(325, 224);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(100, 23);
            this.Butt.TabIndex = 3;
            this.Butt.Text = "Click!!!";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Číslo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(325, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opakovač";
            // 
            // NumUpDown
            // 
            this.NumUpDown.Location = new System.Drawing.Point(325, 160);
            this.NumUpDown.Name = "NumUpDown";
            this.NumUpDown.Size = new System.Drawing.Size(100, 23);
            this.NumUpDown.TabIndex = 7;
            // 
            // TxtBoxOut
            // 
            this.TxtBoxOut.Location = new System.Drawing.Point(333, 259);
            this.TxtBoxOut.Multiline = true;
            this.TxtBoxOut.Name = "TxtBoxOut";
            this.TxtBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtBoxOut.Size = new System.Drawing.Size(100, 179);
            this.TxtBoxOut.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBoxOut);
            this.Controls.Add(this.NumUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Butt);
            this.Controls.Add(this.TxtBoxWord);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBoxWord;
        private System.Windows.Forms.Button Butt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumUpDown;
        private System.Windows.Forms.TextBox TxtBoxOut;
    }
}

