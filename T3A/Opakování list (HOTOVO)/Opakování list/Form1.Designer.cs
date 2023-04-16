
namespace Opakování_list
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
            this.ButtAdd = new System.Windows.Forms.Button();
            this.ButtRmv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtTeam = new System.Windows.Forms.Button();
            this.NumUD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTymOut = new System.Windows.Forms.Label();
            this.LblHracOut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtAdd
            // 
            this.ButtAdd.Location = new System.Drawing.Point(267, 25);
            this.ButtAdd.Name = "ButtAdd";
            this.ButtAdd.Size = new System.Drawing.Size(50, 50);
            this.ButtAdd.TabIndex = 0;
            this.ButtAdd.Text = "+";
            this.ButtAdd.UseVisualStyleBackColor = true;
            this.ButtAdd.Click += new System.EventHandler(this.ButtAdd_Click);
            // 
            // ButtRmv
            // 
            this.ButtRmv.Location = new System.Drawing.Point(323, 25);
            this.ButtRmv.Name = "ButtRmv";
            this.ButtRmv.Size = new System.Drawing.Size(50, 50);
            this.ButtRmv.TabIndex = 1;
            this.ButtRmv.Text = "-";
            this.ButtRmv.UseVisualStyleBackColor = true;
            this.ButtRmv.Click += new System.EventHandler(this.ButtRmv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jméno";
            // 
            // ButtTeam
            // 
            this.ButtTeam.Location = new System.Drawing.Point(267, 104);
            this.ButtTeam.Name = "ButtTeam";
            this.ButtTeam.Size = new System.Drawing.Size(106, 43);
            this.ButtTeam.TabIndex = 3;
            this.ButtTeam.Text = "Rozděl týmy";
            this.ButtTeam.UseVisualStyleBackColor = true;
            this.ButtTeam.Click += new System.EventHandler(this.ButtTeam_Click);
            // 
            // NumUD
            // 
            this.NumUD.Location = new System.Drawing.Point(121, 61);
            this.NumUD.Name = "NumUD";
            this.NumUD.Size = new System.Drawing.Size(120, 23);
            this.NumUD.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Počet týmů";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rozdělení týmů";
            // 
            // LblTymOut
            // 
            this.LblTymOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTymOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTymOut.Location = new System.Drawing.Point(12, 150);
            this.LblTymOut.Name = "LblTymOut";
            this.LblTymOut.Size = new System.Drawing.Size(368, 219);
            this.LblTymOut.TabIndex = 11;
            // 
            // LblHracOut
            // 
            this.LblHracOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHracOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHracOut.Location = new System.Drawing.Point(405, 68);
            this.LblHracOut.Name = "LblHracOut";
            this.LblHracOut.Size = new System.Drawing.Size(189, 301);
            this.LblHracOut.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(405, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seznam hráčů";
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(121, 25);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(120, 23);
            this.TxtBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 386);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblHracOut);
            this.Controls.Add(this.LblTymOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumUD);
            this.Controls.Add(this.ButtTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtRmv);
            this.Controls.Add(this.ButtAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtAdd;
        private System.Windows.Forms.Button ButtRmv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtTeam;
        private System.Windows.Forms.NumericUpDown NumUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTymOut;
        private System.Windows.Forms.Label LblHracOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBox;
    }
}

