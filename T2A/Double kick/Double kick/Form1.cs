using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double_kick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int x = -1;
        int y = -1;
        
        
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point mouseclick = Cursor.Position;
            x = mouseclick.X;
            y = mouseclick.Y;
           
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();
            Graphics g = e.Graphics;
            
            int k = rnd.Next(1, 1000);
            if (x != -1 && y != -1)
            {
                g.FillRectangle(Brushes.Red, x, y, k, k);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
