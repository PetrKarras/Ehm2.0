namespace Funkce
{
    partial class FunkceForm10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumUD1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD1)).BeginInit();
            this.SuspendLayout();
            // 
            // NumUD1
            // 
            this.NumUD1.Location = new System.Drawing.Point(12, 51);
            this.NumUD1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUD1.Name = "NumUD1";
            this.NumUD1.Size = new System.Drawing.Size(246, 23);
            this.NumUD1.TabIndex = 26;
            this.NumUD1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUD1.Click += new System.EventHandler(this.NumUD1_Click);
            // 
            // FunkceForm10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 131);
            this.Controls.Add(this.NumUD1);
            this.Name = "FunkceForm10";
            this.Text = "Dělič 7";
            ((System.ComponentModel.ISupportInitialize)(this.NumUD1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown NumUD1;
    }
}