namespace Analýza_souboru
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
            this.ButtFile = new System.Windows.Forms.Button();
            this.LblFile = new System.Windows.Forms.Label();
            this.TxtBoxWord = new System.Windows.Forms.TextBox();
            this.ButtAnalyze = new System.Windows.Forms.Button();
            this.LblOut = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ButtFile
            // 
            this.ButtFile.Location = new System.Drawing.Point(142, 12);
            this.ButtFile.Name = "ButtFile";
            this.ButtFile.Size = new System.Drawing.Size(75, 23);
            this.ButtFile.TabIndex = 0;
            this.ButtFile.Text = "Vybrat";
            this.ButtFile.UseVisualStyleBackColor = true;
            this.ButtFile.Click += new System.EventHandler(this.ButtFile_Click);
            // 
            // LblFile
            // 
            this.LblFile.AutoSize = true;
            this.LblFile.Location = new System.Drawing.Point(20, 17);
            this.LblFile.Name = "LblFile";
            this.LblFile.Size = new System.Drawing.Size(62, 15);
            this.LblFile.TabIndex = 1;
            this.LblFile.Text = "Soubor.txt";
            // 
            // TxtBoxWord
            // 
            this.TxtBoxWord.Location = new System.Drawing.Point(20, 57);
            this.TxtBoxWord.Name = "TxtBoxWord";
            this.TxtBoxWord.PlaceholderText = "Slovo na hledání";
            this.TxtBoxWord.Size = new System.Drawing.Size(197, 23);
            this.TxtBoxWord.TabIndex = 2;
            // 
            // ButtAnalyze
            // 
            this.ButtAnalyze.Enabled = false;
            this.ButtAnalyze.Location = new System.Drawing.Point(20, 104);
            this.ButtAnalyze.Name = "ButtAnalyze";
            this.ButtAnalyze.Size = new System.Drawing.Size(195, 33);
            this.ButtAnalyze.TabIndex = 3;
            this.ButtAnalyze.Text = "Analyzovat";
            this.ButtAnalyze.UseVisualStyleBackColor = true;
            this.ButtAnalyze.Click += new System.EventHandler(this.ButtAnalyze_Click);
            // 
            // LblOut
            // 
            this.LblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOut.Location = new System.Drawing.Point(20, 150);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(197, 175);
            this.LblOut.TabIndex = 4;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            this.OpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 334);
            this.Controls.Add(this.LblOut);
            this.Controls.Add(this.ButtAnalyze);
            this.Controls.Add(this.TxtBoxWord);
            this.Controls.Add(this.LblFile);
            this.Controls.Add(this.ButtFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtFile;
        private Label LblFile;
        private TextBox TxtBoxWord;
        private Button ButtAnalyze;
        private Label LblOut;
        private OpenFileDialog OpenFileDialog;
    }
}