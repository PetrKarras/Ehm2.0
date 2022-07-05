namespace Podobnost_trojúhelníku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Butt_Click(object sender, EventArgs e)
        {
            int[] triangle1 = { (int)NumUDA1.Value, (int)NumUDB1.Value, (int)NumUDC1.Value };
            int[] triangle2 = { (int)NumUDA2.Value, (int)NumUDB2.Value, (int)NumUDC2.Value };
            int[] triangleUhle = { (int)NumUDC1.Value, (int)NumUDC2.Value };

            switch (ComBoxVeta.SelectedIndex)
            {
                case 0:
                    SSS(MAXMIN(triangle1), MAXMIN(triangle2));
                    break;
                case 1:
                case 3:
                    triangle1[2] = 0;
                    triangle2[2] = 0;
                    SUS(MAXMIN(triangle1), MAXMIN(triangle2), triangleUhle);
                    break;
                case 2:
                    USU(triangle1, triangle2);
                    break;
                default:
                    MessageBox.Show("Vyber větu", "Chyba");
                    break;
            }
        }

        private void UpravaUI(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Label && x.Tag != null)
                {
                    x.Text = "Strana:";
                }
                x.Visible = true;
            }
            if (ComBoxVeta.SelectedIndex != 0)
            {
                foreach (Control x in this.Controls)
                {
                    if ((string)x.Tag == "3")
                    {
                        x.Text = "Úhel";
                    }
                    if (ComBoxVeta.SelectedIndex == 2 && (string)x.Tag == "2")
                    {
                        x.Text = "Úhel";
                    }
                    if (ComBoxVeta.SelectedIndex == 3 && (string)x.Tag == "2")
                    {
                        x.Text = "strana:";
                    }
                }
            }
        }
        private static void SSS(double[] tri1, double[] tri2)
        {
            if (tri1[0] / tri2[0] == tri1[1] / tri2[1] && tri1[1] / tri2[1] == tri1[2] / tri2[2] && tri1[2] / tri2[2] == tri1[0] / tri2[0])
            {
                MessageBox.Show("Trojuhelník jde sestrojit", "Výsledek");
            }
            else
            {
                MessageBox.Show("Trojuhelník nejde sestrojit", "Výsledek");
            }
        }
        private static void SUS(double[] tri1, double[] tri2, int[] triU)
        {
            if (tri1[0] / tri2[0] == tri1[1] / tri2[1] && triU[0] == triU[1])
            {
                MessageBox.Show("Trojuhelník jde sestrojit", "Výsledek");
            }
            else
            {
                MessageBox.Show("Trojuhelník nejde sestrojit", "Výsledek");
            }
        }
        private static void USU(int[] tri1, int[] tri2)
        {
            if (tri1[1] == tri2[1] && tri1[2] == tri2[2])
            {
                MessageBox.Show("Trojuhelník jde sestrojit", "Výsledek");
            }
            else
            {
                MessageBox.Show("Trojuhelník nejde sestrojit", "Výsledek");
            }
        }
        private static double[] MAXMIN(int[] info)
        {
            double[] pole = new double[info.Length];
            int a = info[0];
            int b = info[1];
            int c = info[2];
            bool ab = (a > b);
            bool ac = (a > c);
            if (ab == true && ac == true)
            {
                pole[0] = a;
                if (b > c)
                {
                    pole[1] = b;
                    pole[2] = c;
                }
                else
                {
                    pole[1] = c;
                    pole[2] = b;
                }
            }
            else
            {
                if (ab == false && ac == false)
                {
                    pole[2] = a;
                    if (b > c)
                    {
                        pole[0] = b;
                        pole[1] = c;
                    }
                    else
                    {
                        pole[0] = c;
                        pole[1] = b;
                    }
                }
                else
                {
                    pole[1] = a;
                    if (ab)
                    {
                        pole[0] = c;
                        pole[2] = b;
                    }
                    else
                    {
                        pole[0] = b;
                        pole[2] = c;
                    }
                }
            }
            return pole;
        }
    }
}