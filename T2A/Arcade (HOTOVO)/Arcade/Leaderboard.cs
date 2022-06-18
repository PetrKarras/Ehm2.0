using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcade
{
    public partial class Leaderboard : Form
    {
        public int druh;
        public Leaderboard(int typ)
        {
            InitializeComponent();
            druh = typ;
            BackgroundImage = Properties.Resources.LBFlappyME;
            if (druh == 1)
            {
                BackgroundImage = Properties.Resources.LBJumpingME;
            }
        }
        private void Leaderboard_Load(object sender, EventArgs e)
        {
            UpravaUI();
            Read(druh);
        }
        private void PicBoxEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void UpravaUI()
        {
            LblOut.Size = new (1760, 790);
            LblOut.Location = new (77, 85);
            PicBoxEnd.Size = new (300, 150);
            PicBoxEnd.Location = new (800, 885);
        }
        public Font customFont = new("Haettenschweiler", 50);
        readonly string mezera = "      ";
        private void PicBoxEnd_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(mezera + "Zpět", customFont, Brushes.Black, new Point(7, 40));
        }
        private void Read(int druh)
        {
            string path = "LBFlappyMe.txt";
            if (druh == 1)
            {
                path = "LBJumpingME.txt";
            }
            using StreamReader sr = new(path);
            while (!sr.EndOfStream)
            {
                LblOut.Text += (sr.ReadLine());
            }
            sr.Close();
        }
    }
}
