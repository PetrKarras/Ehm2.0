using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            int[,] matice= new int[8, 8];
            Txtbox.Text = PrintMatice(matice);
        }
        private string PrintMatice(int[,] matice)
        {

            if (RadDEF.Checked)
            {
                for (int i = 0; i < matice.GetLength(0); i++)
                {
                    for (int a = 0; a < matice.GetLength(1); a++)
                    {
                        matice[i, a] = 1;
                    }
                }
            }

            int[] tmp = { 1, 2, 3, 4, 5, 6, 7, 8 };
            if (RadColums.Checked)
            {
                for (int i = 0; i < matice.GetLength(0); i++)
                {
                    for (int a = 0; a < matice.GetLength(1); a++)
                    {
                        matice[i, a] = tmp[i];
                    }
                }
            }

            if (RadRows.Checked)
            {
                for (int i = 0; i < matice.GetLength(0); i++)
                {
                    for (int a = 0; a < matice.GetLength(1); a++)
                    {
                        matice[i, a] = tmp[a];
                    }
                }
            }

            string ret = "";
            for (int i = 0; i < matice.GetLength(0); i++)
            {
                for (int a = 0; a < matice.GetLength(1); a++)
                {
                    ret += $"{matice[i, a]}, ";
                }
                ret += Environment.NewLine;
            }
            return ret;
        }
    }
}
