namespace Mozaika
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
            ButtDraw = new Button();
            PanelOut = new Panel();
            RTextBox = new RichTextBox();
            label1 = new Label();
            ButtEdit = new Button();
            ButtFile = new Button();
            PanelOut.SuspendLayout();
            SuspendLayout();
            // 
            // ButtDraw
            // 
            ButtDraw.Enabled = false;
            ButtDraw.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtDraw.Location = new Point(428, 364);
            ButtDraw.Name = "ButtDraw";
            ButtDraw.Size = new Size(143, 48);
            ButtDraw.TabIndex = 0;
            ButtDraw.Text = "Kresli";
            ButtDraw.UseVisualStyleBackColor = true;
            ButtDraw.Click += ButtDraw_Click;
            // 
            // PanelOut
            // 
            PanelOut.BackColor = Color.FromArgb(224, 224, 224);
            PanelOut.Controls.Add(RTextBox);
            PanelOut.ForeColor = Color.FromArgb(224, 224, 224);
            PanelOut.Location = new Point(22, 12);
            PanelOut.Name = "PanelOut";
            PanelOut.Size = new Size(400, 400);
            PanelOut.TabIndex = 1;
            PanelOut.Paint += PanelOut_Paint;
            // 
            // RTextBox
            // 
            RTextBox.Location = new Point(0, 0);
            RTextBox.MaxLength = 421;
            RTextBox.Name = "RTextBox";
            RTextBox.Size = new Size(400, 400);
            RTextBox.TabIndex = 0;
            RTextBox.Text = "";
            RTextBox.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(446, 12);
            label1.Name = "label1";
            label1.Size = new Size(105, 34);
            label1.TabIndex = 2;
            label1.Text = "Mozaika";
            // 
            // ButtEdit
            // 
            ButtEdit.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtEdit.Location = new Point(428, 310);
            ButtEdit.Name = "ButtEdit";
            ButtEdit.Size = new Size(143, 48);
            ButtEdit.TabIndex = 5;
            ButtEdit.Text = "Edit";
            ButtEdit.UseVisualStyleBackColor = true;
            ButtEdit.Click += ButtEdit_Click;
            // 
            // ButtFile
            // 
            ButtFile.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtFile.Location = new Point(428, 256);
            ButtFile.Name = "ButtFile";
            ButtFile.Size = new Size(143, 48);
            ButtFile.TabIndex = 3;
            ButtFile.Text = "Soubor";
            ButtFile.UseVisualStyleBackColor = true;
            ButtFile.Click += ButtFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 426);
            Controls.Add(ButtEdit);
            Controls.Add(ButtFile);
            Controls.Add(label1);
            Controls.Add(PanelOut);
            Controls.Add(ButtDraw);
            Name = "Form1";
            Text = "Form1";
            PanelOut.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtDraw;
        private Panel PanelOut;
        private Label label1;
        private Button ButtEdit;
        private RichTextBox RTextBox;
        private Button ButtFile;
    }
}