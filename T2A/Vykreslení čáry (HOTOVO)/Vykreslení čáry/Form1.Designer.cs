namespace Vykreslení_čáry
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
            this.TxtboxIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtPress = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.ButtColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.PanBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBack
            // 
            this.PanBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanBack.Controls.Add(this.PanFront);
            this.PanBack.Location = new System.Drawing.Point(12, 12);
            this.PanBack.Name = "PanBack";
            this.PanBack.Size = new System.Drawing.Size(597, 426);
            this.PanBack.TabIndex = 0;
            // 
            // PanFront
            // 
            this.PanFront.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanFront.Location = new System.Drawing.Point(3, 3);
            this.PanFront.Name = "PanFront";
            this.PanFront.Size = new System.Drawing.Size(591, 420);
            this.PanFront.TabIndex = 0;
            this.PanFront.Paint += new System.Windows.Forms.PaintEventHandler(this.PanFront_Paint);
            // 
            // TxtboxIn
            // 
            this.TxtboxIn.Location = new System.Drawing.Point(615, 40);
            this.TxtboxIn.Name = "TxtboxIn";
            this.TxtboxIn.Size = new System.Drawing.Size(182, 23);
            this.TxtboxIn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadej hodnotu";
            // 
            // ButtPress
            // 
            this.ButtPress.Location = new System.Drawing.Point(612, 336);
            this.ButtPress.Name = "ButtPress";
            this.ButtPress.Size = new System.Drawing.Size(182, 43);
            this.ButtPress.TabIndex = 3;
            this.ButtPress.Text = "Vykresli";
            this.ButtPress.UseVisualStyleBackColor = true;
            this.ButtPress.Click += new System.EventHandler(this.ButtPress_Click);
            // 
            // ButtColor
            // 
            this.ButtColor.Location = new System.Drawing.Point(612, 385);
            this.ButtColor.Name = "ButtColor";
            this.ButtColor.Size = new System.Drawing.Size(182, 49);
            this.ButtColor.TabIndex = 4;
            this.ButtColor.Text = "Barvičky";
            this.ButtColor.UseVisualStyleBackColor = true;
            this.ButtColor.Click += new System.EventHandler(this.ButtColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tlouštka";
            // 
            // NumUpDown
            // 
            this.NumUpDown.Location = new System.Drawing.Point(615, 97);
            this.NumUpDown.Name = "NumUpDown";
            this.NumUpDown.Size = new System.Drawing.Size(182, 23);
            this.NumUpDown.TabIndex = 7;
            this.NumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtColor);
            this.Controls.Add(this.ButtPress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtboxIn);
            this.Controls.Add(this.PanBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanBack;
        private Panel PanFront;
        private TextBox TxtboxIn;
        private Label label1;
        private Button ButtPress;
        private ColorDialog ColorDialog;
        private Button ButtColor;
        private Label label2;
        private NumericUpDown NumUpDown;
    }
}