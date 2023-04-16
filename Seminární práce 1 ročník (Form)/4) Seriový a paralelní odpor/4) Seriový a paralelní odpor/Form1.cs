using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace _4__Seriový_a_paralelní_odpor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double b = 0;
        private double c = 0;
        private void Butt_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text != "" && TxtBox.Text != ".")
            {
                double a = double.Parse(TxtBox.Text);

                if (RadButSer.Checked)
                {
                    c = a + b;
                    b = c;
                }
                else
                {
                    c = (a * b) / (a + b);
                    b = c;
                }
                LblOUT.Text = $"R = {c} Ω";
            }
            else
            {
                MessageBox.Show("Zadej hodnotu", "Error 001");
            }

        }

        private void ButtRes_Click(object sender, EventArgs e)
        {
            LblOUT.Text = "";
            b = 0;
        }
        private void TxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}