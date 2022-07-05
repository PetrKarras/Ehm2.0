
namespace _12__Století
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
            this.RadButtPr = new System.Windows.Forms.RadioButton();
            this.RadbuttNl = new System.Windows.Forms.RadioButton();
            this.Txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblOut = new System.Windows.Forms.Label();
            this.Butt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RadButtPr
            // 
            this.RadButtPr.AutoSize = true;
            this.RadButtPr.Location = new System.Drawing.Point(243, 124);
            this.RadButtPr.Name = "RadButtPr";
            this.RadButtPr.Size = new System.Drawing.Size(64, 19);
            this.RadButtPr.TabIndex = 0;
            this.RadButtPr.TabStop = true;
            this.RadButtPr.Text = "st.př.n.l";
            this.RadButtPr.UseVisualStyleBackColor = true;
            // 
            // RadbuttNl
            // 
            this.RadbuttNl.AutoSize = true;
            this.RadbuttNl.Location = new System.Drawing.Point(243, 99);
            this.RadbuttNl.Name = "RadbuttNl";
            this.RadbuttNl.Size = new System.Drawing.Size(50, 19);
            this.RadbuttNl.TabIndex = 1;
            this.RadbuttNl.TabStop = true;
            this.RadbuttNl.Text = "st.n.l";
            this.RadbuttNl.UseVisualStyleBackColor = true;
            // 
            // Txtbox
            // 
            this.Txtbox.Location = new System.Drawing.Point(85, 99);
            this.Txtbox.Multiline = true;
            this.Txtbox.Name = "Txtbox";
            this.Txtbox.Size = new System.Drawing.Size(100, 19);
            this.Txtbox.TabIndex = 2;
            this.Txtbox.Text = "3.1.2222";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Určovač století";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum:";
            // 
            // LblOut
            // 
            this.LblOut.AutoSize = true;
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Location = new System.Drawing.Point(85, 217);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(2, 17);
            this.LblOut.TabIndex = 5;
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(85, 137);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(100, 63);
            this.Butt.TabIndex = 6;
            this.Butt.Text = "Informace o datu";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(88, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "den.měsíc.rok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Butt);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtbox);
            this.Controls.Add(this.RadbuttNl);
            this.Controls.Add(this.RadButtPr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadButtPr;
        private System.Windows.Forms.RadioButton RadbuttNl;
        private System.Windows.Forms.TextBox Txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblOut;
        private System.Windows.Forms.Button Butt;
        private System.Windows.Forms.Label label3;
    }
}

