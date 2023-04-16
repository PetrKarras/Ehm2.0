using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funkce
{
    public partial class FormFunkce1 : Form
    {
        public FormFunkce1()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            LblOut.Text = "";
            decimal[] pole = {NumUD1.Value,NumUD2.Value,NumUD3.Value };
            Array.Sort(pole);
            // Nejsem si jist proč to takhle funguje ale fungujeto je to kratší než v {}
            if (RadButSes.Checked) Array.Reverse(pole);
            foreach(decimal p in pole)
            LblOut.Text += $"{p} ";
        }
    }
}
