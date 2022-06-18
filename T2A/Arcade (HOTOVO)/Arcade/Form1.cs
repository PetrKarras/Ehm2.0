namespace Arcade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] gameList = new string[] { "Flappy ME", "Jumping ME" };
        public int gameListIndex = 0;
        public string hrac;
        int infoIndex = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (infoIndex == 1)
            {
                BackgroundImage = Properties.Resources.InfoForm;
            }
            BackgroundImage = Properties.Resources.Automat;
            this.SetStyle(
ControlStyles.AllPaintingInWmPaint |
ControlStyles.DoubleBuffer,
true);
            UpravaUI();
            hrac = JmenoHrace();
        }
        // Konec tlaèítko
        private void PicBoxEnd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ano", "Chceš vypnout hru", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
        // Seznam výhercù tlaèítko
        private void PicBoxLeaderboard_Click(object sender, EventArgs e)
        {
            Leaderboard(gameListIndex);
        }
        // Hra tlaèíkto
        private void PicBoxGame_Click(object sender, EventArgs s)
        {
            if (hrac == null)
            {
                hrac = JmenoHrace();
            }
            else
            {
                switch (gameListIndex)
                {
                    case 0:
                        FlappyME(hrac);
                        break;
                    case 1:
                        JumpingME(hrac);
                        break;
                }
            }

        }


        //HRY
        private static void FlappyME(string hrac)
        {
            Form FlappyMeForm = new FlappyME(hrac);
            FlappyMeForm.Show();
        }
        private static void JumpingME(string hrac)
        {
            Form JumpingMEForm = new JumpingME(hrac);
            JumpingMEForm.Show();
        }
        private static void Leaderboard(int druh)
        {
            Form Leaderboard = new Leaderboard(druh);
            Leaderboard.Show();
        }


        // Metoda pro Úpravu UI
        private void UpravaUI()
        {
            PicBoxRight.Size = new(150, 150);
            PicBoxLeft.Size = new(150, 150);
            PicBoxGame.Size = new(300, 150);
            PicBoxLeaderboard.Size = new(300, 150);
            PicBoxEnd.Size = new(300, 150);
            PicBoxInfo.Size = new(75, 75);

            PicBoxRight.Location = new(1120, 300);
            PicBoxLeft.Location = new(620, 300);
            PicBoxGame.Location = new(800, 300);
            PicBoxLeaderboard.Location = new(800, 500);
            PicBoxEnd.Location = new(800, 700);
            PicBoxInfo.Location = new(1760, 955);
        }
        // Metoda pro jméno hráèe
        private static string JmenoHrace()
        {
            return Microsoft.VisualBasic.Interaction.InputBox("Vyber si jméno", "Jméno hráèe", "", 500, 500);
        }
        // Text v Pictureboxech
        public Font customFont = new("Haettenschweiler", 50);
        private void PicBoxGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(gameList[gameListIndex], customFont, Brushes.Black, new Point(7, 40));
        }

        private void PicBoxLeaderboard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Leaderboard", customFont, Brushes.Black, new Point(7, 40));
        }

        private void PicBoxEnd_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Konec", customFont, Brushes.Black, new Point(7, 40));
        }
        // SLIDER
        private void PicBoxRight_Click(object sender, EventArgs e)
        {
            gameListIndex++;
            switch (gameListIndex)
            {
                case < 0:
                    gameListIndex = 1;
                    break;
                case > 1:
                    gameListIndex = 0;
                    break;
            }
            PicBoxGame.Refresh();
        }

        private void PicBoxLeft_Click(object sender, EventArgs e)
        {
            gameListIndex--;
            switch (gameListIndex)
            {
                case < 0:
                    gameListIndex = 1;
                    break;
                case > 1:
                    gameListIndex = 0;
                    break;
            }
            PicBoxGame.Refresh();
        }

        private void PicBoxInfo_Click(object sender, EventArgs e)
        {
            infoIndex++;
            if (infoIndex == 1)
            {
                foreach (Control x in this.Controls)
                {
                        x.Hide();
                }
                PicBoxInfo.Show();
                this.BackgroundImage = Properties.Resources.InfoForm;
            }
            if(infoIndex == 2)
            {
                foreach (Control x in this.Controls)
                {
                    x.Show();
                }
                this.BackgroundImage = Properties.Resources.Automat;
            }
        }
    }
}
