using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Výtah
{
    public partial class Form1 : Form
    {
        private int vaha = 0;
        private int pocet = 0;
        private bool buttClicked = false;
        private int[] pohlavi = new int[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtADD_Click(object sender, EventArgs e)
        {
            //Oprava chyb
            if (TxtBoxIN.Text == "") { TxtBoxIN.Text = "0"; }
            if (COMBgen.Text == "") { COMBgen.Text = "Žena"; }
            //Změna barvy
            int vahatmp = int.Parse(TxtBoxIN.Text);
            if ((vaha + vahatmp) > 600)
            {
                LblVaha.BackColor = Color.Red;
                LblFullVaha.BackColor = Color.Red;
                return;
            }
            if (pocet + 1 > 6)
            {
                LblPocet.BackColor = Color.Red;
                return;
            }
            if (COMBgen.SelectedIndex == 1) { pohlavi[pocet] = 1; }
            else { pohlavi[pocet] = 2; }

            vaha += vahatmp;
            pocet++;
            //Refrech panelu 
            buttClicked = true;
            PanPaint.Refresh();
            buttClicked = false;
            //Výpis
            ListOut.Items.Add($"Osoba č.{pocet}){vahatmp}kg, {COMBgen.Text}{Environment.NewLine}");
            LblFullVaha.Text = $"Celková váha = {vaha} kg";

        }
        //Reset tlačítko
        private void ButtRess_Click(object sender, EventArgs e)
        {
            TxtBoxIN.Text = "";
            ListOut.Items.Clear();
            LblFullVaha.Text = "";
            COMBgen.Text = "";
            PanPaint.Refresh();
            for (int i = 0; i < pohlavi.Length; i++)
                pohlavi[i] = 0;
            vaha = 0;
            pocet = 0;

            LblPocet.BackColor = Color.Lime;
            LblVaha.BackColor = Color.Lime;
            LblFullVaha.BackColor = Color.Lime;
        }

        private void PanPaint_Paint(object sender, PaintEventArgs e)
        {
            Pen pero = new Pen(Color.Black, 4);
            Graphics g = e.Graphics;
            g.DrawRectangle(pero, 40, 50, 80, 120);
            g.DrawLine(pero, 80, 0, 80, 50);
            g.DrawLine(pero, 80, 250, 80, 170);

            Image muz = Image.FromFile("muz.png");
            Image zena = Image.FromFile("zena.png");

            if (buttClicked)
            {
                for (int i = 0; i < pohlavi.Length; i++)
                {
                    if (pohlavi[i] == 1)
                    {
                        if (i == 0) { g.DrawImage(muz, 45, 55); }
                        if (i == 1) { g.DrawImage(muz, 85, 55); }
                        if (i == 2) { g.DrawImage(muz, 45, 95); }
                        if (i == 3) { g.DrawImage(muz, 85, 95); }
                        if (i == 4) { g.DrawImage(muz, 45, 135); }
                        if (i == 5) { g.DrawImage(muz, 85, 135); }
                    }
                    else if(pohlavi[i] == 2) 
                    {
                        if (i == 0) { g.DrawImage(zena, 45, 55); }
                        if (i == 1) { g.DrawImage(zena, 85, 55); }
                        if (i == 2) { g.DrawImage(zena, 45, 95); }
                        if (i == 3) { g.DrawImage(zena, 85, 95); }
                        if (i == 4) { g.DrawImage(zena, 45, 135); }
                        if (i == 5) { g.DrawImage(zena, 85, 135); }
                    }
                }
            }

        }
    }
}

