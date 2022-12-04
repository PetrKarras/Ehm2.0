namespace VolebníGraf
{
    public partial class Form1 : Form
    {
        private int candidateX;
        private int candidateY;
        private int candidateZ;
        private const int max = 500;
        public Form1()
        {
            InitializeComponent();
            candidateX = 0;
            candidateY = 0;
            candidateZ = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) candidateX++;
            if (radioButton2.Checked) candidateY++;
            if (radioButton3.Checked) candidateZ++;
            Panel1.Refresh();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            double suma = candidateX + candidateY + candidateZ;

            if (suma == 0) return;

            double[] height = { (candidateX / suma) * max, (candidateY / suma) * max, (candidateZ / suma) * max };
            double[] location = { max - height[0], max - height[1], max - height[2] };

            g.FillRectangle(Brushes.Blue, 50, (int)location[0], 50, (int)height[0]);
            g.FillRectangle(Brushes.Red, 150, (int)location[1], 50, (int)height[1]);
            g.FillRectangle(Brushes.Green, 250, (int)location[2], 50, (int)height[2]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int tmp = rnd.Next(0, 4);
            switch (tmp)
            {
                case 1:
                    candidateX++;
                    TxtBoxOUT.Text += $"Kandidát 1 dostal hlas {Environment.NewLine}";
                    break;
                case 2:
                    candidateY++;
                    TxtBoxOUT.Text += $"Kandidát 2 dostal hlas {Environment.NewLine}";
                    break;
                case 3:
                    candidateZ++;
                    TxtBoxOUT.Text += $"Kandidát 3 dostal hlas {Environment.NewLine}";
                    break;
            }
            Panel1.Refresh();
        }

        private void ButtStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

            if (timer1.Enabled)
            {
                ButtStart.Text = "STOP";
            }
            else
            {
                ButtStart.Text = "START";
            }
        }
    }
}