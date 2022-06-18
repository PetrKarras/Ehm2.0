namespace Arcade
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
            this.PicBoxGame = new System.Windows.Forms.PictureBox();
            this.PicBoxRight = new System.Windows.Forms.PictureBox();
            this.PicBoxLeft = new System.Windows.Forms.PictureBox();
            this.PicBoxInfo = new System.Windows.Forms.PictureBox();
            this.PicBoxLeaderboard = new System.Windows.Forms.PictureBox();
            this.PicBoxEnd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLeaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxGame
            // 
            this.PicBoxGame.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxGame.BackgroundImage = global::Arcade.Properties.Resources.Button;
            this.PicBoxGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxGame.Location = new System.Drawing.Point(804, 350);
            this.PicBoxGame.Name = "PicBoxGame";
            this.PicBoxGame.Size = new System.Drawing.Size(239, 50);
            this.PicBoxGame.TabIndex = 0;
            this.PicBoxGame.TabStop = false;
            this.PicBoxGame.Click += new System.EventHandler(this.PicBoxGame_Click);
            this.PicBoxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBoxGame_Paint);
            // 
            // PicBoxRight
            // 
            this.PicBoxRight.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxRight.BackgroundImage = global::Arcade.Properties.Resources.ArrowR;
            this.PicBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxRight.Location = new System.Drawing.Point(744, 193);
            this.PicBoxRight.Name = "PicBoxRight";
            this.PicBoxRight.Size = new System.Drawing.Size(40, 50);
            this.PicBoxRight.TabIndex = 1;
            this.PicBoxRight.TabStop = false;
            this.PicBoxRight.Click += new System.EventHandler(this.PicBoxRight_Click);
            // 
            // PicBoxLeft
            // 
            this.PicBoxLeft.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxLeft.BackgroundImage = global::Arcade.Properties.Resources.ArrowL;
            this.PicBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxLeft.Location = new System.Drawing.Point(730, 281);
            this.PicBoxLeft.Name = "PicBoxLeft";
            this.PicBoxLeft.Size = new System.Drawing.Size(40, 50);
            this.PicBoxLeft.TabIndex = 2;
            this.PicBoxLeft.TabStop = false;
            this.PicBoxLeft.Click += new System.EventHandler(this.PicBoxLeft_Click);
            // 
            // PicBoxInfo
            // 
            this.PicBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxInfo.BackgroundImage = global::Arcade.Properties.Resources.Info;
            this.PicBoxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxInfo.Location = new System.Drawing.Point(744, 350);
            this.PicBoxInfo.Name = "PicBoxInfo";
            this.PicBoxInfo.Size = new System.Drawing.Size(47, 48);
            this.PicBoxInfo.TabIndex = 3;
            this.PicBoxInfo.TabStop = false;
            this.PicBoxInfo.Tag = "nn";
            this.PicBoxInfo.Click += new System.EventHandler(this.PicBoxInfo_Click);
            // 
            // PicBoxLeaderboard
            // 
            this.PicBoxLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxLeaderboard.BackgroundImage = global::Arcade.Properties.Resources.Button;
            this.PicBoxLeaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxLeaderboard.Location = new System.Drawing.Point(804, 279);
            this.PicBoxLeaderboard.Name = "PicBoxLeaderboard";
            this.PicBoxLeaderboard.Size = new System.Drawing.Size(239, 50);
            this.PicBoxLeaderboard.TabIndex = 4;
            this.PicBoxLeaderboard.TabStop = false;
            this.PicBoxLeaderboard.Click += new System.EventHandler(this.PicBoxLeaderboard_Click);
            this.PicBoxLeaderboard.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBoxLeaderboard_Paint);
            // 
            // PicBoxEnd
            // 
            this.PicBoxEnd.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxEnd.BackgroundImage = global::Arcade.Properties.Resources.Button;
            this.PicBoxEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxEnd.Location = new System.Drawing.Point(804, 195);
            this.PicBoxEnd.Name = "PicBoxEnd";
            this.PicBoxEnd.Size = new System.Drawing.Size(239, 50);
            this.PicBoxEnd.TabIndex = 5;
            this.PicBoxEnd.TabStop = false;
            this.PicBoxEnd.Click += new System.EventHandler(this.PicBoxEnd_Click);
            this.PicBoxEnd.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBoxEnd_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arcade.Properties.Resources.Automat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1169, 671);
            this.Controls.Add(this.PicBoxEnd);
            this.Controls.Add(this.PicBoxLeaderboard);
            this.Controls.Add(this.PicBoxInfo);
            this.Controls.Add(this.PicBoxLeft);
            this.Controls.Add(this.PicBoxRight);
            this.Controls.Add(this.PicBoxGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLeaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PicBoxGame;
        private PictureBox PicBoxRight;
        private PictureBox PicBoxLeft;
        private PictureBox PicBoxInfo;
        private PictureBox PicBoxLeaderboard;
        private PictureBox PicBoxEnd;
    }
}