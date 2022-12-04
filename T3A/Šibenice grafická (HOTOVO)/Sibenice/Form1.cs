using static System.Windows.Forms.DataFormats;
using System.Drawing;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Sibenice
{
    public partial class Form1 : Form
    {
        private int zivot = 13;
        private string slovo = "";
        private char[] hadanka;
        private char pismeno;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Po dopsání slova na nìj 2x klikny a hra zaène", "Nápovìda");
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TxtBoxPismeno.Text != "")
            {
                pismeno = Convert.ToChar(TxtBoxPismeno.Text.ToUpper());
                hadanka = LblSlovo.Text.Replace(" ", null).ToCharArray();
                //Jesli ještì žiju
                if (zivot != 1)
                {
                    //Jestli slovo obsahuje písmeno
                    if (slovo.Contains(pismeno))
                    {
                        for (int i = 0; i < hadanka.Length; i++)
                        {
                            if (slovo[i] == pismeno)
                            {
                                hadanka[i] = pismeno;
                            }
                        }
                        ObravitLbl(0);
                    }
                    else
                    {

                        ObravitLbl(1);
                        zivot--;
                    }
                }

                LblSlovo.Text = "";
                //Vypsní do labelu
                foreach (char item in hadanka)
                {
                    LblSlovo.Text += " " + item.ToString() + " ";
                }
                //Vyhra
                if (!LblSlovo.Text.Contains('-'))
                {
                    zivot = 100;

                }
            }
            else
            {
                MessageBox.Show("Musíš vyplnit písmeno které chceš hádat", "Error 002");
            }
            Refresh();
        }
        //Potvrzení slova
        private void TxtBoxSlovo_DoubleClick(object sender, EventArgs e)
        {
            if (TxtBoxSlovo.Text != "")
            {
                slovo = TxtBoxSlovo.Text.ToUpper();
                foreach (char c in slovo)
                {
                    LblSlovo.Text += " - ";
                }
                TxtBoxSlovo.Visible = false;
                TxtBoxPismeno.Visible = true;
                ButtStart.Visible = true;
            }
            else
            {
                MessageBox.Show("Musíš vyplnit slovo které se bude hádat", "Error 001");
            }

        }
        //Obarvení labelù abecedy
        private void ObravitLbl(int a)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Tag is string && Convert.ToChar(c.Tag) == pismeno)
                {
                    if (a == 0)
                    {
                        c.BackColor = Color.Green;
                    }
                    else
                    {
                        c.BackColor = Color.Red;
                    }
                }
            }
        }

        //Vykreslení do formuláøe
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // zmìna obrázku
            switch (zivot)
            {
                //SMRT
                case 1:
                    g.FillPie(Brushes.Green, 100, 250, 200, 100, 180, 180);
                    g.FillRectangle(Brushes.Green, 0, 285, 450, 20);
                    g.FillRectangle(Brushes.Brown, 0, 290, 450, 15);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 20, 100);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 80, 20);
                    g.FillRectangle(Brushes.BurlyWood, 205, 180, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 215, 170, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 210, 175, 10, 10);
                    g.FillRectangle(Brushes.Brown, 255, 170, 5, 25);
                    g.FillEllipse(Brushes.DodgerBlue, 247, 190, 20, 20);
                    g.FillRectangle(Brushes.Sienna, 255, 210, 5, 15);
                    g.FillRectangle(Brushes.DodgerBlue, 260, 210, 15, 5);
                    g.FillRectangle(Brushes.DodgerBlue, 240, 210, 15, 5);
                    g.FillRectangle(Brushes.DodgerBlue, 250, 225, 5, 5);
                    g.FillRectangle(Brushes.DodgerBlue, 248, 228, 5, 5);
                    g.FillRectangle(Brushes.Sienna, 252, 223, 5, 5);

                    g.FillRectangle(Brushes.DodgerBlue, 263, 225, 5, 5);
                    g.FillRectangle(Brushes.DodgerBlue, 265, 228, 5, 5);
                    g.FillRectangle(Brushes.Sienna, 260, 223, 5, 5);
                    g.DrawString("Byl jsi obìšen", new("Impact", 18), Brushes.Red, 150, 100);
                    LblSlovo.Text = slovo;
                    LblSlovo.ForeColor = Color.Red;
                    ButtRes.Visible = true;
                    ButtStart.Visible = false;
                    break;
                //Noha
                case 2:
                    g.FillPie(Brushes.Green, 100, 250, 200, 100, 180, 180);
                    g.FillRectangle(Brushes.Green, 0, 285, 450, 20);
                    g.FillRectangle(Brushes.Brown, 0, 290, 450, 15);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 20, 100);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 80, 20);
                    g.FillRectangle(Brushes.BurlyWood, 205, 180, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 215, 170, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 210, 175, 10, 10);
                    g.FillRectangle(Brushes.Brown, 255, 170, 5, 25);
                    g.FillEllipse(Brushes.Bisque, 247, 190, 20, 20);
                    g.FillRectangle(Brushes.Sienna, 255, 210, 5, 15);
                    g.FillRectangle(Brushes.Bisque, 260, 210, 15, 5);
                    g.FillRectangle(Brushes.Bisque, 240, 210, 15, 5);

                    g.FillRectangle(Brushes.Bisque, 250, 225, 5, 5);
                    g.FillRectangle(Brushes.Bisque, 248, 228, 5, 5);
                    g.FillRectangle(Brushes.Sienna, 252, 223, 5, 5);
                    break;
                //Levá ruka
                case 3:
                    g.FillPie(Brushes.Green, 100, 250, 200, 100, 180, 180);
                    g.FillRectangle(Brushes.Green, 0, 285, 450, 20);
                    g.FillRectangle(Brushes.Brown, 0, 290, 450, 15);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 20, 100);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 80, 20);
                    g.FillRectangle(Brushes.BurlyWood, 205, 180, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 215, 170, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 210, 175, 10, 10);
                    g.FillRectangle(Brushes.Brown, 255, 170, 5, 25);
                    g.FillEllipse(Brushes.Bisque, 247, 190, 20, 20);
                    g.FillRectangle(Brushes.Sienna, 255, 210, 5, 15);
                    g.FillRectangle(Brushes.Bisque, 260, 210, 15, 5);

                    g.FillRectangle(Brushes.Bisque, 240, 210, 15, 5);
                    break;
                //Pravá ruka
                case 4:
                    g.FillPie(Brushes.Green, 100, 250, 200, 100, 180, 180);
                    g.FillRectangle(Brushes.Green, 0, 285, 450, 20);
                    g.FillRectangle(Brushes.Brown, 0, 290, 450, 15);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 20, 100);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 80, 20);
                    g.FillRectangle(Brushes.BurlyWood, 205, 180, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 215, 170, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 210, 175, 10, 10);
                    g.FillRectangle(Brushes.Brown, 255, 170, 5, 25);
                    g.FillEllipse(Brushes.Bisque, 247, 190, 20, 20);
                    g.FillRectangle(Brushes.Sienna, 255, 210, 5, 15);

                    g.FillRectangle(Brushes.Bisque, 260, 210, 15, 5);
                    break;
                //Tìlo
                case 5:
                    g.FillPie(Brushes.Green, 100, 250, 200, 100, 180, 180);
                    g.FillRectangle(Brushes.Green, 0, 285, 450, 20);
                    g.FillRectangle(Brushes.Brown, 0, 290, 450, 15);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 20, 100);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 80, 20);
                    g.FillRectangle(Brushes.BurlyWood, 205, 180, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 215, 170, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 210, 175, 10, 10);
                    g.FillRectangle(Brushes.Brown, 255, 170, 5, 25);
                    g.FillEllipse(Brushes.Bisque, 247, 190, 20, 20);

                    g.FillRectangle(Brushes.Sienna, 255, 210, 5, 15);
                    break;
                //Hlava
                case 6:
                    g.FillPie(Brushes.Green, 100, 250, 200, 100, 180, 180);
                    g.FillRectangle(Brushes.Green, 0, 285, 450, 20);
                    g.FillRectangle(Brushes.Brown, 0, 290, 450, 15);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 20, 100);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 80, 20);
                    g.FillRectangle(Brushes.BurlyWood, 205, 180, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 215, 170, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 210, 175, 10, 10);
                    g.FillRectangle(Brushes.Brown, 255, 170, 5, 25);

                    g.FillEllipse(Brushes.Bisque, 248, 190, 20, 20);
                    break;
                //Lano
                case 7:
                    g.FillPie(Brushes.Green, 100, 250, 200, 100, 180, 180);
                    g.FillRectangle(Brushes.Green, 0, 285, 450, 20);
                    g.FillRectangle(Brushes.Brown, 0, 290, 450, 15);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 20, 100);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 80, 20);
                    g.FillRectangle(Brushes.BurlyWood, 205, 180, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 215, 170, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 210, 175, 10, 10);

                    g.FillRectangle(Brushes.Brown, 255, 170, 5, 25);
                    break;
                //Podpora
                case 8:
                    g.FillPie(Brushes.Green, 100, 250, 200, 100, 180, 180);
                    g.FillRectangle(Brushes.Green, 0, 285, 450, 20);
                    g.FillRectangle(Brushes.Brown, 0, 290, 450, 15);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 20, 100);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 80, 20);

                    g.FillRectangle(Brushes.BurlyWood, 205, 180, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 215, 170, 10, 10);
                    g.FillRectangle(Brushes.BurlyWood, 210, 175, 10, 10);
                    break;
                //Elko
                case 9:
                    g.FillPie(Brushes.Green, 100, 250, 200, 100, 180, 180);
                    g.FillRectangle(Brushes.Green, 0, 285, 450, 20);
                    g.FillRectangle(Brushes.Brown, 0, 290, 450, 15);
                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 20, 100);

                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 80, 20);
                    break;
                //Stožár
                case 10:
                    g.FillPie(Brushes.Green, 100, 250, 200, 100, 180, 180);
                    g.FillRectangle(Brushes.Green, 0, 285, 450, 20);
                    g.FillRectangle(Brushes.Brown, 0, 290, 450, 15);

                    g.FillRectangle(Brushes.BurlyWood, 185, 151, 20, 100);
                    break;
                //Kopec
                case 11:
                    g.FillPie(Brushes.Green, 100, 250, 200, 100, 180, 180);
                    g.FillRectangle(Brushes.Green, 0, 285, 450, 20);

                    g.FillRectangle(Brushes.Brown, 0, 290, 450, 15);
                    break;
                // Zem
                case 12:
                    g.FillRectangle(Brushes.Green, 0, 285, 450, 20);
                    g.FillRectangle(Brushes.Brown, 0, 290, 450, 15);
                    break;
                //Výhra
                case 100:
                    g.DrawString("Vyhrál jsi", new("Impact", 30), Brushes.Lime, 120, 100);
                    //Hlava
                    g.FillEllipse(Brushes.Bisque, 170, 150, 60, 60);
                    //Tìlo
                    g.FillRectangle(Brushes.Sienna, 190, 210, 20, 50);
                    //Ruce
                    g.FillRectangle(Brushes.Bisque, 175, 230, 10, 40);
                    g.FillRectangle(Brushes.Bisque, 225, 210, 40, 10);
                    //Triko
                    g.FillRectangle(Brushes.Sienna, 175, 210, 50, 20);
                    //Nohy
                    g.FillRectangle(Brushes.Bisque, 190, 260, 9, 35);
                    g.FillRectangle(Brushes.Bisque, 200, 260, 9, 35);
                    //Palec nahoru
                    g.FillRectangle(Brushes.Bisque, 255, 205, 5, 5);
                    //Pásek
                    g.FillRectangle(Brushes.Black, 190, 250, 20, 5);
                    g.FillRectangle(Brushes.Silver, 197, 250, 5, 5);

                    LblSlovo.ForeColor = Color.Green;
                    ButtRes.Visible = true;
                    break;
            }

        }

        //Resart aplikace
        private void ButtRes_Click(object sender, EventArgs e)
        {
            ButtStart.Visible = false;
            TxtBoxPismeno.Visible = false;
            TxtBoxSlovo.Visible = true;
            LblSlovo.Text = "";
            LblSlovo.ForeColor = Color.Black;
            TxtBoxPismeno.Text = "";
            TxtBoxSlovo.Text = "";
            zivot = 13;
            foreach (Control c in this.Controls)
            {
                if (c is Label && Convert.ToString(c.Tag) != null)
                {
                    c.BackColor = Control.DefaultBackColor;
                }

            }
            Refresh();
            ButtRes.Visible = false;
        }
    }
}