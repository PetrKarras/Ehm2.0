namespace System_IO
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
            this.ButtPress = new System.Windows.Forms.Button();
            this.LblRidicOUT = new System.Windows.Forms.Label();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.LblDatumOUT = new System.Windows.Forms.Label();
            this.LblZboziOUT = new System.Windows.Forms.Label();
            this.LblAutoOUT = new System.Windows.Forms.Label();
            this.LblSpzOUT = new System.Windows.Forms.Label();
            this.CheckBoxRidic = new System.Windows.Forms.CheckBox();
            this.CheckBoxDatum = new System.Windows.Forms.CheckBox();
            this.CheckBoxZbozi = new System.Windows.Forms.CheckBox();
            this.CheckBoxAuto = new System.Windows.Forms.CheckBox();
            this.CheckBoxSpz = new System.Windows.Forms.CheckBox();
            this.Label = new System.Windows.Forms.Label();
            this.CMBBox1 = new System.Windows.Forms.ComboBox();
            this.CMBBox2 = new System.Windows.Forms.ComboBox();
            this.CMBBox3 = new System.Windows.Forms.ComboBox();
            this.CMBBox4 = new System.Windows.Forms.ComboBox();
            this.CMBBox5 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtPress
            // 
            this.ButtPress.Location = new System.Drawing.Point(37, 82);
            this.ButtPress.Name = "ButtPress";
            this.ButtPress.Size = new System.Drawing.Size(108, 23);
            this.ButtPress.TabIndex = 0;
            this.ButtPress.Text = "Načíst soubor:";
            this.ButtPress.UseVisualStyleBackColor = true;
            this.ButtPress.Click += new System.EventHandler(this.ButtPress_Click);
            // 
            // LblRidicOUT
            // 
            this.LblRidicOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblRidicOUT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblRidicOUT.Location = new System.Drawing.Point(37, 165);
            this.LblRidicOUT.Name = "LblRidicOUT";
            this.LblRidicOUT.Size = new System.Drawing.Size(108, 343);
            this.LblRidicOUT.TabIndex = 1;
            this.LblRidicOUT.Tag = "0";
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(588, 82);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(100, 23);
            this.TxtBox.TabIndex = 2;
            this.TxtBox.Text = "jizdy.txt";
            // 
            // LblDatumOUT
            // 
            this.LblDatumOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDatumOUT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDatumOUT.Location = new System.Drawing.Point(170, 165);
            this.LblDatumOUT.Name = "LblDatumOUT";
            this.LblDatumOUT.Size = new System.Drawing.Size(108, 343);
            this.LblDatumOUT.TabIndex = 3;
            this.LblDatumOUT.Tag = "0";
            // 
            // LblZboziOUT
            // 
            this.LblZboziOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblZboziOUT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblZboziOUT.Location = new System.Drawing.Point(322, 165);
            this.LblZboziOUT.Name = "LblZboziOUT";
            this.LblZboziOUT.Size = new System.Drawing.Size(108, 343);
            this.LblZboziOUT.TabIndex = 4;
            this.LblZboziOUT.Tag = "0";
            // 
            // LblAutoOUT
            // 
            this.LblAutoOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAutoOUT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAutoOUT.Location = new System.Drawing.Point(447, 165);
            this.LblAutoOUT.Name = "LblAutoOUT";
            this.LblAutoOUT.Size = new System.Drawing.Size(108, 343);
            this.LblAutoOUT.TabIndex = 5;
            this.LblAutoOUT.Tag = "0";
            // 
            // LblSpzOUT
            // 
            this.LblSpzOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSpzOUT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSpzOUT.Location = new System.Drawing.Point(588, 165);
            this.LblSpzOUT.Name = "LblSpzOUT";
            this.LblSpzOUT.Size = new System.Drawing.Size(108, 343);
            this.LblSpzOUT.TabIndex = 6;
            this.LblSpzOUT.Tag = "0";
            // 
            // CheckBoxRidic
            // 
            this.CheckBoxRidic.AutoSize = true;
            this.CheckBoxRidic.Checked = true;
            this.CheckBoxRidic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxRidic.Location = new System.Drawing.Point(37, 516);
            this.CheckBoxRidic.Name = "CheckBoxRidic";
            this.CheckBoxRidic.Size = new System.Drawing.Size(95, 19);
            this.CheckBoxRidic.TabIndex = 7;
            this.CheckBoxRidic.Text = "VIDITELNOST";
            this.CheckBoxRidic.UseVisualStyleBackColor = true;
            this.CheckBoxRidic.CheckedChanged += new System.EventHandler(this.CheckBoxCheck);
            // 
            // CheckBoxDatum
            // 
            this.CheckBoxDatum.AutoSize = true;
            this.CheckBoxDatum.Checked = true;
            this.CheckBoxDatum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxDatum.Location = new System.Drawing.Point(170, 516);
            this.CheckBoxDatum.Name = "CheckBoxDatum";
            this.CheckBoxDatum.Size = new System.Drawing.Size(95, 19);
            this.CheckBoxDatum.TabIndex = 8;
            this.CheckBoxDatum.Text = "VIDITELNOST";
            this.CheckBoxDatum.UseVisualStyleBackColor = true;
            this.CheckBoxDatum.CheckedChanged += new System.EventHandler(this.CheckBoxCheck);
            // 
            // CheckBoxZbozi
            // 
            this.CheckBoxZbozi.AutoSize = true;
            this.CheckBoxZbozi.Checked = true;
            this.CheckBoxZbozi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxZbozi.Location = new System.Drawing.Point(322, 516);
            this.CheckBoxZbozi.Name = "CheckBoxZbozi";
            this.CheckBoxZbozi.Size = new System.Drawing.Size(95, 19);
            this.CheckBoxZbozi.TabIndex = 9;
            this.CheckBoxZbozi.Text = "VIDITELNOST";
            this.CheckBoxZbozi.UseVisualStyleBackColor = true;
            this.CheckBoxZbozi.CheckedChanged += new System.EventHandler(this.CheckBoxCheck);
            // 
            // CheckBoxAuto
            // 
            this.CheckBoxAuto.AutoSize = true;
            this.CheckBoxAuto.Checked = true;
            this.CheckBoxAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxAuto.Location = new System.Drawing.Point(447, 516);
            this.CheckBoxAuto.Name = "CheckBoxAuto";
            this.CheckBoxAuto.Size = new System.Drawing.Size(95, 19);
            this.CheckBoxAuto.TabIndex = 10;
            this.CheckBoxAuto.Text = "VIDITELNOST";
            this.CheckBoxAuto.UseVisualStyleBackColor = true;
            this.CheckBoxAuto.CheckedChanged += new System.EventHandler(this.CheckBoxCheck);
            // 
            // CheckBoxSpz
            // 
            this.CheckBoxSpz.AutoSize = true;
            this.CheckBoxSpz.Checked = true;
            this.CheckBoxSpz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxSpz.Location = new System.Drawing.Point(588, 516);
            this.CheckBoxSpz.Name = "CheckBoxSpz";
            this.CheckBoxSpz.Size = new System.Drawing.Size(95, 19);
            this.CheckBoxSpz.TabIndex = 11;
            this.CheckBoxSpz.Text = "VIDITELNOST";
            this.CheckBoxSpz.UseVisualStyleBackColor = true;
            this.CheckBoxSpz.CheckedChanged += new System.EventHandler(this.CheckBoxCheck);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(170, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(338, 80);
            this.Label.TabIndex = 12;
            this.Label.Text = "Načítač Jízd";
            // 
            // CMBBox1
            // 
            this.CMBBox1.FormattingEnabled = true;
            this.CMBBox1.Items.AddRange(new object[] {
            "Datum",
            "Řidic",
            "Zbozi",
            "Auto",
            "SPZ"});
            this.CMBBox1.Location = new System.Drawing.Point(37, 127);
            this.CMBBox1.Name = "CMBBox1";
            this.CMBBox1.Size = new System.Drawing.Size(108, 23);
            this.CMBBox1.TabIndex = 13;
            this.CMBBox1.Tag = "0";
            // 
            // CMBBox2
            // 
            this.CMBBox2.FormattingEnabled = true;
            this.CMBBox2.Items.AddRange(new object[] {
            "Datum",
            "Řidic",
            "Zbozi",
            "Auto",
            "SPZ"});
            this.CMBBox2.Location = new System.Drawing.Point(170, 127);
            this.CMBBox2.Name = "CMBBox2";
            this.CMBBox2.Size = new System.Drawing.Size(108, 23);
            this.CMBBox2.TabIndex = 14;
            this.CMBBox2.Tag = "1";
            // 
            // CMBBox3
            // 
            this.CMBBox3.FormattingEnabled = true;
            this.CMBBox3.Items.AddRange(new object[] {
            "Datum",
            "Řidic",
            "Zbozi",
            "Auto",
            "SPZ"});
            this.CMBBox3.Location = new System.Drawing.Point(322, 127);
            this.CMBBox3.Name = "CMBBox3";
            this.CMBBox3.Size = new System.Drawing.Size(108, 23);
            this.CMBBox3.TabIndex = 15;
            this.CMBBox3.Tag = "2";
            // 
            // CMBBox4
            // 
            this.CMBBox4.FormattingEnabled = true;
            this.CMBBox4.Items.AddRange(new object[] {
            "Datum",
            "Řidic",
            "Zbozi",
            "Auto",
            "SPZ"});
            this.CMBBox4.Location = new System.Drawing.Point(447, 127);
            this.CMBBox4.Name = "CMBBox4";
            this.CMBBox4.Size = new System.Drawing.Size(108, 23);
            this.CMBBox4.TabIndex = 16;
            this.CMBBox4.Tag = "3";
            // 
            // CMBBox5
            // 
            this.CMBBox5.FormattingEnabled = true;
            this.CMBBox5.Items.AddRange(new object[] {
            "Datum",
            "Řidic",
            "Zbozi",
            "Auto",
            "SPZ"});
            this.CMBBox5.Location = new System.Drawing.Point(588, 127);
            this.CMBBox5.Name = "CMBBox5";
            this.CMBBox5.Size = new System.Drawing.Size(108, 23);
            this.CMBBox5.TabIndex = 17;
            this.CMBBox5.Tag = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 552);
            this.Controls.Add(this.CMBBox5);
            this.Controls.Add(this.CMBBox4);
            this.Controls.Add(this.CMBBox3);
            this.Controls.Add(this.CMBBox2);
            this.Controls.Add(this.CMBBox1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.CheckBoxSpz);
            this.Controls.Add(this.CheckBoxAuto);
            this.Controls.Add(this.CheckBoxZbozi);
            this.Controls.Add(this.CheckBoxDatum);
            this.Controls.Add(this.CheckBoxRidic);
            this.Controls.Add(this.LblSpzOUT);
            this.Controls.Add(this.LblAutoOUT);
            this.Controls.Add(this.LblZboziOUT);
            this.Controls.Add(this.LblDatumOUT);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.LblRidicOUT);
            this.Controls.Add(this.ButtPress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtPress;
        private Label LblRidicOUT;
        private TextBox TxtBox;
        private Label LblDatumOUT;
        private Label LblZboziOUT;
        private Label LblAutoOUT;
        private Label LblSpzOUT;
        private CheckBox CheckBoxRidic;
        private CheckBox CheckBoxDatum;
        private CheckBox CheckBoxZbozi;
        private CheckBox CheckBoxAuto;
        private CheckBox CheckBoxSpz;
        private Label Label;
        private ComboBox CMBBox1;
        private ComboBox CMBBox2;
        private ComboBox CMBBox3;
        private ComboBox CMBBox4;
        private ComboBox CMBBox5;
    }
}