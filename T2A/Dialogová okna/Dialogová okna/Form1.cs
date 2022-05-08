using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogová_okna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtRes_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "";
            TxtBox.BackColor = Color.White;
        }

        private void ButtNUM_Click(object sender, EventArgs e)
        {
            CommonDialog pocet;          
            FormularPocitani(TxtBox.Text);
        }

        private void ButtCol_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtBox.BackColor = colorDialog1.Color;
            }
        }
        private string FormularPocitani(string kokos)
        {
            string tmp = kokos.Replace(" ", null);
            int pocetPismen = tmp.Length;
            int pocetSlov = 0;
            for (int i = 0; i < kokos.Length; i++)
            {
                if (kokos.Contains(" "))
                {
                    pocetSlov++;
                }
            }
            return $"{pocetPismen}";
        }
    }
}
