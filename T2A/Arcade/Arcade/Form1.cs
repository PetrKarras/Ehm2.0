namespace Arcade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] gameList = new string[] { "Flapy ostrich", "Picky-man", "Zac the jumper" };
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
                        FlappyOstrich();
                        break;
                    case 1:
                        PickyMan();
                        break;
                    case 2:
                        ZacTheJumper();
                        break;
                }
            }

        }
        // Metoda pro Úpravu UI
        private void UpravaUI()
        {
            // WindowState Maximized
            // FormBorderStyle None
            // BackgroundLayout Stretch
            Image button = Properties.Resources.Button;
            Image arrowR = Properties.Resources.ArrowR;
            Image arrowL = Properties.Resources.ArrowL;
            Image info = Properties.Resources.Info;

            PicBoxRight.Image = arrowR;
            PicBoxLeft.Image = arrowL;
            PicBoxEnd.Image = button;
            PicBoxGame.Image = button;
            PicBoxLeaderboard.Image = button;
            PicBoxInfo.Image = info;

            PicBoxRight.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxEnd.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxGame.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxLeaderboard.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxInfo.SizeMode = PictureBoxSizeMode.StretchImage;

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

            PicBoxRight.BackColor = Color.Transparent;
            PicBoxLeft.BackColor = Color.Transparent;
            PicBoxGame.BackColor = Color.Transparent;
            PicBoxLeaderboard.BackColor = Color.Transparent;
            PicBoxEnd.BackColor = Color.Transparent;
            PicBoxInfo.BackColor = Color.Transparent;

        }
        // Metoda pro jméno hráèe
        private void JmenoHrace()
        {
            hrac = Microsoft.VisualBasic.Interaction.InputBox("Vyber si jméno",
"Jméno hráèe",
"",
500,
500);
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
                    gameListIndex = 2;
                    break;
                case > 2:
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
                    gameListIndex = 2;
                    break;
                case > 2:
                    gameListIndex = 0;
                    break;
            }
            PicBoxGame.Refresh();
        }

        private Games FlappyOstrich()
        {
            int score = 0;
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            return new Games(hrac, gameList[gameListIndex], score);
        }
        private Games PickyMan()
        {
            int score = 0;
            return new Games(hrac, gameList[gameListIndex], score);
        }
        private Games ZacTheJumper()
        {
            int score = 0;
            return new Games(hrac, gameList[gameListIndex], score);
        }
    }
}
