using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovač
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            LblOut.Text = "";
            int a = int.Parse(TxtBoxNum.Text);
            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    if (i + 1 == a)
                    {
                        LblOut.Text += $"{TxtBoxWord.Text}.\n";
                    }
                    else
                    {
                        LblOut.Text += $"{TxtBoxWord.Text},\n";
                    }
                }
                else
                {
                    if (i + 1 == a)
                    {
                        LblOut.Text += $"#{TxtBoxWord.Text}.\n";
                    }
                    else
                    {
                        LblOut.Text += $"#{TxtBoxWord.Text},\n";
                    }
                }

            }
            /* for (int i = 0; i < a-1; i++)
            {
                LblOut.Text += $"{TxtBoxWord.Text},\n";
            }
            LblOut.Text += $"{TxtBoxWord.Text}.\n";*/
        }
    }
}
