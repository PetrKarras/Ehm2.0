namespace Abeceda
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
            this.Button = new System.Windows.Forms.Button();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblOut = new System.Windows.Forms.Label();
            this.RadButtAUp = new System.Windows.Forms.RadioButton();
            this.RadButtBUp = new System.Windows.Forms.RadioButton();
            this.RadButtADown = new System.Windows.Forms.RadioButton();
            this.RadButtBDown = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(12, 90);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(187, 23);
            this.Button.TabIndex = 0;
            this.Button.Text = "Zmačkni";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(12, 41);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(187, 23);
            this.TxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abecední kalkulačka";
            // 
            // LblOut
            // 
            this.LblOut.AutoSize = true;
            this.LblOut.Location = new System.Drawing.Point(226, 10);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(0, 15);
            this.LblOut.TabIndex = 3;
            // 
            // RadButtAUp
            // 
            this.RadButtAUp.AutoSize = true;
            this.RadButtAUp.Location = new System.Drawing.Point(12, 128);
            this.RadButtAUp.Name = "RadButtAUp";
            this.RadButtAUp.Size = new System.Drawing.Size(88, 19);
            this.RadButtAUp.TabIndex = 4;
            this.RadButtAUp.TabStop = true;
            this.RadButtAUp.Text = "Abededně ↑";
            this.RadButtAUp.UseVisualStyleBackColor = true;
            // 
            // RadButtBUp
            // 
            this.RadButtBUp.AutoSize = true;
            this.RadButtBUp.Location = new System.Drawing.Point(12, 181);
            this.RadButtBUp.Name = "RadButtBUp";
            this.RadButtBUp.Size = new System.Drawing.Size(117, 19);
            this.RadButtBUp.TabIndex = 5;
            this.RadButtBUp.TabStop = true;
            this.RadButtBUp.Text = "Nejpoužívanější ↑";
            this.RadButtBUp.UseVisualStyleBackColor = true;
            // 
            // RadButtADown
            // 
            this.RadButtADown.AutoSize = true;
            this.RadButtADown.Location = new System.Drawing.Point(12, 156);
            this.RadButtADown.Name = "RadButtADown";
            this.RadButtADown.Size = new System.Drawing.Size(88, 19);
            this.RadButtADown.TabIndex = 6;
            this.RadButtADown.TabStop = true;
            this.RadButtADown.Text = "Abededně ↓";
            this.RadButtADown.UseVisualStyleBackColor = true;
            // 
            // RadButtBDown
            // 
            this.RadButtBDown.AutoSize = true;
            this.RadButtBDown.Location = new System.Drawing.Point(12, 206);
            this.RadButtBDown.Name = "RadButtBDown";
            this.RadButtBDown.Size = new System.Drawing.Size(117, 19);
            this.RadButtBDown.TabIndex = 7;
            this.RadButtBDown.TabStop = true;
            this.RadButtBDown.Text = "Nejpoužívanější ↓";
            this.RadButtBDown.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.RadButtBDown);
            this.Controls.Add(this.RadButtADown);
            this.Controls.Add(this.RadButtBUp);
            this.Controls.Add(this.RadButtAUp);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.Button);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Button;
        private TextBox TxtBox;
        private Label label1;
        private Label LblOut;
        private RadioButton RadButtAUp;
        private RadioButton RadButtBUp;
        private RadioButton RadButtADown;
        private RadioButton RadButtBDown;
    }
}