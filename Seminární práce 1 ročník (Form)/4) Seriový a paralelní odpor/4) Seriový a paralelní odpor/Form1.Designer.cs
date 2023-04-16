namespace _4__Seriový_a_paralelní_odpor
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
            this.RadButSer = new System.Windows.Forms.RadioButton();
            this.RadButtPar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Butt = new System.Windows.Forms.Button();
            this.LblOUT = new System.Windows.Forms.Label();
            this.ButtRes = new System.Windows.Forms.Button();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RadButSer
            // 
            this.RadButSer.AutoSize = true;
            this.RadButSer.Location = new System.Drawing.Point(172, 69);
            this.RadButSer.Name = "RadButSer";
            this.RadButSer.Size = new System.Drawing.Size(63, 19);
            this.RadButSer.TabIndex = 0;
            this.RadButSer.TabStop = true;
            this.RadButSer.Text = "Seriový";
            this.RadButSer.UseVisualStyleBackColor = true;
            // 
            // RadButtPar
            // 
            this.RadButtPar.AutoSize = true;
            this.RadButtPar.Location = new System.Drawing.Point(172, 100);
            this.RadButtPar.Name = "RadButtPar";
            this.RadButtPar.Size = new System.Drawing.Size(70, 19);
            this.RadButtPar.TabIndex = 1;
            this.RadButtPar.TabStop = true;
            this.RadButtPar.Text = "Paralelní";
            this.RadButtPar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odporová kalkulačka";
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(12, 98);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(120, 23);
            this.Butt.TabIndex = 3;
            this.Butt.Text = "Počítej";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // LblOUT
            // 
            this.LblOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOUT.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOUT.Location = new System.Drawing.Point(10, 139);
            this.LblOUT.Name = "LblOUT";
            this.LblOUT.Size = new System.Drawing.Size(232, 37);
            this.LblOUT.TabIndex = 5;
            // 
            // ButtRes
            // 
            this.ButtRes.Location = new System.Drawing.Point(10, 193);
            this.ButtRes.Name = "ButtRes";
            this.ButtRes.Size = new System.Drawing.Size(232, 23);
            this.ButtRes.TabIndex = 6;
            this.ButtRes.Text = "Reset";
            this.ButtRes.UseVisualStyleBackColor = true;
            this.ButtRes.Click += new System.EventHandler(this.ButtRes_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(12, 69);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.PlaceholderText = "Odpor";
            this.TxtBox.Size = new System.Drawing.Size(120, 23);
            this.TxtBox.TabIndex = 7;
            this.TxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 228);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.ButtRes);
            this.Controls.Add(this.LblOUT);
            this.Controls.Add(this.Butt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadButtPar);
            this.Controls.Add(this.RadButSer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton RadButSer;
        private RadioButton RadButtPar;
        private Label label1;
        private Button Butt;
        private Label LblOUT;
        private Button ButtRes;
        private TextBox TxtBox;
    }
}