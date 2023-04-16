using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funkce
{
    public partial class FormFunkce4 : Form
    {
        public FormFunkce4()
        {
            InitializeComponent();
        }
        decimal[] pole = Array.Empty<decimal>();
        int tmp = 0;
        bool restart = false;
        private void ButtMinus_Click(object sender, EventArgs e)
        {
            if (restart)
                Restart();
            else
            {
                foreach (decimal c in pole)
                {
                    LblOutPole.Text += $"{c - 1},";
                }
                Butt.Text = "Restartovat ?";
                restart = true;
            }
        }

        private void ButtHot_Click(object sender, EventArgs e)
        {
            pole = new decimal[(int)NumUDPole.Value];
            ButHot.Enabled = false;
            ButtAdd.Enabled = true;
        }

        private void ButtAdd_Click(object sender, EventArgs e)
        {
            pole[tmp] = NumUDClen.Value;
            tmp++;
            LblOutClen.Text += $"{NumUDClen.Value}";
            if (tmp == pole.Length)
            {
                ButtAdd.Enabled = false;
                Butt.Enabled = true;
            }
            else
                LblOutClen.Text += $",";
        }
        private void Restart()
        {
            ButHot.Enabled = true;
            ButtAdd.Enabled = false;
            Butt.Enabled = false;
            Butt.Text = "-1";
            LblOutClen.Text = "";
            LblOutPole.Text = "";
            tmp = 0;
            restart = false;
        }
    }
}
