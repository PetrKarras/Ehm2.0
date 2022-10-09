using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinosál
{
    public partial class Form1 : Form
    {
        private Label[,] kino;
        public Form1()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(NumUDVel.Value);
            if (size <= 0)
            {
                MessageBox.Show("Kino nemůže být velké 0", "Error 001");
                return;
            }

            DeleteSeat();

            kino = new Label[size, size];

            //Tvoření kina
            for (int i = 0; i < kino.GetLength(0); i++)
            {
                for (int j = 0; j < kino.GetLength(1); j++)
                {
                    kino[i, j] = GenerateSeat(j, i);
                    Controls.Add(kino[i, j]);
                }
            }
            Label platno = GeneratePlatno(size);
            Controls.Add(platno);


        }

        private void DeleteSeat()
        {
            if (kino == null) return;

            for (int i = 0; i < kino.GetLength(0); i++)
            {
                for (int j = 0; j < kino.GetLength(1); j++)
                {
                    Controls.Remove(kino[i, j]);
                }
            }
        }

        public Label GenerateSeat(int a, int b)
        {
            Label l = new Label
            {
                Location = new Point(15 + 30 * a, 80 + 30 * b),
                Size = new Size(20, 20),
                BackColor = Color.Blue,
                Name = $"{a + 1}_{b + 1}",
            };
            l.Click += new EventHandler(SeatClick);
            return l;
        }
        public void SeatClick(object sender, EventArgs e)
        {
            if ((sender as Label).BackColor == Color.Blue)
            {
                (sender as Label).BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show($"Sedadlo {(sender as Label).Name} je obsazená", "Error 003");
            }
        }
        public Label GeneratePlatno(int a)
        {
            Label l = new Label()
            {
                Location = new Point(10,40),
                Size = new Size(30 * a, 30),
                Text = "Plátno",
                BackColor = Color.Gray,
                Name = "LblPanel"
            };
            return l;
        }
    }
}
