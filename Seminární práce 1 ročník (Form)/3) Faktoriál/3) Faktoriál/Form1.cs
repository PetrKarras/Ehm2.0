using System.Numerics;

namespace _3__Faktoriál
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            BigInteger tmp = 1;
            for (int i = 1; i != (int)NumUD.Value+1; i++)
            {
                tmp *= i;
            }
            LblOUT.Text = $"{NumUD.Value}! = {tmp:N0}";
        }
    }
}