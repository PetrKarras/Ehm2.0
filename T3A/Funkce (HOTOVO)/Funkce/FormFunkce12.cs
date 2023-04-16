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
    public partial class FormFunkce12 : Form
    {
        public FormFunkce12()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            if (NumUD1.Value + NumUD2.Value > NumUD3.Value && NumUD2.Value + NumUD3.Value > NumUD1.Value && NumUD3.Value + NumUD1.Value > NumUD2.Value)
            {
                BackColor = Color.Lime;
            }
            else
            {
                BackColor = Color.Red;
            }
        }
    }
}
