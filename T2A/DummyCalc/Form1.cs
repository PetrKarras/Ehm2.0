using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DummyCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSoucet_Click(object sender, EventArgs e)
        {
            int cisloA = Convert.ToInt32(NumericA.Value);
            int cisloB = Convert.ToInt32(NumericB.Value);
            LblVysledek.Text = $"{cisloA + cisloB}";
        }

        private void BtnRozdíl_Click(object sender, EventArgs e)
        {
            int cisloA = Convert.ToInt32(NumericA.Value);
            int cisloB = Convert.ToInt32(NumericB.Value);
            LblVysledek.Text = $"{cisloA - cisloB}";
        }

        private void BtnSoucin_Click(object sender, EventArgs e)
        {
            int cisloA = Convert.ToInt32(NumericA.Value);
            int cisloB = Convert.ToInt32(NumericB.Value);
            LblVysledek.Text = $"{cisloA * cisloB}";
        }
        private string Nadprumer(int[] pole)
        {
            int castPrumer = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                castPrumer += pole[i];
            }
            int prumer = castPrumer / pole.Length;
            int nadprumer = 0;
            int podprumer = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < prumer) { nadprumer++; }
                if (pole[i] > prumer) { podprumer++; }
            }
            LblPrumer.Text = $"Počet nadprůmerných čísel:{nadprumer},podprůmer{podprumer}";
            return "";         
        }
    }

}
