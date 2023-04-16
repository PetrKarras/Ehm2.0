namespace Mozaika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fileName = "BARVY.txt";
        public char[,] poleBarev = new char[20, 20];
        bool edit = true;

        private void ButtDraw_Click(object sender, EventArgs e)
        {
            PanelOut.Refresh();
        }

        private void ButtFile_Click(object sender, EventArgs e)
        {
            using StreamReader sr = new(fileName);
            int radek = -1;
            while (!sr.EndOfStream)
            {
                int sloupec = -1;
                radek++;
                char[] line = sr.ReadLine().ToCharArray();
                foreach (char c in line)
                {
                    if (radek < 20)
                    {
                        sloupec++;
                        poleBarev[radek, sloupec] = c;
                    }
                }
            }
            ButtDraw.Enabled = true;
        }

        private void PanelOut_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int x = 0, y = 0;
            Color color = new();
            _ = new SolidBrush(color);
            foreach (char c in poleBarev)
            {

                color = c switch
                {
                    'R' => Color.Red,
                    'G' => Color.Green,
                    'B' => Color.Blue,
                    'C' => Color.Cyan,
                    'M' => Color.Magenta,
                    'Y' => Color.Yellow,
                    'K' => Color.Black,
                    _ => Color.White,
                };
                SolidBrush brush = new(color);
                g.FillRectangle(brush, x, y, 20, 20);
                x += 20;
                if (x == 400)
                {
                    y += 20;
                    x = 0;
                }
            }
        }

        private void ButtEdit_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                ButtDraw.Enabled = false;
                ButtFile.Enabled = false;
                RTextBox.Visible = true;
                RTextBox.Text = File.ReadAllText(fileName);
                edit = false;
            }
            else
            {
                string[] strings = RTextBox.Text.Split('\n');
                foreach (string s in strings)
                {
                    int radek = 0;
                    if (s.Length > 20)
                    {
                        radek++;
                        MessageBox.Show($"Ña øádku {radek} je víc než 20 písmen", "Error 001");
                        return;
                    }
                }
                File.WriteAllText(fileName, RTextBox.Text);
                RTextBox.Visible = false;
                ButtDraw.Enabled = true;
                ButtFile.Enabled = true;
                edit = true;
                ButtFile.PerformClick();
            }
        }
    }
}