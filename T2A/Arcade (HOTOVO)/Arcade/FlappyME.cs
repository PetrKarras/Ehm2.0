using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcade
{
    public partial class FlappyME : Form
    {
        public FlappyME(string player)
        {
            InitializeComponent();
            hrac = player;
        }
        string hrac;
        int pipespeed;
        int gravity;
        int score = 0;
        private void FlappyME_Load(object sender, EventArgs e)
        {

            this.SetStyle(
ControlStyles.AllPaintingInWmPaint |
ControlStyles.DoubleBuffer,
true);
            this.Size = new Size(1800, 960);
            this.Location = new Point(75, 80);
            UpravaUI();
        }

        private void FlappyME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W || e.KeyCode == Keys.Up) { gravity = -(5 + score); }

        }

        private void FlappyME_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W || e.KeyCode == Keys.Up) { gravity = +5 + score; }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LblScore.Text = $"SCORE:{score}";
            pipespeed = 10 + score;
            Pohyb();
            Vracecka();
            if (Dotek())
            {
                score = 0;
                EndGame();
            }
        }
        private void UpravaUI()
        {
            LblScore.Size = new Size(120, 40);
            LblScore.Location = new Point(10, 900);
            Timer.Enabled = true;
            PicBoxME.Location = new Point(75, 250);
            int tmp1 = 0;
            int tmp2 = 0;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "1" || (string)x.Tag == "2")
                {
                    x.Size = new(100, 200);
                }

                if (x is PictureBox && (string)x.Tag == "1")
                {
                    x.Location = new(600 + 400 * tmp1, -5);
                    tmp1++;
                }

                if (x is PictureBox && (string)x.Tag == "2")
                {
                    x.Location = new(600 + 400 * tmp2, 620);
                    tmp2++;
                }
            }

        }
        private bool Dotek()
        {
            if (PicBoxME.Bounds.IntersectsWith(PicBoxDown.Bounds) ||
PicBoxME.Bounds.IntersectsWith(PicBoxUp.Bounds) ||
PicBoxME.Bounds.IntersectsWith(PicBoxDown2.Bounds) ||
PicBoxME.Bounds.IntersectsWith(PicBoxUp2.Bounds) ||
PicBoxME.Bounds.IntersectsWith(PicBoxDown3.Bounds) ||
PicBoxME.Bounds.IntersectsWith(PicBoxUp3.Bounds) ||
PicBoxME.Bounds.IntersectsWith(PicBoxDown4.Bounds) ||
PicBoxME.Bounds.IntersectsWith(PicBoxUp4.Bounds) ||
PicBoxME.Bottom > 820 || PicBoxME.Top < -25)
            {
                return true;
            }
            return false;
        }
        private void Vracecka()
        {
            Random rnd = new();
            int tmp = rnd.Next(400, PicBoxDown.Bottom);

            if (PicBoxDown.Left < -50)
            {
                PicBoxDown.Left = 1500;
                score++;
                PicBoxDown.Top = tmp;
                PicBoxDown.Size = new Size(100, 200 + (620 - tmp));
            }
            if (PicBoxDown2.Left < -50)
            {
                PicBoxDown2.Left = 1500;
                score++;
                PicBoxDown2.Top = tmp;
                PicBoxDown2.Size = new Size(100, 200 + (620 - tmp));
            }
            if (PicBoxDown3.Left < -50)
            {
                PicBoxDown3.Left = 1500;
                score++;
                PicBoxDown3.Top = tmp;
                PicBoxDown3.Size = new Size(100, 200 + (620 - tmp));
            }
            if (PicBoxDown4.Left < -50)
            {
                PicBoxDown4.Left = 1500;
                score++;
                PicBoxDown4.Top = tmp;
                PicBoxDown4.Size = new Size(100, 200 + (620 - tmp));
            }
            if (PicBoxUp.Left < -50)
            {
                PicBoxUp.Left = 1500;
                PicBoxUp.Size = new Size(100, PicBoxDown.Top - 200);
            }
            if (PicBoxUp2.Left < -50)
            {
                PicBoxUp2.Left = 1500;
                PicBoxUp2.Size = new Size(100, PicBoxDown2.Top - 200);
            }
            if (PicBoxUp3.Left < -50)
            {
                PicBoxUp3.Left = 1500;
                PicBoxUp3.Size = new Size(100, PicBoxDown3.Top - 200);
            }
            if (PicBoxUp4.Left < -50)
            {
                PicBoxUp4.Left = 1500;
                PicBoxUp4.Size = new Size(100, PicBoxDown4.Top - 200);
            }
        }
        private void Pohyb()
        {
            PicBoxME.Top += gravity;

            PicBoxDown.Left -= pipespeed;
            PicBoxDown2.Left -= pipespeed;
            PicBoxDown3.Left -= pipespeed;
            PicBoxDown4.Left -= pipespeed;

            PicBoxUp.Left -= pipespeed;
            PicBoxUp2.Left -= pipespeed;
            PicBoxUp3.Left -= pipespeed;
            PicBoxUp4.Left -= pipespeed;
        }
        private void EndGame()
        {
            Timer.Stop();
            Skore skore = new(hrac, score);
            Save(skore);
            LblScore.Text += "Konec Hry";
            DialogResult dialogResult = MessageBox.Show("", "Chceš restartovat hru", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UpravaUI();
            }
            else
            {
                Close();
            }
        }
        private void Save(Skore skore)
        {
            string path = "LBFlappyME.txt";
            using StreamWriter sw = new (path, true);
            sw.WriteLine(skore.ToString() + Environment.NewLine);
            sw.Close();
        }
    }
}
