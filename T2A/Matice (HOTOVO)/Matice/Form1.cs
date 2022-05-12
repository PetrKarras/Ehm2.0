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
            int kks = Convert.ToInt32(NumUpDown.Value);
            int[,] matice= new int[kks,kks];
            Txtbox.Text = PrintMatice(matice);
        }
        private string PrintMatice(int[,] matice)
        {
            //Výchozí
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
            //Sloupce
            int[] tmp = new int[Convert.ToInt32(NumUpDown.Value)];
            for(int i= 1; i < tmp.Length; i++) 
            {
            tmp[i] = i;
            }
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
            //Řádky
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
            //Výpis
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
