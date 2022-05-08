namespace Terč
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
            this.Butt = new System.Windows.Forms.Button();
            this.ColDiaFront = new System.Windows.Forms.ColorDialog();
            this.ColDiaBack = new System.Windows.Forms.ColorDialog();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.LblCol1 = new System.Windows.Forms.Label();
            this.LblCol2 = new System.Windows.Forms.Label();
            this.PanBack = new System.Windows.Forms.Panel();
            this.PanFront = new System.Windows.Forms.Panel();
            this.RadRec = new System.Windows.Forms.RadioButton();
            this.RadCrl = new System.Windows.Forms.RadioButton();
            this.RadTri = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).BeginInit();
            this.PanBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // Butt
            // 
            this.Butt.Location = new System.Drawing.Point(481, 48);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(100, 23);
            this.Butt.TabIndex = 0;
            this.Butt.Text = "Vykresli terč";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // ColDiaFront
            // 
            this.ColDiaFront.Color = System.Drawing.Color.Red;
            // 
            // ColDiaBack
            // 
            this.ColDiaBack.Color = System.Drawing.Color.Lime;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            // 
            // NumUpDown
            // 
            this.NumUpDown.Location = new System.Drawing.Point(481, 12);
            this.NumUpDown.Name = "NumUpDown";
            this.NumUpDown.Size = new System.Drawing.Size(100, 23);
            this.NumUpDown.TabIndex = 1;
            // 
            // LblCol1
            // 
            this.LblCol1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCol1.Location = new System.Drawing.Point(481, 89);
            this.LblCol1.Name = "LblCol1";
            this.LblCol1.Size = new System.Drawing.Size(100, 23);
            this.LblCol1.TabIndex = 2;
            this.LblCol1.Click += new System.EventHandler(this.LblCol1_Click);
            // 
            // LblCol2
            // 
            this.LblCol2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCol2.Location = new System.Drawing.Point(481, 123);
            this.LblCol2.Name = "LblCol2";
            this.LblCol2.Size = new System.Drawing.Size(100, 23);
            this.LblCol2.TabIndex = 3;
            this.LblCol2.Click += new System.EventHandler(this.LblCol2_Click);
            // 
            // PanBack
            // 
            this.PanBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanBack.Controls.Add(this.PanFront);
            this.PanBack.Location = new System.Drawing.Point(3, 1);
            this.PanBack.Name = "PanBack";
            this.PanBack.Size = new System.Drawing.Size(472, 448);
            this.PanBack.TabIndex = 4;
            // 
            // PanFront
            // 
            this.PanFront.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanFront.Location = new System.Drawing.Point(3, 3);
            this.PanFront.Name = "PanFront";
            this.PanFront.Size = new System.Drawing.Size(466, 442);
            this.PanFront.TabIndex = 0;
            this.PanFront.Paint += new System.Windows.Forms.PaintEventHandler(this.PanFront_Paint);
            // 
            // RadRec
            // 
            this.RadRec.AutoSize = true;
            this.RadRec.Location = new System.Drawing.Point(487, 169);
            this.RadRec.Name = "RadRec";
            this.RadRec.Size = new System.Drawing.Size(65, 19);
            this.RadRec.TabIndex = 5;
            this.RadRec.TabStop = true;
            this.RadRec.Text = "Čtverec";
            this.RadRec.UseVisualStyleBackColor = true;
            // 
            // RadCrl
            // 
            this.RadCrl.AutoSize = true;
            this.RadCrl.Location = new System.Drawing.Point(487, 194);
            this.RadCrl.Name = "RadCrl";
            this.RadCrl.Size = new System.Drawing.Size(50, 19);
            this.RadCrl.TabIndex = 6;
            this.RadCrl.TabStop = true;
            this.RadCrl.Text = "Kruh";
            this.RadCrl.UseVisualStyleBackColor = true;
            // 
            // RadTri
            // 
            this.RadTri.AutoSize = true;
            this.RadTri.Location = new System.Drawing.Point(487, 219);
            this.RadTri.Name = "RadTri";
            this.RadTri.Size = new System.Drawing.Size(83, 19);
            this.RadTri.TabIndex = 7;
            this.RadTri.TabStop = true;
            this.RadTri.Text = "Trojúhelník";
            this.RadTri.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.RadTri);
            this.Controls.Add(this.RadCrl);
            this.Controls.Add(this.RadRec);
            this.Controls.Add(this.PanBack);
            this.Controls.Add(this.LblCol2);
            this.Controls.Add(this.LblCol1);
            this.Controls.Add(this.NumUpDown);
            this.Controls.Add(this.Butt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).EndInit();
            this.PanBack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Butt;
        private ColorDialog ColDiaFront;
        private ColorDialog ColDiaBack;
        private System.Windows.Forms.Timer Timer;
        private NumericUpDown NumUpDown;
        private Label LblCol1;
        private Label LblCol2;
        private Panel PanBack;
        private Panel PanFront;
        private RadioButton RadRec;
        private RadioButton RadCrl;
        private RadioButton RadTri;
    }
}