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
    public partial class FormFunkce2 : Form
    {
        public FormFunkce2()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            foreach (Control n in Controls)
            {
                if (n is NumericUpDown)
                    n.BackColor = Color.White;
            }

            decimal[] pole = { NumUD1.Value, NumUD2.Value, NumUD3.Value, NumUP4.Value };

            foreach (Control n in Controls)
            {
                if (n is NumericUpDown down && down.Value == pole.Max())
                    n.BackColor = Color.Lime;
            }
        }
    }
}
