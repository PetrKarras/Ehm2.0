namespace Arcade
{
    partial class JumpingME
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.PicBoxME = new System.Windows.Forms.PictureBox();
            this.PicBoxDown = new System.Windows.Forms.PictureBox();
            this.PicBoxDown1 = new System.Windows.Forms.PictureBox();
            this.LblScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerGif = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // PicBoxME
            // 
            this.PicBoxME.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxME.BackgroundImage = global::Arcade.Properties.Resources.JumpingMeSTOP;
            this.PicBoxME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxME.Location = new System.Drawing.Point(35, 207);
            this.PicBoxME.Name = "PicBoxME";
            this.PicBoxME.Size = new System.Drawing.Size(100, 200);
            this.PicBoxME.TabIndex = 0;
            this.PicBoxME.TabStop = false;
            // 
            // PicBoxDown
            // 
            this.PicBoxDown.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxDown.BackgroundImage = global::Arcade.Properties.Resources.Auto1;
            this.PicBoxDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxDown.Location = new System.Drawing.Point(297, 307);
            this.PicBoxDown.Name = "PicBoxDown";
            this.PicBoxDown.Size = new System.Drawing.Size(200, 100);
            this.PicBoxDown.TabIndex = 1;
            this.PicBoxDown.TabStop = false;
            this.PicBoxDown.Tag = "1";
            // 
            // PicBoxDown1
            // 
            this.PicBoxDown1.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxDown1.BackgroundImage = global::Arcade.Properties.Resources.Auto1;
            this.PicBoxDown1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxDown1.Location = new System.Drawing.Point(567, 307);
            this.PicBoxDown1.Name = "PicBoxDown1";
            this.PicBoxDown1.Size = new System.Drawing.Size(200, 100);
            this.PicBoxDown1.TabIndex = 2;
            this.PicBoxDown1.TabStop = false;
            this.PicBoxDown1.Tag = "1";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.BackColor = System.Drawing.Color.Transparent;
            this.LblScore.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblScore.Location = new System.Drawing.Point(12, 9);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(151, 60);
            this.LblScore.TabIndex = 3;
            this.LblScore.Text = "Score:";
            // 
            // TimerGif
            // 
            this.TimerGif.Tick += new System.EventHandler(this.TimerGif_Tick);
            // 
            // JumpingME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arcade.Properties.Resources.JumpingMEForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.PicBoxDown1);
            this.Controls.Add(this.PicBoxDown);
            this.Controls.Add(this.PicBoxME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JumpingME";
            this.Text = "JumpingME";
            this.Load += new System.EventHandler(this.JumpingME_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JumpingME_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.JumpingME_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private PictureBox PicBoxME;
        private PictureBox PicBoxDown;
        private PictureBox PicBoxDown1;
        private Label LblScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer TimerGif;
    }
}