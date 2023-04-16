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
    public partial class FormFunkce3 : Form
    {
        public FormFunkce3()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            if(TxtBox.Text =="")
            {
                MessageBox.Show("Chybí jméno", "Error 003");
                return;
            }
            LblOut.Text = $"{TxtBox.Text}_{NumUD.Value}";
        }
    }
}
