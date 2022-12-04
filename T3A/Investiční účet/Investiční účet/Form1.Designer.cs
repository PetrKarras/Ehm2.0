namespace Investiční_účet
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
            this.ButtObalka = new System.Windows.Forms.Button();
            this.ButtMoney = new System.Windows.Forms.Button();
            this.TxtBoxNote = new System.Windows.Forms.TextBox();
            this.TxtBoxMoney = new System.Windows.Forms.TextBox();
            this.TxtBoxProcenta = new System.Windows.Forms.TextBox();
            this.LblMoney = new System.Windows.Forms.Label();
            this.LblObalky = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtObalka
            // 
            this.ButtObalka.Location = new System.Drawing.Point(263, 81);
            this.ButtObalka.Name = "ButtObalka";
            this.ButtObalka.Size = new System.Drawing.Size(122, 23);
            this.ButtObalka.TabIndex = 0;
            this.ButtObalka.Text = "Nová obálka";
            this.ButtObalka.UseVisualStyleBackColor = true;
            this.ButtObalka.Click += new System.EventHandler(this.ButtObalka_Click);
            // 
            // ButtMoney
            // 
            this.ButtMoney.Location = new System.Drawing.Point(263, 193);
            this.ButtMoney.Name = "ButtMoney";
            this.ButtMoney.Size = new System.Drawing.Size(122, 23);
            this.ButtMoney.TabIndex = 1;
            this.ButtMoney.Text = "Vklad";
            this.ButtMoney.UseVisualStyleBackColor = true;
            this.ButtMoney.Click += new System.EventHandler(this.ButtMoney_Click);
            // 
            // TxtBoxNote
            // 
            this.TxtBoxNote.Location = new System.Drawing.Point(12, 110);
            this.TxtBoxNote.Name = "TxtBoxNote";
            this.TxtBoxNote.PlaceholderText = "Popisek";
            this.TxtBoxNote.Size = new System.Drawing.Size(161, 23);
            this.TxtBoxNote.TabIndex = 2;
            // 
            // TxtBoxMoney
            // 
            this.TxtBoxMoney.Location = new System.Drawing.Point(12, 194);
            this.TxtBoxMoney.Name = "TxtBoxMoney";
            this.TxtBoxMoney.PlaceholderText = "Peníze";
            this.TxtBoxMoney.Size = new System.Drawing.Size(161, 23);
            this.TxtBoxMoney.TabIndex = 4;
            // 
            // TxtBoxProcenta
            // 
            this.TxtBoxProcenta.Location = new System.Drawing.Point(12, 81);
            this.TxtBoxProcenta.Name = "TxtBoxProcenta";
            this.TxtBoxProcenta.PlaceholderText = "Procenta";
            this.TxtBoxProcenta.Size = new System.Drawing.Size(161, 23);
            this.TxtBoxProcenta.TabIndex = 6;
            // 
            // LblMoney
            // 
            this.LblMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMoney.Location = new System.Drawing.Point(12, 248);
            this.LblMoney.Name = "LblMoney";
            this.LblMoney.Size = new System.Drawing.Size(373, 45);
            this.LblMoney.TabIndex = 7;
            this.LblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblObalky
            // 
            this.LblObalky.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblObalky.Location = new System.Drawing.Point(12, 322);
            this.LblObalky.Name = "LblObalky";
            this.LblObalky.Size = new System.Drawing.Size(373, 203);
            this.LblObalky.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Moje portfolio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblObalky);
            this.Controls.Add(this.LblMoney);
            this.Controls.Add(this.TxtBoxProcenta);
            this.Controls.Add(this.TxtBoxMoney);
            this.Controls.Add(this.TxtBoxNote);
            this.Controls.Add(this.ButtMoney);
            this.Controls.Add(this.ButtObalka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtObalka;
        private Button ButtMoney;
        private TextBox TxtBoxNote;
        private TextBox TxtBoxMoney;
        private TextBox TxtBoxProcenta;
        private Label LblMoney;
        private Label LblObalky;
        private Label label1;
    }
}