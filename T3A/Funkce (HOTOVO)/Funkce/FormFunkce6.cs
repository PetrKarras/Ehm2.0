using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Funkce
{
    public partial class FormFunkce6 : Form
    {
        public FormFunkce6()
        {
            InitializeComponent();
        }
        private void Butt_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "")
            {
                MessageBox.Show("Chybí Jméno", "Error 008");
                return;
            }
            MessageBox.Show($"Ahoj {TxtBox.Text}");
        }
    }
}
