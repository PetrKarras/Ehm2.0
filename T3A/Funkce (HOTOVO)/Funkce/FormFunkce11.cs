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
    public partial class FormFunkce11 : Form
    {
        public FormFunkce11()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            if(TxtBoxA.Text == "")
            {
                MessageBox.Show("Chybí řetezec","Error 001");
                return;
            }
            if(TxtBoxZnak.Text == "")
            {
                MessageBox.Show("Chybá znak", "Error 002");
                return;
            }
            LblOut.Text = "";
            char[] pole = TxtBoxA.Text.ToCharArray();
            char znak = char.Parse(TxtBoxZnak.Text);
            int tmp = 0;
            foreach(char c in pole)
            {
                if(c == znak) tmp++;
            }
            LblOut.Text = $"v řetezci: {TxtBoxA.Text}{Environment.NewLine}se písmeno {znak} objevilo:{tmp}";
        }
    }
}
