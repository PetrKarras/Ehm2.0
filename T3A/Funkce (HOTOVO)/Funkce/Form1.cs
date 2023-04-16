using System.Diagnostics;

namespace Funkce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ButtFce1_Click(object sender, EventArgs e)
        {
             new FormFunkce1().ShowDialog();
        }

        private void ButtFce2_Click(object sender, EventArgs e)
        {
            new FormFunkce2().ShowDialog();
        }

        private void ButtFce3_Click(object sender, EventArgs e)
        {
            new FormFunkce3().ShowDialog();
        }

        private void ButtFce4_Click(object sender, EventArgs e)
        {
            new FormFunkce4().ShowDialog();
        }

        private void ButtFce5_Click(object sender, EventArgs e)
        {
            new FormFunkce5().ShowDialog();
        }

        private void ButtFce6_Click(object sender, EventArgs e)
        {
            new FormFunkce6().ShowDialog();
        }

        private void ButtFce7_Click(object sender, EventArgs e)
        {
            new FormFunkce7().ShowDialog();
        }

        private void ButtFce8_Click(object sender, EventArgs e)
        {
            new FormFunkce8().ShowDialog();
        }

        private void ButtFce9_Click(object sender, EventArgs e)
        {
            new FormFunkce9().ShowDialog();
        }

        private void ButtFce10_Click(object sender, EventArgs e)
        {
            new FunkceForm10().ShowDialog();
        }

        private void ButtFce12_Click(object sender, EventArgs e)
        {
            new FormFunkce12().ShowDialog();
        }
        private void ButtFce13_Click(object sender, EventArgs e)
        {
            new FormFunkce13().ShowDialog();
        }
        private void ButtInfo_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "list.txt");
        }

        private void ButtFce11_Click(object sender, EventArgs e)
        {
            new FormFunkce11().ShowDialog();
        }
    }
}