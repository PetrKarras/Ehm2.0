namespace CatFishModel
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
            this.ButtGenerate = new System.Windows.Forms.Button();
            this.LblNadpis = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.PicBoxPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtGenerate
            // 
            this.ButtGenerate.Location = new System.Drawing.Point(12, 63);
            this.ButtGenerate.Name = "ButtGenerate";
            this.ButtGenerate.Size = new System.Drawing.Size(208, 23);
            this.ButtGenerate.TabIndex = 0;
            this.ButtGenerate.Text = "Generovat";
            this.ButtGenerate.UseVisualStyleBackColor = true;
            this.ButtGenerate.Click += new System.EventHandler(this.ButtGenerate_Click);
            // 
            // LblNadpis
            // 
            this.LblNadpis.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNadpis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblNadpis.Location = new System.Drawing.Point(12, 9);
            this.LblNadpis.Name = "LblNadpis";
            this.LblNadpis.Size = new System.Drawing.Size(360, 25);
            this.LblNadpis.TabIndex = 1;
            this.LblNadpis.Text = "CatFish Randomiser";
            this.LblNadpis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblInfo
            // 
            this.LblInfo.Location = new System.Drawing.Point(12, 89);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(208, 155);
            this.LblInfo.TabIndex = 5;
            this.LblInfo.Text = "label5";
            // 
            // PicBoxPhoto
            // 
            this.PicBoxPhoto.Location = new System.Drawing.Point(226, 63);
            this.PicBoxPhoto.Name = "PicBoxPhoto";
            this.PicBoxPhoto.Size = new System.Drawing.Size(146, 181);
            this.PicBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxPhoto.TabIndex = 6;
            this.PicBoxPhoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 256);
            this.Controls.Add(this.PicBoxPhoto);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.LblNadpis);
            this.Controls.Add(this.ButtGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtGenerate;
        private Label LblNadpis;
        private Label LblInfo;
        private PictureBox PicBoxPhoto;
    }
}