namespace Grafika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Panelos_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int tloustka = Convert.ToInt32(NUMupdown.Value);

            SolidBrush customB = new SolidBrush(colorDialog1.Color);
            Pen customP = new Pen(colorDialog1.Color, tloustka);
            Random random = new Random();

            int a = random.Next(50, 450);
            int b = random.Next(50, 450);
            int c = random.Next(50, 450);

            if (RADobr.Checked)
            {
                if (ChboxCIR.Checked)
                {
                    g.DrawEllipse(customP, random.Next(0, 500), random.Next(0, 300), a, a);
                }
                if (ChboxTRI.Checked)
                {
                    Point[] triangle =
                        {
                new Point(a,a),
                new Point(b,c),
                new Point(a,c),
                new Point(a,a)
            };
                    g.DrawPolygon(customP, triangle);
                }
                if (ChboxSQ.Checked)
                {
                    g.DrawRectangle(customP, random.Next(0, 500), random.Next(0, 300), a, a);
                }
                if (CHboxRe.Checked)
                {
                    g.DrawRectangle(customP, random.Next(0, 500), random.Next(0, 300), a, b);
                }
            }
            else
            {
                if (ChboxCIR.Checked)
                {
                    g.FillEllipse(customB, random.Next(0, 500), random.Next(0, 300), a, a);
                }
                if (ChboxTRI.Checked)
                {
                    Point[] triangle =
                        {
                new Point(a, a),
                new Point(b,c),
                new Point(a,c),
                new Point(a,a)
            };
                    g.FillPolygon(customB, triangle);
                }
                if (ChboxSQ.Checked)
                {
                    g.FillRectangle(customB, random.Next(0, 500), random.Next(0, 300), a, a);
                }
                if (CHboxRe.Checked)
                {
                    g.FillRectangle(customB, random.Next(0, 500), random.Next(0, 300), a, b);
                }
            }
        }
        private void Butt_Click(object sender, EventArgs e)
        {
            Panelos.Refresh();
        }
        private void ButtCol_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}