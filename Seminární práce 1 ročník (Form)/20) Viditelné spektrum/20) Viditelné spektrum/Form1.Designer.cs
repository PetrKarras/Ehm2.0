namespace _20__Viditelné_spektrum
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
            this.NumUD = new System.Windows.Forms.NumericUpDown();
            this.LblOUT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // NumUD
            // 
            this.NumUD.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumUD.Location = new System.Drawing.Point(337, 196);
            this.NumUD.Maximum = new decimal(new int[] {
            740,
            0,
            0,
            0});
            this.NumUD.Minimum = new decimal(new int[] {
            380,
            0,
            0,
            0});
            this.NumUD.Name = "NumUD";
            this.NumUD.Size = new System.Drawing.Size(120, 40);
            this.NumUD.TabIndex = 0;
            this.NumUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUD.Value = new decimal(new int[] {
            380,
            0,
            0,
            0});
            this.NumUD.ValueChanged += new System.EventHandler(this.NumUD_ValueChanged);
            // 
            // LblOUT
            // 
            this.LblOUT.BackColor = System.Drawing.Color.Transparent;
            this.LblOUT.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOUT.ForeColor = System.Drawing.Color.Gray;
            this.LblOUT.Location = new System.Drawing.Point(337, 252);
            this.LblOUT.Name = "LblOUT";
            this.LblOUT.Size = new System.Drawing.Size(120, 51);
            this.LblOUT.TabIndex = 1;
            this.LblOUT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblOUT);
            this.Controls.Add(this.NumUD);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown NumUD;
        private Label LblOUT;
    }
}