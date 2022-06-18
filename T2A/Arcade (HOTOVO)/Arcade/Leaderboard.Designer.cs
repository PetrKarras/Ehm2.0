namespace Arcade
{
    partial class Leaderboard
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
            this.LblOut = new System.Windows.Forms.Label();
            this.PicBoxEnd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // LblOut
            // 
            this.LblOut.BackColor = System.Drawing.Color.Transparent;
            this.LblOut.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOut.Location = new System.Drawing.Point(250, 140);
            this.LblOut.Name = "LblOut";
            this.LblOut.Size = new System.Drawing.Size(168, 78);
            this.LblOut.TabIndex = 0;
            // 
            // PicBoxEnd
            // 
            this.PicBoxEnd.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxEnd.BackgroundImage = global::Arcade.Properties.Resources.Button;
            this.PicBoxEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxEnd.Location = new System.Drawing.Point(250, 361);
            this.PicBoxEnd.Name = "PicBoxEnd";
            this.PicBoxEnd.Size = new System.Drawing.Size(239, 50);
            this.PicBoxEnd.TabIndex = 1;
            this.PicBoxEnd.TabStop = false;
            this.PicBoxEnd.Click += new System.EventHandler(this.PicBoxEnd_Click);
            this.PicBoxEnd.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBoxEnd_Paint);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arcade.Properties.Resources.Automat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicBoxEnd);
            this.Controls.Add(this.LblOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label LblOut;
        private PictureBox PicBoxEnd;
    }
}