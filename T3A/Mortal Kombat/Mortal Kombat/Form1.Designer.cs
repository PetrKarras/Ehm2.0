
namespace Mortal_Kombat
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
            this.ButtFight = new System.Windows.Forms.Button();
            this.LblPlayer1 = new System.Windows.Forms.Label();
            this.LblPlayer2 = new System.Windows.Forms.Label();
            this.LblLog = new System.Windows.Forms.Label();
            this.TxtBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.TxtBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.ButtChange = new System.Windows.Forms.Button();
            this.ComBoxPlayer1 = new System.Windows.Forms.ComboBox();
            this.ComBoxPlayer2 = new System.Windows.Forms.ComboBox();
            this.ButtNewPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtFight
            // 
            this.ButtFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ButtFight.Location = new System.Drawing.Point(197, 2);
            this.ButtFight.Name = "ButtFight";
            this.ButtFight.Size = new System.Drawing.Size(156, 44);
            this.ButtFight.TabIndex = 0;
            this.ButtFight.Text = "FIGHT";
            this.ButtFight.UseVisualStyleBackColor = true;
            this.ButtFight.Click += new System.EventHandler(this.ButtFight_Click);
            // 
            // LblPlayer1
            // 
            this.LblPlayer1.AutoSize = true;
            this.LblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblPlayer1.Location = new System.Drawing.Point(12, 59);
            this.LblPlayer1.Name = "LblPlayer1";
            this.LblPlayer1.Size = new System.Drawing.Size(61, 18);
            this.LblPlayer1.TabIndex = 1;
            this.LblPlayer1.Text = "Player 1";
            // 
            // LblPlayer2
            // 
            this.LblPlayer2.AutoSize = true;
            this.LblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblPlayer2.Location = new System.Drawing.Point(642, 59);
            this.LblPlayer2.Name = "LblPlayer2";
            this.LblPlayer2.Size = new System.Drawing.Size(61, 18);
            this.LblPlayer2.TabIndex = 2;
            this.LblPlayer2.Text = "Player 2";
            // 
            // LblLog
            // 
            this.LblLog.AutoSize = true;
            this.LblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblLog.Location = new System.Drawing.Point(297, 49);
            this.LblLog.Name = "LblLog";
            this.LblLog.Size = new System.Drawing.Size(12, 18);
            this.LblLog.TabIndex = 3;
            this.LblLog.Text = "t";
            // 
            // TxtBoxPlayer1
            // 
            this.TxtBoxPlayer1.Location = new System.Drawing.Point(12, 2);
            this.TxtBoxPlayer1.Name = "TxtBoxPlayer1";
            this.TxtBoxPlayer1.PlaceholderText = "Jméno hráče 1";
            this.TxtBoxPlayer1.Size = new System.Drawing.Size(100, 23);
            this.TxtBoxPlayer1.TabIndex = 4;
            // 
            // TxtBoxPlayer2
            // 
            this.TxtBoxPlayer2.Location = new System.Drawing.Point(642, 2);
            this.TxtBoxPlayer2.Name = "TxtBoxPlayer2";
            this.TxtBoxPlayer2.PlaceholderText = "Jméno Hráče 2";
            this.TxtBoxPlayer2.Size = new System.Drawing.Size(100, 23);
            this.TxtBoxPlayer2.TabIndex = 5;
            // 
            // ButtChange
            // 
            this.ButtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ButtChange.Location = new System.Drawing.Point(306, 405);
            this.ButtChange.Name = "ButtChange";
            this.ButtChange.Size = new System.Drawing.Size(156, 44);
            this.ButtChange.TabIndex = 6;
            this.ButtChange.Text = "Změna jmen";
            this.ButtChange.UseVisualStyleBackColor = true;
            this.ButtChange.Click += new System.EventHandler(this.ButtChange_Click);
            // 
            // ComBoxPlayer1
            // 
            this.ComBoxPlayer1.FormattingEnabled = true;
            this.ComBoxPlayer1.Location = new System.Drawing.Point(12, 31);
            this.ComBoxPlayer1.Name = "ComBoxPlayer1";
            this.ComBoxPlayer1.Size = new System.Drawing.Size(121, 23);
            this.ComBoxPlayer1.TabIndex = 7;
            // 
            // ComBoxPlayer2
            // 
            this.ComBoxPlayer2.FormattingEnabled = true;
            this.ComBoxPlayer2.Location = new System.Drawing.Point(642, 31);
            this.ComBoxPlayer2.Name = "ComBoxPlayer2";
            this.ComBoxPlayer2.Size = new System.Drawing.Size(121, 23);
            this.ComBoxPlayer2.TabIndex = 9;
            // 
            // ButtNewPlayer
            // 
            this.ButtNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ButtNewPlayer.Location = new System.Drawing.Point(378, 2);
            this.ButtNewPlayer.Name = "ButtNewPlayer";
            this.ButtNewPlayer.Size = new System.Drawing.Size(156, 44);
            this.ButtNewPlayer.TabIndex = 10;
            this.ButtNewPlayer.Text = "Nový hráč";
            this.ButtNewPlayer.UseVisualStyleBackColor = true;
            this.ButtNewPlayer.Click += new System.EventHandler(this.ButtNewPlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ButtNewPlayer);
            this.Controls.Add(this.ComBoxPlayer2);
            this.Controls.Add(this.ComBoxPlayer1);
            this.Controls.Add(this.ButtChange);
            this.Controls.Add(this.TxtBoxPlayer2);
            this.Controls.Add(this.TxtBoxPlayer1);
            this.Controls.Add(this.LblLog);
            this.Controls.Add(this.LblPlayer2);
            this.Controls.Add(this.LblPlayer1);
            this.Controls.Add(this.ButtFight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtFight;
        private System.Windows.Forms.Label LblPlayer1;
        private System.Windows.Forms.Label LblPlayer2;
        private System.Windows.Forms.Label LblLog;
        private System.Windows.Forms.TextBox TxtBoxPlayer1;
        private System.Windows.Forms.TextBox TxtBoxPlayer2;
        private System.Windows.Forms.Button ButtChange;
        private System.Windows.Forms.ComboBox ComBoxPlayer1;
        private System.Windows.Forms.ComboBox ComBoxPlayer2;
        private System.Windows.Forms.Button ButtNewPlayer;
    }
}

