namespace _3__Faktoriál
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
            this.Butt = new System.Windows.Forms.Button();
            this.NumUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LblOUT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(150, 65);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(75, 23);
            this.Butt.TabIndex = 0;
            this.Butt.Text = "Počítej";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // NumUD
            // 
            this.NumUD.Location = new System.Drawing.Point(12, 65);
            this.NumUD.Name = "NumUD";
            this.NumUD.Size = new System.Drawing.Size(120, 23);
            this.NumUD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faktoriál";
            // 
            // LblOUT
            // 
            this.LblOUT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOUT.Location = new System.Drawing.Point(12, 110);
            this.LblOUT.Name = "LblOUT";
            this.LblOUT.Size = new System.Drawing.Size(213, 93);
            this.LblOUT.TabIndex = 3;
            this.LblOUT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 255);
            this.Controls.Add(this.LblOUT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumUD);
            this.Controls.Add(this.Butt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Butt;
        private NumericUpDown NumUD;
        private Label label1;
        private Label LblOUT;
    }
}