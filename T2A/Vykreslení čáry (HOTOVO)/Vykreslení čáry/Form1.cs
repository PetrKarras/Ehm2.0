namespace Vykreslení_čáry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool tmp = false;
        private Point[] poleBodu;
        private void ButtPress_Click(object sender, EventArgs e)
        {
            string[] hodnotaY = TxtboxIn.Text.Split(",");
            poleBodu = new Point[hodnotaY.Length];
            if (poleBodu.Length >= 2)
            {
                for (int x = 0; x < poleBodu.Length; x++)
                {
                    Point point = new(x * 50, int.Parse(hodnotaY[x].Trim()));
                    poleBodu[x] = point;
                }
                PanFront.Refresh();
            }
        }

        private void PanFront_Paint(object sender, PaintEventArgs e)
        {
            int wide = Convert.ToInt32(NumUpDown.Value);
            Pen pero = new(ColorDialog.Color, wide);
            if (poleBodu != null)
            {
                Graphics g = e.Graphics;
                g.DrawLines(pero, poleBodu);
            }
        }

        private void ButtColor_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            PanFront.Refresh();
        }
    }
}