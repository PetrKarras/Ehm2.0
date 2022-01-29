
namespace AnalyzaCisla
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
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.BtnAnalyze = new System.Windows.Forms.Button();
            this.LblOut = new System.Windows.Forms.Label();
            this.LblInfo2 = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtNumber.Location = new System.Drawing.Point(239, 49);
            this.TxtNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(265, 29);
            this.TxtNumber.TabIndex = 0;
            // 
            // BtnAnalyze
            // 
            this.BtnAnalyze.Location = new System.Drawing.Point(280, 134);
            this.BtnAnalyze.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAnalyze.Name = "BtnAnalyze";
            this.BtnAnalyze.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAnalyze.Size = new System.Drawing.Size(190, 38);
            this.BtnAnalyze.TabIndex = 1;
            this.BtnAnalyze.Text = "Analyzuj číslo";
            this.BtnAnalyze.UseVisualStyleBackColor = true;
            this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // LblOut
            // 
            this.LblOut.AutoSize = true;
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Location = new System.Drawing.Point(280, 186);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(2, 17);
            this.LblOut.TabIndex = 4;
            // 
            // LblInfo2
            // 
            this.LblInfo2.AutoSize = true;
            this.LblInfo2.Location = new System.Drawing.Point(308, 99);
            this.LblInfo2.Name = "LblInfo2";
            this.LblInfo2.Size = new System.Drawing.Size(134, 15);
            this.LblInfo2.TabIndex = 5;
            this.LblInfo2.Text = "Mezi čísli dělejte mezery";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblInfo.Location = new System.Drawing.Point(280, 9);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(195, 32);
            this.LblInfo.TabIndex = 6;
            this.LblInfo.Text = "Analyzator čísel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 493);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.LblInfo2);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.BtnAnalyze);
            this.Controls.Add(this.TxtNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Analýa čísla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Button BtnAnalyze;
        private System.Windows.Forms.Label LblOut;
        private System.Windows.Forms.Label LblInfo2;
        private System.Windows.Forms.Label LblInfo;
    }
}

