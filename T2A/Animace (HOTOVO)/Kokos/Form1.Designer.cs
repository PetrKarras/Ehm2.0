namespace Kokos
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
            this.components = new System.ComponentModel.Container();
            this.ButtUp = new System.Windows.Forms.Button();
            this.PanBack = new System.Windows.Forms.Panel();
            this.PanFront = new System.Windows.Forms.Panel();
            this.ButtLeft = new System.Windows.Forms.Button();
            this.ButtRes = new System.Windows.Forms.Button();
            this.timerX = new System.Windows.Forms.Timer(this.components);
            this.timerY = new System.Windows.Forms.Timer(this.components);
            this.ButtRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.PanBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtUp
            // 
            this.ButtUp.Location = new System.Drawing.Point(654, 18);
            this.ButtUp.Name = "ButtUp";
            this.ButtUp.Size = new System.Drawing.Size(75, 23);
            this.ButtUp.TabIndex = 0;
            this.ButtUp.Text = "Nahoru";
            this.ButtUp.UseVisualStyleBackColor = true;
            this.ButtUp.Click += new System.EventHandler(this.ButtUp_Click);
            // 
            // PanBack
            // 
            this.PanBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanBack.Controls.Add(this.PanFront);
            this.PanBack.Location = new System.Drawing.Point(14, 15);
            this.PanBack.Name = "PanBack";
            this.PanBack.Size = new System.Drawing.Size(592, 434);
            this.PanBack.TabIndex = 1;
            // 
            // PanFront
            // 
            this.PanFront.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanFront.Location = new System.Drawing.Point(3, 3);
            this.PanFront.Name = "PanFront";
            this.PanFront.Size = new System.Drawing.Size(586, 428);
            this.PanFront.TabIndex = 2;
            this.PanFront.Paint += new System.Windows.Forms.PaintEventHandler(this.PanFront_Paint);
            // 
            // ButtLeft
            // 
            this.ButtLeft.Location = new System.Drawing.Point(612, 47);
            this.ButtLeft.Name = "ButtLeft";
            this.ButtLeft.Size = new System.Drawing.Size(75, 23);
            this.ButtLeft.TabIndex = 2;
            this.ButtLeft.Text = "Do leva";
            this.ButtLeft.UseVisualStyleBackColor = true;
            this.ButtLeft.Click += new System.EventHandler(this.ButtLeft_Click);
            // 
            // ButtRes
            // 
            this.ButtRes.Location = new System.Drawing.Point(612, 140);
            this.ButtRes.Name = "ButtRes";
            this.ButtRes.Size = new System.Drawing.Size(159, 23);
            this.ButtRes.TabIndex = 3;
            this.ButtRes.Text = "Reset";
            this.ButtRes.UseVisualStyleBackColor = true;
            this.ButtRes.Click += new System.EventHandler(this.ButtRes_Click);
            // 
            // timerX
            // 
            this.timerX.Enabled = true;
            this.timerX.Tick += new System.EventHandler(this.timerX_Tick);
            // 
            // timerY
            // 
            this.timerY.Enabled = true;
            this.timerY.Tick += new System.EventHandler(this.timerY_Tick);
            // 
            // ButtRight
            // 
            this.ButtRight.Location = new System.Drawing.Point(693, 47);
            this.ButtRight.Name = "ButtRight";
            this.ButtRight.Size = new System.Drawing.Size(75, 23);
            this.ButtRight.TabIndex = 4;
            this.ButtRight.Text = "Do prava";
            this.ButtRight.UseVisualStyleBackColor = true;
            this.ButtRight.Click += new System.EventHandler(this.ButtRight_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(654, 76);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 23);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.Text = "Dolu";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.ButtRight);
            this.Controls.Add(this.ButtRes);
            this.Controls.Add(this.ButtLeft);
            this.Controls.Add(this.PanBack);
            this.Controls.Add(this.ButtUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtUp;
        private Panel PanBack;
        private Panel PanFront;
        private Button ButtLeft;
        private Button ButtRes;
        private System.Windows.Forms.Timer timerX;
        private System.Windows.Forms.Timer timerY;
        private Button ButtRight;
        private Button buttonDown;
    }
}