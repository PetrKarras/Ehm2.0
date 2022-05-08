
namespace Dialogová_okna
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
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.ButtNUM = new System.Windows.Forms.Button();
            this.ButtCol = new System.Windows.Forms.Button();
            this.ButtRes = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(221, 73);
            this.TxtBox.Multiline = true;
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(201, 109);
            this.TxtBox.TabIndex = 0;
            // 
            // ButtNUM
            // 
            this.ButtNUM.Location = new System.Drawing.Point(221, 188);
            this.ButtNUM.Name = "ButtNUM";
            this.ButtNUM.Size = new System.Drawing.Size(75, 23);
            this.ButtNUM.TabIndex = 1;
            this.ButtNUM.Text = "Počet";
            this.ButtNUM.UseVisualStyleBackColor = true;
            this.ButtNUM.Click += new System.EventHandler(this.ButtNUM_Click);
            // 
            // ButtCol
            // 
            this.ButtCol.Location = new System.Drawing.Point(347, 188);
            this.ButtCol.Name = "ButtCol";
            this.ButtCol.Size = new System.Drawing.Size(75, 23);
            this.ButtCol.TabIndex = 2;
            this.ButtCol.Text = "Barva";
            this.ButtCol.UseVisualStyleBackColor = true;
            this.ButtCol.Click += new System.EventHandler(this.ButtCol_Click);
            // 
            // ButtRes
            // 
            this.ButtRes.Location = new System.Drawing.Point(290, 233);
            this.ButtRes.Name = "ButtRes";
            this.ButtRes.Size = new System.Drawing.Size(75, 23);
            this.ButtRes.TabIndex = 3;
            this.ButtRes.Text = "Reset";
            this.ButtRes.UseVisualStyleBackColor = true;
            this.ButtRes.Click += new System.EventHandler(this.ButtRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtRes);
            this.Controls.Add(this.ButtCol);
            this.Controls.Add(this.ButtNUM);
            this.Controls.Add(this.TxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.Button ButtNUM;
        private System.Windows.Forms.Button ButtCol;
        private System.Windows.Forms.Button ButtRes;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

