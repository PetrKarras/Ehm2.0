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
    public partial class FormFunkce9 : Form
    {
        public FormFunkce9()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            LblOut.Text = $"{NumUD1.Value + NumUD2.Value}";
        }
    }
}
