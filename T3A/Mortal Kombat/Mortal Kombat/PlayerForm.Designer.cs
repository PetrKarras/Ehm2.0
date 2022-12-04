
namespace Mortal_Kombat
{
    partial class PlayerForm
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
            this.ButtSave = new System.Windows.Forms.Button();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.NumUDDeff = new System.Windows.Forms.NumericUpDown();
            this.NumUDMaxAttack = new System.Windows.Forms.NumericUpDown();
            this.NumUDMinAttack = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPlayer1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDDeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDMaxAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDMinAttack)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtSave
            // 
            this.ButtSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ButtSave.Location = new System.Drawing.Point(12, 202);
            this.ButtSave.Name = "ButtSave";
            this.ButtSave.Size = new System.Drawing.Size(256, 54);
            this.ButtSave.TabIndex = 0;
            this.ButtSave.Text = "Uložit";
            this.ButtSave.UseVisualStyleBackColor = true;
            this.ButtSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(68, 64);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(120, 23);
            this.TxtBoxName.TabIndex = 1;
            // 
            // NumUDDeff
            // 
            this.NumUDDeff.Location = new System.Drawing.Point(68, 95);
            this.NumUDDeff.Name = "NumUDDeff";
            this.NumUDDeff.Size = new System.Drawing.Size(120, 23);
            this.NumUDDeff.TabIndex = 3;
            // 
            // NumUDMaxAttack
            // 
            this.NumUDMaxAttack.Location = new System.Drawing.Point(68, 124);
            this.NumUDMaxAttack.Name = "NumUDMaxAttack";
            this.NumUDMaxAttack.Size = new System.Drawing.Size(120, 23);
            this.NumUDMaxAttack.TabIndex = 4;
            // 
            // NumUDMinAttack
            // 
            this.NumUDMinAttack.Location = new System.Drawing.Point(68, 153);
            this.NumUDMinAttack.Name = "NumUDMinAttack";
            this.NumUDMinAttack.Size = new System.Drawing.Size(120, 23);
            this.NumUDMinAttack.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nový hráč";
            // 
            // LblPlayer1
            // 
            this.LblPlayer1.AutoSize = true;
            this.LblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblPlayer1.Location = new System.Drawing.Point(1, 69);
            this.LblPlayer1.Name = "LblPlayer1";
            this.LblPlayer1.Size = new System.Drawing.Size(54, 18);
            this.LblPlayer1.TabIndex = 7;
            this.LblPlayer1.Text = "Jméno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Obrana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Min síla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Max síla";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 272);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumUDMinAttack);
            this.Controls.Add(this.NumUDMaxAttack);
            this.Controls.Add(this.NumUDDeff);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.ButtSave);
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDDeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDMaxAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDMinAttack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtSave;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.NumericUpDown NumUDDeff;
        private System.Windows.Forms.NumericUpDown NumUDMaxAttack;
        private System.Windows.Forms.NumericUpDown NumUDMinAttack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPlayer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}