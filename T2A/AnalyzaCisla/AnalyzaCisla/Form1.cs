using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalyzaCisla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            string result = "Pro číslo platí že je: ";
            string[] text = TxtNumber.Text.Split();
            int[] poleCisel = Convert;
            result += AnalyzePositiveNegative(number);
            result += AnalyzeEvenOdd(number);
            result += AnalyzePerfect(number);
            result += AnalyzePrime(number);
            result += AnalyzeDividers(number);

           // LblResult.Text = result;
            MessageBox.Show(result);
        }

        private string AnalyzeDividers(int number)
        {
            string result = "\n dělitelé čísla:";
            for (int i = 2; i < number + 1; i++)
            {
                if ((number % i) == 0)
                {
                    result += i + ",";
                }
            }
            return result;
        }

        private string AnalyzePrime(int number)
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return "\n není prvočíslo";
                }
            }

            return "\n prvočíslo";
        }

        private string AnalyzePerfect(int number)
        {
            int suma = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    suma += i;
                }

            }
            if (suma == number)
            {
                return "\n dokonalé, ";
            }
            else
            {
                return "\n nedokonalé";
            }

        }

        private string AnalyzeEvenOdd(int number)
        {
            if ((number % 2) == 0)
            {
                return "\n sudé, ";
            }
            else
            {
                return "\n liché, ";
            }
        }

        private string AnalyzePositiveNegative(int number)
        {
            if (number > 0)
            {
                return "\n kladné, ";
            }
            else
            {
                return "\n záporné, ";
            }
        }
    }
}
