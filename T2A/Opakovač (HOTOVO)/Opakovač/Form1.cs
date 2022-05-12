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
            TxtBoxOut.Text = "";
            int a = Convert.ToInt32(NumUpDown.Value);
            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    if (i + 1 == a)
                    {
                        TxtBoxOut.Text += $"{i + 1}) {TxtBoxWord.Text}.{Environment.NewLine}";
                    }
                    else
                    {
                        TxtBoxOut.Text += $"{i + 1}) {TxtBoxWord.Text},{Environment.NewLine}";
                    }
                }
                else
                {
                    if (i + 1 == a)
                    {
                        TxtBoxOut.Text += $"{i+1}) {TxtBoxWord.Text}.{Environment.NewLine}";
                    }
                    else
                    {
                        TxtBoxOut.Text += $"{i + 1}) {TxtBoxWord.Text},{Environment.NewLine}";
                    }
                }

            }
        }
    }
}
