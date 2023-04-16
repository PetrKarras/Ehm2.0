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
    public partial class FormFunkce7 : Form
    {
        public FormFunkce7()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            LblOut.Text = $"{(NumUD1.Value + NumUD2.Value + NumUD3.Value + NumUP4.Value) / 4}";
        }
    }
}
