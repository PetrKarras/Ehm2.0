
namespace ISBN_10
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
            this.TxtBoxISBN = new System.Windows.Forms.TextBox();
            this.Nadpis = new System.Windows.Forms.Label();
            this.ButtDek = new System.Windows.Forms.Button();
            this.ButtExp = new System.Windows.Forms.Button();
            this.ButtDel = new System.Windows.Forms.Button();
            this.ListOut = new System.Windows.Forms.ListBox();
            this.TxtBoxNazev = new System.Windows.Forms.TextBox();
            this.LblISBN = new System.Windows.Forms.Label();
            this.LblNazev = new System.Windows.Forms.Label();
            this.ButtClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxISBN
            // 
            this.TxtBoxISBN.Location = new System.Drawing.Point(367, 117);
            this.TxtBoxISBN.MaxLength = 18;
            this.TxtBoxISBN.Name = "TxtBoxISBN";
            this.TxtBoxISBN.Size = new System.Drawing.Size(320, 23);
            this.TxtBoxISBN.TabIndex = 0;
            this.TxtBoxISBN.Text = "ISBN 80-204-0105-9";
            // 
            // Nadpis
            // 
            this.Nadpis.AutoSize = true;
            this.Nadpis.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nadpis.Location = new System.Drawing.Point(415, 48);
            this.Nadpis.Name = "Nadpis";
            this.Nadpis.Size = new System.Drawing.Size(239, 37);
            this.Nadpis.TabIndex = 1;
            this.Nadpis.Text = "Dekodér ISBN-10";
            // 
            // ButtDek
            // 
            this.ButtDek.Location = new System.Drawing.Point(367, 200);
            this.ButtDek.Name = "ButtDek";
            this.ButtDek.Size = new System.Drawing.Size(75, 23);
            this.ButtDek.TabIndex = 2;
            this.ButtDek.Text = "Dekódovat";
            this.ButtDek.UseVisualStyleBackColor = true;
            this.ButtDek.Click += new System.EventHandler(this.ButtDek_Click);
            // 
            // ButtExp
            // 
            this.ButtExp.Location = new System.Drawing.Point(367, 258);
            this.ButtExp.Name = "ButtExp";
            this.ButtExp.Size = new System.Drawing.Size(75, 23);
            this.ButtExp.TabIndex = 3;
            this.ButtExp.Text = "Exportovat";
            this.ButtExp.UseVisualStyleBackColor = true;
            this.ButtExp.Click += new System.EventHandler(this.ButtExp_Click);
            // 
            // ButtDel
            // 
            this.ButtDel.Location = new System.Drawing.Point(367, 229);
            this.ButtDel.Name = "ButtDel";
            this.ButtDel.Size = new System.Drawing.Size(75, 23);
            this.ButtDel.TabIndex = 4;
            this.ButtDel.Text = "Odstranit";
            this.ButtDel.UseVisualStyleBackColor = true;
            this.ButtDel.Click += new System.EventHandler(this.ButtDel_Click);
            // 
            // ListOut
            // 
            this.ListOut.FormattingEnabled = true;
            this.ListOut.ItemHeight = 15;
            this.ListOut.Location = new System.Drawing.Point(448, 200);
            this.ListOut.Name = "ListOut";
            this.ListOut.Size = new System.Drawing.Size(239, 424);
            this.ListOut.TabIndex = 5;
            this.ListOut.SelectedIndexChanged += new System.EventHandler(this.ListOut_SelectedIndexChanged);
            this.ListOut.DoubleClick += new System.EventHandler(this.ListOut_DoubleClick);
            // 
            // TxtBoxNazev
            // 
            this.TxtBoxNazev.Location = new System.Drawing.Point(367, 146);
            this.TxtBoxNazev.Name = "TxtBoxNazev";
            this.TxtBoxNazev.Size = new System.Drawing.Size(320, 23);
            this.TxtBoxNazev.TabIndex = 7;
            this.TxtBoxNazev.Text = "kokos";
            // 
            // LblISBN
            // 
            this.LblISBN.Location = new System.Drawing.Point(261, 117);
            this.LblISBN.Name = "LblISBN";
            this.LblISBN.Size = new System.Drawing.Size(100, 23);
            this.LblISBN.TabIndex = 8;
            this.LblISBN.Text = "ISBN kod";
            // 
            // LblNazev
            // 
            this.LblNazev.Location = new System.Drawing.Point(261, 149);
            this.LblNazev.Name = "LblNazev";
            this.LblNazev.Size = new System.Drawing.Size(100, 23);
            this.LblNazev.TabIndex = 9;
            this.LblNazev.Text = "Název knihy";
            // 
            // ButtClear
            // 
            this.ButtClear.Location = new System.Drawing.Point(367, 288);
            this.ButtClear.Name = "ButtClear";
            this.ButtClear.Size = new System.Drawing.Size(75, 23);
            this.ButtClear.TabIndex = 10;
            this.ButtClear.Text = "Vyčistit";
            this.ButtClear.UseVisualStyleBackColor = true;
            this.ButtClear.Click += new System.EventHandler(this.ButtClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 658);
            this.Controls.Add(this.ButtClear);
            this.Controls.Add(this.LblNazev);
            this.Controls.Add(this.LblISBN);
            this.Controls.Add(this.TxtBoxNazev);
            this.Controls.Add(this.ListOut);
            this.Controls.Add(this.ButtDel);
            this.Controls.Add(this.ButtExp);
            this.Controls.Add(this.ButtDek);
            this.Controls.Add(this.Nadpis);
            this.Controls.Add(this.TxtBoxISBN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxISBN;
        private System.Windows.Forms.Label Nadpis;
        private System.Windows.Forms.Button ButtDek;
        private System.Windows.Forms.Button ButtExp;
        private System.Windows.Forms.Button ButtDel;
        private System.Windows.Forms.ListBox ListOut;
        private System.Windows.Forms.TextBox TxtBoxNazev;
        private System.Windows.Forms.Label LblISBN;
        private System.Windows.Forms.Label LblNazev;
        private System.Windows.Forms.Button ButtClear;
    }
}

