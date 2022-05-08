namespace Terč
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            PanFront.Refresh();
        }
        private void PanFront_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush front = new(ColDiaFront.Color);
            SolidBrush back = new(ColDiaBack.Color);

            int w = 400;
            int x = 25;
            int y = 25;

            ZmenaBarvy();

            for (int i = 0; i < NumUpDown.Value; i++)
            {
                w -= 20;
                x += 10;
                y += 10;
                if (RadRec.Checked)
                {
                    if (i % 2 == 0)
                    {
                        g.FillRectangle(back, x, y, w, w);
                    }
                    else
                    {
                        g.FillRectangle(front, x, y, w, w);
                    }
                }
                if (RadCrl.Checked)
                {
                    if (i % 2 == 0)
                    {
                        g.FillEllipse(back, x, y, w, w);
                    }
                    else
                    {
                        g.FillEllipse(front, x, y, w, w);
                    }
                }
                if (RadTri.Checked)
                {

                    if (i % 2 == 0)
                    {
                        g.FillPolygon(back, Triangle(230,440,10,i));
                    }
                    else
                    {
                        g.FillPolygon(front, Triangle(230, 440, 10,i));
                    }
                }

            }
        }
        private Point[] Triangle(int a,int b,int c,int tmp)
        {


            return new Point[]
            {
                new Point(a,c+(10*tmp)),
                new Point(c+(10*tmp),b-(5*tmp)),
                new Point((a*2)-(10*tmp),b-(5*tmp)),
            };
        }

        private void ZmenaBarvy()
        {
            LblCol2.BackColor = ColDiaBack.Color;
            LblCol1.BackColor = ColDiaFront.Color;
        }

        private void LblCol1_Click(object sender, EventArgs e)
        {
            ColDiaFront.ShowDialog();
            ZmenaBarvy();
        }

        private void LblCol2_Click(object sender, EventArgs e)
        {
            ColDiaBack.ShowDialog();
            ZmenaBarvy();
        }
    }
}