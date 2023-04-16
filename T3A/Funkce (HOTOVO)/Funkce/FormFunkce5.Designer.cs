namespace Funkce
{
    partial class FormFunkce5
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
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.TxtBoxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumUDPlat = new System.Windows.Forms.NumericUpDown();
            this.LblOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPlat)).BeginInit();
            this.SuspendLayout();
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(12, 138);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(300, 25);
            this.Butt.TabIndex = 0;
            this.Butt.Text = "Vypis";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(12, 23);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(300, 23);
            this.TxtBoxName.TabIndex = 1;
            // 
            // TxtBoxSurname
            // 
            this.TxtBoxSurname.Location = new System.Drawing.Point(12, 62);
            this.TxtBoxSurname.Name = "TxtBoxSurname";
            this.TxtBoxSurname.Size = new System.Drawing.Size(300, 23);
            this.TxtBoxSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plat";
            // 
            // NumUDPlat
            // 
            this.NumUDPlat.Location = new System.Drawing.Point(191, 96);
            this.NumUDPlat.Name = "NumUDPlat";
            this.NumUDPlat.Size = new System.Drawing.Size(120, 23);
            this.NumUDPlat.TabIndex = 4;
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Location = new System.Drawing.Point(12, 182);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(299, 229);
            this.LblOut.TabIndex = 5;
            // 
            // FormFunkce5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 427);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.NumUDPlat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxSurname);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.Butt);
            this.Name = "FormFunkce5";
            this.Text = "Jednoduchá evidence";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPlat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Butt;
        private TextBox TxtBoxName;
        private TextBox TxtBoxSurname;
        private Label label1;
        private NumericUpDown NumUDPlat;
        private Label LblOut;
    }
}