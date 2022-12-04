namespace _05_KnihaJizd
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
            this.BtnReadFile = new System.Windows.Forms.Button();
            this.LblOutDatum = new System.Windows.Forms.Label();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.LblOUTRidic = new System.Windows.Forms.Label();
            this.LblOutZbozi = new System.Windows.Forms.Label();
            this.LblOutAuto = new System.Windows.Forms.Label();
            this.LblOutSpz = new System.Windows.Forms.Label();
            this.ButtLeft = new System.Windows.Forms.Button();
            this.ButtRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnReadFile
            // 
            this.BtnReadFile.Location = new System.Drawing.Point(237, 35);
            this.BtnReadFile.Name = "BtnReadFile";
            this.BtnReadFile.Size = new System.Drawing.Size(166, 23);
            this.BtnReadFile.TabIndex = 0;
            this.BtnReadFile.Text = "Načti soubor";
            this.BtnReadFile.UseVisualStyleBackColor = true;
            this.BtnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click_1);
            // 
            // LblOutDatum
            // 
            this.LblOutDatum.AccessibleDescription = "";
            this.LblOutDatum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOutDatum.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.LblOutDatum.Location = new System.Drawing.Point(145, 82);
            this.LblOutDatum.Name = "LblOutDatum";
            this.LblOutDatum.Size = new System.Drawing.Size(144, 22);
            this.LblOutDatum.TabIndex = 1;
            // 
            // TxtFileName
            // 
            this.TxtFileName.AccessibleDescription = "";
            this.TxtFileName.Location = new System.Drawing.Point(25, 35);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(197, 23);
            this.TxtFileName.TabIndex = 2;
            this.TxtFileName.Text = "jizdy.csv";
            // 
            // LblOUTRidic
            // 
            this.LblOUTRidic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOUTRidic.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.LblOUTRidic.Location = new System.Drawing.Point(145, 123);
            this.LblOUTRidic.Name = "LblOUTRidic";
            this.LblOUTRidic.Size = new System.Drawing.Size(144, 22);
            this.LblOUTRidic.TabIndex = 3;
            // 
            // LblOutZbozi
            // 
            this.LblOutZbozi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOutZbozi.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.LblOutZbozi.Location = new System.Drawing.Point(145, 161);
            this.LblOutZbozi.Name = "LblOutZbozi";
            this.LblOutZbozi.Size = new System.Drawing.Size(144, 22);
            this.LblOutZbozi.TabIndex = 4;
            // 
            // LblOutAuto
            // 
            this.LblOutAuto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOutAuto.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.LblOutAuto.Location = new System.Drawing.Point(145, 196);
            this.LblOutAuto.Name = "LblOutAuto";
            this.LblOutAuto.Size = new System.Drawing.Size(144, 22);
            this.LblOutAuto.TabIndex = 5;
            // 
            // LblOutSpz
            // 
            this.LblOutSpz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOutSpz.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.LblOutSpz.Location = new System.Drawing.Point(145, 233);
            this.LblOutSpz.Name = "LblOutSpz";
            this.LblOutSpz.Size = new System.Drawing.Size(144, 22);
            this.LblOutSpz.TabIndex = 6;
            // 
            // ButtLeft
            // 
            this.ButtLeft.Location = new System.Drawing.Point(64, 82);
            this.ButtLeft.Name = "ButtLeft";
            this.ButtLeft.Size = new System.Drawing.Size(75, 173);
            this.ButtLeft.TabIndex = 7;
            this.ButtLeft.Text = "◄";
            this.ButtLeft.UseVisualStyleBackColor = true;
            this.ButtLeft.Click += new System.EventHandler(this.ButtLeft_Click);
            // 
            // ButtRight
            // 
            this.ButtRight.Location = new System.Drawing.Point(295, 80);
            this.ButtRight.Name = "ButtRight";
            this.ButtRight.Size = new System.Drawing.Size(75, 176);
            this.ButtRight.TabIndex = 8;
            this.ButtRight.Text = "►";
            this.ButtRight.UseVisualStyleBackColor = true;
            this.ButtRight.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 263);
            this.Controls.Add(this.ButtRight);
            this.Controls.Add(this.ButtLeft);
            this.Controls.Add(this.LblOutSpz);
            this.Controls.Add(this.LblOutAuto);
            this.Controls.Add(this.LblOutZbozi);
            this.Controls.Add(this.LblOUTRidic);
            this.Controls.Add(this.TxtFileName);
            this.Controls.Add(this.LblOutDatum);
            this.Controls.Add(this.BtnReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button BtnReadFile;
        private Label LblOutDatum;
        private TextBox TxtFileName;
        private Label LblOUTRidic;
        private Label LblOutZbozi;
        private Label LblOutAuto;
        private Label LblOutSpz;
        private Button ButtLeft;
        private Button ButtRight;
    }
}