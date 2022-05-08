namespace Kokos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int x = 0;
        private int y = 0;
        public bool kliknutoRight = false;
        public bool kliknutoLeft = false;
        public bool kliknutoUp = false;
        public bool kliknutoDown = false;
        private void timerX_Tick(object sender, EventArgs e)
        {
            if (kliknutoRight)
            {
                x++;
            }
            else if (kliknutoLeft)
            {
                x--;
            }
            else
            {
                x++;
            }
            PanFront.Refresh();
        }
        private void timerY_Tick(object sender, EventArgs e)
        {
            if (kliknutoUp)
            {

                y--;
            }
            else if (kliknutoDown)
            {
                y++;
            }
            else
            {
                y++;
            }
            PanFront.Refresh();
        }
        private void PanFront_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Black, x, y, 10, 10);
        }
        private void ButtLeft_Click(object sender, EventArgs e)
        {
            timerX.Enabled = true;
            timerY.Enabled = false;

            kliknutoRight = false;
            kliknutoUp = false;
            kliknutoDown = false;

            kliknutoLeft = true;
        }
        private void ButtRight_Click(object sender, EventArgs e)
        {
            timerX.Enabled = true;
            timerY.Enabled = false;

            kliknutoLeft = false;
            kliknutoUp = false;
            kliknutoDown = false;

            kliknutoRight = true;
        }
        private void ButtUp_Click(object sender, EventArgs e)
        {
            timerX.Enabled = false;
            timerY.Enabled = true;

            kliknutoRight = false;
            kliknutoLeft = false;
            kliknutoDown = false;

            kliknutoUp = true;
        }
        private void ButtDown_Click(object sender, EventArgs e)
        {
            timerX.Enabled = false;
            timerY.Enabled = true;

            kliknutoRight = false;
            kliknutoLeft = false;
            kliknutoUp = false;

            kliknutoDown = true;
        }
        private void ButtRes_Click(object sender, EventArgs e)
        {
            timerX.Enabled = true;
            timerY.Enabled = true;
            
            kliknutoRight = false;
            kliknutoLeft = false;
            kliknutoUp = false;
            kliknutoDown = false;

            x = 0;
            y = 0;
        }
    }
}
