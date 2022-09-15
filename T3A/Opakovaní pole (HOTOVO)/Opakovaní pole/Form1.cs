using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovaní_pole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] pole;
        public int tmp;
        private void ButtGen_Click(object sender, EventArgs e)
        {
            LblPole.Text = "";
            pole = new int[(int)NumUD.Value];
            Random random = new Random();

            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = random.Next(0, 10);
                LblPole.Text += $"{pole[i]}, ";
            }
        }

        private void ButtPlus_Click(object sender, EventArgs e)
        {
            LblOut.Text = $"{pole.Sum()}";
        }

        private void ButtKrat_Click(object sender, EventArgs e)
        {
            tmp = 1;
            foreach(int item in pole)
            {
                tmp *= item;
            }
            LblOut.Text = tmp.ToString();
        }

        private void ButtMax_Click(object sender, EventArgs e)
        {
            LblOut.Text = $"{pole.Max()}";
        }

        private void ButtMin_Click(object sender, EventArgs e)
        {
            LblOut.Text = $"{pole.Min()}";
        }
    }
}
