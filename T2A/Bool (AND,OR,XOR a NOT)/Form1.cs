using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bool__AND_OR_XOR_a_NOT_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a1 = false;
            bool a2 = false;
            bool a3 = true;
            bool a4 = true;

            bool b1 = false;
            bool b2 = true;
            bool b3 = false;
            bool b4 = true;

            if (checkBox1.Checked)
            {
                a1 = !a1;
                a2 = !a2;
                a3 = !a3;
                a4 = !a4;
            }

            if (checkBox2.Checked)
            {
                b1 = !b1;
                b2 = !b2;
                b3 = !b3;
                b4 = !b4;
            }

            if (AND.Checked)
            {
                textBox1.Text = (a1 && b1).ToString();
                textBox2.Text = (a2 && b2).ToString();
                textBox3.Text = (a3 && b3).ToString();
                textBox4.Text = (a4 && b4).ToString();
            }
            if (AND.Checked && Neg.Checked)
            {
                textBox1.Text = (!(a1 && b1)).ToString();
                textBox2.Text = (!(a2 && b2)).ToString();
                textBox3.Text = (!(a3 && b3)).ToString();
                textBox4.Text = (!(a4 && b4)).ToString();
            }

            if (OR.Checked)
            {
                textBox1.Text = (a1 || b1).ToString();
                textBox2.Text = (a2 || b2).ToString();
                textBox3.Text = (a3 || b3).ToString();
                textBox4.Text = (a4 || b4).ToString();
            }
            if (OR.Checked && Neg.Checked)
            {
                textBox1.Text = (!(a1 || b1)).ToString();
                textBox2.Text = (!(a2 || b2)).ToString();
                textBox3.Text = (!(a3 || b3)).ToString();
                textBox4.Text = (!(a4 || b4)).ToString();
            }

            if (XOR.Checked)
            {
                textBox1.Text = (a1 ^ b1).ToString();
                textBox2.Text = (a2 ^ b2).ToString();
                textBox3.Text = (a3 ^ b3).ToString();
                textBox4.Text = (a4 ^ b4).ToString();
            }
            if (XOR.Checked && Neg.Checked)
            {
                textBox1.Text = (!(a1 ^ b1)).ToString();
                textBox2.Text = (!(a2 ^ b2)).ToString();
                textBox3.Text = (!(a3 ^ b3)).ToString();
                textBox4.Text = (!(a4 ^ b4)).ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                labelA1.Text = "1";
                labelA2.Text = "1";
                labelA3.Text = "0";
                labelA4.Text = "0";
            }
            else
            {
                labelA1.Text = "0";
                labelA2.Text = "0";
                labelA3.Text = "1";
                labelA4.Text = "1";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                labelB1.Text = "1";
                labelB2.Text = "0";
                labelB3.Text = "1";
                labelB4.Text = "0";

            }
            else
            {
                labelB1.Text = "0";
                labelB2.Text = "1";
                labelB3.Text = "0";
                labelB4.Text = "1";
            }
        }
    }
}
