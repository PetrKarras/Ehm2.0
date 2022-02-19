using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Výtah
{
    public partial class Form1 : Form
    {
        private int vaha = 0;
        private int pocet = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtADD_Click(object sender, EventArgs e)
        {
            int vahatmp = int.Parse(TxtBoxIN.Text);
            if((vaha + vahatmp) > 600)
            {
                LblVaha.BackColor = Color.Orange;
                return;
            }
            if (pocet+1 >8 )
            {
                LblPocet.BackColor = Color.Orange;
                return;
            }
            vaha += vahatmp;
            pocet++;
            TxtBoxOut.Text += $"{vahatmp}{Environment.NewLine}";
        }

        private void ButtRess_Click(object sender, EventArgs e)
        {
            TxtBoxIN.Text = "";
            TxtBoxOut.Text = "";
            vaha = 0;
            pocet = 0;
            LblPocet.BackColor= Color.Lime;
            LblVaha.BackColor = Color.Lime;
        }
    }
}
