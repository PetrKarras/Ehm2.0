
namespace Kinosál
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
            this.NumUDVel = new System.Windows.Forms.NumericUpDown();
            this.LblVel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDVel)).BeginInit();
            this.SuspendLayout();
            // 
            // Butt
            // 
            this.Butt.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Butt.Location = new System.Drawing.Point(222, 12);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(123, 23);
            this.Butt.TabIndex = 0;
            this.Butt.Text = "Generovat";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // NumUDVel
            // 
            this.NumUDVel.Location = new System.Drawing.Point(96, 12);
            this.NumUDVel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumUDVel.Name = "NumUDVel";
            this.NumUDVel.Size = new System.Drawing.Size(120, 23);
            this.NumUDVel.TabIndex = 1;
            // 
            // LblVel
            // 
            this.LblVel.AutoSize = true;
            this.LblVel.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVel.Location = new System.Drawing.Point(15, 14);
            this.LblVel.Name = "LblVel";
            this.LblVel.Size = new System.Drawing.Size(78, 18);
            this.LblVel.TabIndex = 2;
            this.LblVel.Text = "velikost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblVel);
            this.Controls.Add(this.NumUDVel);
            this.Controls.Add(this.Butt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDVel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butt;
        private System.Windows.Forms.NumericUpDown NumUDVel;
        private System.Windows.Forms.Label LblVel;
    }
}

