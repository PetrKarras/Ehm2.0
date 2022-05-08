namespace Vstupenka
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
            this.PanBack = new System.Windows.Forms.Panel();
            this.PanFront = new System.Windows.Forms.Panel();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.DaTiPick = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.ButtPrint = new System.Windows.Forms.Button();
            this.FontDialogB = new System.Windows.Forms.FontDialog();
            this.ButtFontB = new System.Windows.Forms.Button();
            this.ButtColor = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.CheBoxVstup = new System.Windows.Forms.CheckBox();
            this.CheBoxDiv = new System.Windows.Forms.CheckBox();
            this.CheBoxZvon = new System.Windows.Forms.CheckBox();
            this.CheBoxPoh = new System.Windows.Forms.CheckBox();
            this.CheBoxDat = new System.Windows.Forms.CheckBox();
            this.CheBoxCena = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.NumUpDownY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtFontL = new System.Windows.Forms.Button();
            this.ButtFontM = new System.Windows.Forms.Button();
            this.FontDialogM = new System.Windows.Forms.FontDialog();
            this.FontDialogL = new System.Windows.Forms.FontDialog();
            this.ButtPic = new System.Windows.Forms.Button();
            this.PanBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownY)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBack
            // 
            this.PanBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanBack.Controls.Add(this.PanFront);
            this.PanBack.Location = new System.Drawing.Point(3, 1);
            this.PanBack.Name = "PanBack";
            this.PanBack.Size = new System.Drawing.Size(438, 160);
            this.PanBack.TabIndex = 0;
            // 
            // PanFront
            // 
            this.PanFront.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanFront.Location = new System.Drawing.Point(3, 3);
            this.PanFront.Name = "PanFront";
            this.PanFront.Size = new System.Drawing.Size(430, 154);
            this.PanFront.TabIndex = 1;
            this.PanFront.Paint += new System.Windows.Forms.PaintEventHandler(this.PanFront_Paint);
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(86, 178);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(160, 23);
            this.TxtBoxName.TabIndex = 1;
            this.TxtBoxName.Text = "O Šípkové Růžence";
            // 
            // DaTiPick
            // 
            this.DaTiPick.CustomFormat = "d.M.yyyy";
            this.DaTiPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DaTiPick.Location = new System.Drawing.Point(86, 211);
            this.DaTiPick.Name = "DaTiPick";
            this.DaTiPick.Size = new System.Drawing.Size(160, 23);
            this.DaTiPick.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pohádka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena";
            // 
            // NumUpDownPrice
            // 
            this.NumUpDownPrice.Location = new System.Drawing.Point(86, 242);
            this.NumUpDownPrice.Name = "NumUpDownPrice";
            this.NumUpDownPrice.Size = new System.Drawing.Size(160, 23);
            this.NumUpDownPrice.TabIndex = 6;
            this.NumUpDownPrice.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ButtPrint
            // 
            this.ButtPrint.Location = new System.Drawing.Point(6, 290);
            this.ButtPrint.Name = "ButtPrint";
            this.ButtPrint.Size = new System.Drawing.Size(120, 60);
            this.ButtPrint.TabIndex = 7;
            this.ButtPrint.Text = "Tisk";
            this.ButtPrint.UseVisualStyleBackColor = true;
            this.ButtPrint.Click += new System.EventHandler(this.ButtPrint_Click);
            // 
            // ButtFontB
            // 
            this.ButtFontB.Location = new System.Drawing.Point(430, 288);
            this.ButtFontB.Name = "ButtFontB";
            this.ButtFontB.Size = new System.Drawing.Size(60, 60);
            this.ButtFontB.TabIndex = 12;
            this.ButtFontB.Text = "Font 1";
            this.ButtFontB.UseVisualStyleBackColor = true;
            this.ButtFontB.Click += new System.EventHandler(this.ButtFontB_Click);
            // 
            // ButtColor
            // 
            this.ButtColor.Location = new System.Drawing.Point(275, 288);
            this.ButtColor.Name = "ButtColor";
            this.ButtColor.Size = new System.Drawing.Size(120, 60);
            this.ButtColor.TabIndex = 13;
            this.ButtColor.Text = "Změna barvy";
            this.ButtColor.UseVisualStyleBackColor = true;
            this.ButtColor.Click += new System.EventHandler(this.ButtColor_Click);
            // 
            // CheBoxVstup
            // 
            this.CheBoxVstup.AutoSize = true;
            this.CheBoxVstup.Location = new System.Drawing.Point(463, 25);
            this.CheBoxVstup.Name = "CheBoxVstup";
            this.CheBoxVstup.Size = new System.Drawing.Size(94, 19);
            this.CheBoxVstup.TabIndex = 14;
            this.CheBoxVstup.Text = "1) Vstupenka";
            this.CheBoxVstup.UseVisualStyleBackColor = true;
            // 
            // CheBoxDiv
            // 
            this.CheBoxDiv.AutoSize = true;
            this.CheBoxDiv.Location = new System.Drawing.Point(463, 50);
            this.CheBoxDiv.Name = "CheBoxDiv";
            this.CheBoxDiv.Size = new System.Drawing.Size(130, 19);
            this.CheBoxDiv.TabIndex = 15;
            this.CheBoxDiv.Text = "3) Loutkové divadlo";
            this.CheBoxDiv.UseVisualStyleBackColor = true;
            // 
            // CheBoxZvon
            // 
            this.CheBoxZvon.AutoSize = true;
            this.CheBoxZvon.Location = new System.Drawing.Point(463, 75);
            this.CheBoxZvon.Name = "CheBoxZvon";
            this.CheBoxZvon.Size = new System.Drawing.Size(84, 19);
            this.CheBoxZvon.TabIndex = 16;
            this.CheBoxZvon.Text = "3) ZVONEK";
            this.CheBoxZvon.UseVisualStyleBackColor = true;
            // 
            // CheBoxPoh
            // 
            this.CheBoxPoh.AutoSize = true;
            this.CheBoxPoh.Location = new System.Drawing.Point(463, 100);
            this.CheBoxPoh.Name = "CheBoxPoh";
            this.CheBoxPoh.Size = new System.Drawing.Size(85, 19);
            this.CheBoxPoh.TabIndex = 17;
            this.CheBoxPoh.Text = "2) Pohádka";
            this.CheBoxPoh.UseVisualStyleBackColor = true;
            // 
            // CheBoxDat
            // 
            this.CheBoxDat.AutoSize = true;
            this.CheBoxDat.Location = new System.Drawing.Point(463, 125);
            this.CheBoxDat.Name = "CheBoxDat";
            this.CheBoxDat.Size = new System.Drawing.Size(75, 19);
            this.CheBoxDat.TabIndex = 18;
            this.CheBoxDat.Text = "3) Datum";
            this.CheBoxDat.UseVisualStyleBackColor = true;
            // 
            // CheBoxCena
            // 
            this.CheBoxCena.AutoSize = true;
            this.CheBoxCena.Location = new System.Drawing.Point(463, 150);
            this.CheBoxCena.Name = "CheBoxCena";
            this.CheBoxCena.Size = new System.Drawing.Size(66, 19);
            this.CheBoxCena.TabIndex = 19;
            this.CheBoxCena.Text = "1) Cena";
            this.CheBoxCena.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Pohnout s :";
            // 
            // NumUpDownX
            // 
            this.NumUpDownX.Location = new System.Drawing.Point(506, 179);
            this.NumUpDownX.Name = "NumUpDownX";
            this.NumUpDownX.Size = new System.Drawing.Size(38, 23);
            this.NumUpDownX.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "X";
            // 
            // NumUpDownY
            // 
            this.NumUpDownY.Location = new System.Drawing.Point(506, 208);
            this.NumUpDownY.Name = "NumUpDownY";
            this.NumUpDownY.Size = new System.Drawing.Size(38, 23);
            this.NumUpDownY.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Y";
            // 
            // ButtFontL
            // 
            this.ButtFontL.Location = new System.Drawing.Point(562, 290);
            this.ButtFontL.Name = "ButtFontL";
            this.ButtFontL.Size = new System.Drawing.Size(60, 60);
            this.ButtFontL.TabIndex = 25;
            this.ButtFontL.Text = "Font 1";
            this.ButtFontL.UseVisualStyleBackColor = true;
            this.ButtFontL.Click += new System.EventHandler(this.ButtFontL_Click);
            // 
            // ButtFontM
            // 
            this.ButtFontM.Location = new System.Drawing.Point(496, 288);
            this.ButtFontM.Name = "ButtFontM";
            this.ButtFontM.Size = new System.Drawing.Size(60, 60);
            this.ButtFontM.TabIndex = 26;
            this.ButtFontM.Text = "Font 2";
            this.ButtFontM.UseVisualStyleBackColor = true;
            this.ButtFontM.Click += new System.EventHandler(this.ButtFontM_Click);
            // 
            // ButtPic
            // 
            this.ButtPic.Location = new System.Drawing.Point(149, 288);
            this.ButtPic.Name = "ButtPic";
            this.ButtPic.Size = new System.Drawing.Size(120, 60);
            this.ButtPic.TabIndex = 27;
            this.ButtPic.Text = "Vybrat obrázek";
            this.ButtPic.UseVisualStyleBackColor = true;
            this.ButtPic.Click += new System.EventHandler(this.ButtPic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 364);
            this.Controls.Add(this.ButtPic);
            this.Controls.Add(this.ButtFontM);
            this.Controls.Add(this.ButtFontL);
            this.Controls.Add(this.NumUpDownY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumUpDownX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheBoxCena);
            this.Controls.Add(this.CheBoxDat);
            this.Controls.Add(this.CheBoxPoh);
            this.Controls.Add(this.CheBoxZvon);
            this.Controls.Add(this.CheBoxDiv);
            this.Controls.Add(this.CheBoxVstup);
            this.Controls.Add(this.ButtColor);
            this.Controls.Add(this.ButtFontB);
            this.Controls.Add(this.ButtPrint);
            this.Controls.Add(this.NumUpDownPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DaTiPick);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.PanBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanBack;
        private Panel PanFront;
        private TextBox TxtBoxName;
        private DateTimePicker DaTiPick;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown NumUpDownPrice;
        private Button ButtPrint;
        private FontDialog FontDialogB;
        private Button ButtFontB;
        private Button ButtColor;
        private ColorDialog ColorDialog;
        private CheckBox CheBoxVstup;
        private CheckBox CheBoxDiv;
        private CheckBox CheBoxZvon;
        private CheckBox CheBoxPoh;
        private CheckBox CheBoxDat;
        private CheckBox CheBoxCena;
        private Label label5;
        private NumericUpDown NumUpDownX;
        private Label label6;
        private NumericUpDown NumUpDownY;
        private Label label7;
        private Button ButtFontL;
        private Button ButtFontM;
        private FontDialog FontDialogM;
        private FontDialog FontDialogL;
        private Button ButtPic;
    }
}