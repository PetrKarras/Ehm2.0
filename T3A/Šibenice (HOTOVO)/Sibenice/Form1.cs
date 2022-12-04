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
            MessageBox.Show("Po dops�n� slova na n�j 2x klikny a hra za�ne", "N�pov�da");
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TxtBoxPismeno.Text != "")
            {
                pismeno = Convert.ToChar(TxtBoxPismeno.Text.ToUpper());
                hadanka = LblSlovo.Text.Replace(" ", null).ToCharArray();

                //Jesli je�t� �iju
                if (zivot != 1)
                {
                    //Jestli slovo obsahuje p�smeno
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
                //Vypsn� do labelu
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
                MessageBox.Show("Mus� vyplnit p�smeno kter� chce� h�dat", "Error 002");
            }
            Refresh();
        }
        //Potvrzen� slova
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
                MessageBox.Show("Mus� vyplnit slovo kter� se bude h�dat", "Error 001");
            }
        }
        //Obarven� label� abecedy
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

        //Vykreslen� do formul��e
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image img = Image.FromFile($"{zivot}.png");
            // zm�na obr�zku
            switch (zivot)
            {
                //SMRT
                case 1:
                    g.DrawImage(img, 0, 100);
                    LblSlovo.Text = slovo;
                    LblSlovo.ForeColor = Color.Red;
                    ButtRes.Visible = true;
                    ButtStart.Visible = false;
                    break;
                //Ob�en�
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    g.DrawImage(img, 0, 100);
                    break;
                //V�hra
                case 100:
                    g.DrawImage(img, 0, 100);
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
                if (c is Label && (string)c.Tag != null)
                {
                    c.BackColor = Control.DefaultBackColor;
                }

            }
            Refresh();
            ButtRes.Visible = false;
        }
    }
}