namespace Arcade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] gameList = new string[] { "Flapy ME", "Jumping ME" };
        public int gameListIndex = 0;
        public string hrac = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(
ControlStyles.AllPaintingInWmPaint |
ControlStyles.DoubleBuffer,
true);
            UpravaUI();
            JmenoHrace();
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

        }
        // Hra tlaèíkto
        private void PicBoxGame_Click(object sender, EventArgs s)
        {
            if (hrac == "")
            {
                JmenoHrace();
            }
            else
            {
                switch (gameListIndex)
                {
                    case 0:
                        FlappyME();
                        break;
                    case 1:
                        PickyME();
                        break;
                }
            }

        }


        //HRY
        private static void FlappyME()
        {
            Form FlappyMeForm = new FlappyME();
            FlappyMeForm.Show();
        }
        private void PickyME()
        {
            this.Hide();
        }


        // Metoda pro Úpravu UI
        private void UpravaUI()
        {
            PicBoxRight.Size = new Size(150, 150);
            PicBoxLeft.Size = new Size(150, 150);
            PicBoxGame.Size = new Size(300, 150);
            PicBoxLeaderboard.Size = new Size(300, 150);
            PicBoxEnd.Size = new Size(300, 150);
            PicBoxInfo.Size = new Size(75, 75);

            PicBoxRight.Location = new Point(1120, 300);
            PicBoxLeft.Location = new Point(620, 300);
            PicBoxGame.Location = new Point(800, 300);
            PicBoxLeaderboard.Location = new Point(800, 500);
            PicBoxEnd.Location = new Point(800, 700);
            PicBoxInfo.Location = new Point(1760, 955);
        }
        // Metoda pro jméno hráèe
        private void JmenoHrace()
        {
            hrac = Microsoft.VisualBasic.Interaction.InputBox("Vyber si jméno", "Jméno hráèe", "", 500, 500);
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
    }
}
