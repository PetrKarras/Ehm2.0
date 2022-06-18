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
    public partial class JumpingME : Form
    {
        public JumpingME(string player)
        {
            InitializeComponent();
            hrac = player;
        }
        string hrac;
        bool gif;
        bool jumping = false;
        int carSpeed = 10;
        int jumpSpeed;
        int force = 15;
        int score = 0;
        Random rnd = new ();

        private void JumpingME_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
            Size = new(1800, 960);
            Location = new(75, 80);
            UpravaUI();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            carSpeed = 10 + score;
            PicBoxME.Top += jumpSpeed;
            LblScore.Text = $"Score:{score} ";
            if(jumping == true && force < 0)
            {
                jumping = false;
            }
            if( jumping)
            {
                jumpSpeed = -12;
                force--;
            }
            else
            {
                jumpSpeed = 12;
            }
            if(PicBoxME.Top >675 && jumping == false)
            {
                force = 50;
                PicBoxME.Top = 675;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "1")
                {
                    x.Left -= carSpeed;

                    if(x.Left < -200)
                    {
                        x.Left = rnd.Next(800, 2000);
                        score++;
                    }
                }
            }
            if (Dotek())
            {
                score = 0;
                EndGame();
            }
        }

        private void JumpingME_KeyUp(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
        }

        private void JumpingME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W || e.KeyCode == Keys.Up && jumping == false)
            {
                jumping = true;
            }
        }
        private bool Dotek()
        {
            if (PicBoxME.Bounds.IntersectsWith(PicBoxDown.Bounds) ||
                PicBoxME.Bounds.IntersectsWith(PicBoxDown1.Bounds))
            {
                return true;
            }
            return false;
        }
        private void UpravaUI()
        {
            PicBoxME.Location = new(75, 675);
            PicBoxDown.Location = new(600, 785);
            PicBoxDown1.Location = new(1400, 785);

            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            carSpeed = 10;
            LblScore.Text = $"Score:{score} ";
            PicBoxME.Top = 675;

            GameTimer.Start();
            TimerGif.Start();
        }
        private void EndGame()
        {
            GameTimer.Stop();
            Skore skore = new(hrac, score);
            Save(skore);
            LblScore.Text += "Konec Hry";
            DialogResult dialogResult = MessageBox.Show("Ano", "Chceš restartovat hru", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UpravaUI();
            }
            else
            {
                Close();
            }
        }
        private static void Save(Skore skore)
        {
            string path = "LBJumpingME.txt";
            using StreamWriter sw = new (path);
            sw.WriteLine(skore.ToString() + Environment.NewLine);
            sw.Close();
        }
        private void TimerGif_Tick(object sender, EventArgs e)
        {
            if (gif)
            {
                PicBoxME.BackgroundImage = Properties.Resources.JumpingMeSTOP;
                gif = !gif;
            }
            else
            {
                PicBoxME.BackgroundImage = Properties.Resources.JumpingMeRUN;
                gif = !gif;
            }
        }
    }
}
