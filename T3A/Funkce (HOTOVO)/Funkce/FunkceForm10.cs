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
    public partial class FunkceForm10 : Form
    {
        public FunkceForm10()
        {
            InitializeComponent();
        }

        private void NumUD1_Click(object sender, EventArgs e)
        {
            if(NumUD1.Value %7 == 0)BackColor = Color.Lime;
            else BackColor = Color.Red;

        }
    }
}
