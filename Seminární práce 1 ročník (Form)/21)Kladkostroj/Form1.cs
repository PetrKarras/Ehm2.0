using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kladkostroj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtVyp_Click(object sender, EventArgs e)
        {
            LblOut.Text = $"Musíme působit silou {int.Parse(TxtBoxVaha.Text) * 10 / Math.Pow(2, Convert.ToInt32(NumVol.Value))} N";
        }
    }
}
