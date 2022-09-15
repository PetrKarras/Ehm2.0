namespace Obsah_trojúhelníku_bez_výšky
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
            this.NumUDA = new System.Windows.Forms.NumericUpDown();
            this.NumUDB = new System.Windows.Forms.NumericUpDown();
            this.NumUDC = new System.Windows.Forms.NumericUpDown();
            this.LblOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heronova kalkulačka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Strana a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Strana b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Strana c";
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(12, 234);
            this.Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(237, 96);
            this.Button.TabIndex = 4;
            this.Button.Text = "s = (a+b+c) / 2";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // NumUDA
            // 
            this.NumUDA.DecimalPlaces = 1;
            this.NumUDA.Location = new System.Drawing.Point(123, 60);
            this.NumUDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumUDA.Name = "NumUDA";
            this.NumUDA.Size = new System.Drawing.Size(120, 23);
            this.NumUDA.TabIndex = 5;
            // 
            // NumUDB
            // 
            this.NumUDB.DecimalPlaces = 1;
            this.NumUDB.Location = new System.Drawing.Point(123, 100);
            this.NumUDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumUDB.Name = "NumUDB";
            this.NumUDB.Size = new System.Drawing.Size(120, 23);
            this.NumUDB.TabIndex = 6;
            // 
            // NumUDC
            // 
            this.NumUDC.DecimalPlaces = 1;
            this.NumUDC.Location = new System.Drawing.Point(123, 140);
            this.NumUDC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumUDC.Name = "NumUDC";
            this.NumUDC.Size = new System.Drawing.Size(120, 23);
            this.NumUDC.TabIndex = 7;
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Location = new System.Drawing.Point(12, 196);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(237, 23);
            this.LblOut.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 342);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.NumUDC);
            this.Controls.Add(this.NumUDB);
            this.Controls.Add(this.NumUDA);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Button;
        private NumericUpDown NumUDA;
        private NumericUpDown NumUDB;
        private NumericUpDown NumUDC;
        private Label LblOut;
    }
}