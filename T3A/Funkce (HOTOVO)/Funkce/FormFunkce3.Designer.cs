namespace Funkce
{
    partial class FormFunkce3
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
            this.Butt = new System.Windows.Forms.Button();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.NumUD = new System.Windows.Forms.NumericUpDown();
            this.LblOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(12, 55);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(249, 23);
            this.Butt.TabIndex = 0;
            this.Butt.Text = "TVOŘ";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(12, 25);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.PlaceholderText = "Jméno";
            this.TxtBox.Size = new System.Drawing.Size(100, 23);
            this.TxtBox.TabIndex = 1;
            // 
            // NumUD
            // 
            this.NumUD.Location = new System.Drawing.Point(141, 26);
            this.NumUD.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NumUD.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.NumUD.Name = "NumUD";
            this.NumUD.Size = new System.Drawing.Size(120, 23);
            this.NumUD.TabIndex = 2;
            this.NumUD.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOut.Location = new System.Drawing.Point(12, 93);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(249, 35);
            this.LblOut.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rok";
            // 
            // FormFunkce3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.NumUD);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.Butt);
            this.Name = "FormFunkce3";
            this.Text = "Generátor přezdívek";
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Butt;
        private TextBox TxtBox;
        private NumericUpDown NumUD;
        private Label LblOut;
        private Label label1;
    }
}