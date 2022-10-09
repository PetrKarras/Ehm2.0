using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortal_Kombat
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //Grafická změno objevení textboxů,zmizení labelů
            ChangeGUI(0);
        }
        //AttackMax,AttackMin,Deff,Name
        Player p1 = new Player();
        Player p2 = new Player();
        private void ButtChange_Click(object sender, EventArgs e)
        {
            ChangeGUI(0);
        }
        private void ButtFight_Click(object sender, EventArgs e)
        {
            if (TxtBoxPlayer1.Text == "" || TxtBoxPlayer2.Text == "")
            {
                MessageBox.Show("Jméno nemůže být prázdné", "Error 001");
                return;
            }
            //Grafická změno objevení labelů,zmizení textboxů
            ChangeGUI(1);

            //AttackMax,AttackMin,Deff,Name
            p1 = new Player(10, 5, 6, TxtBoxPlayer1.Text);
            p2 = new Player(10, 5, 6, TxtBoxPlayer2.Text);

            // Grafická zápis
            LblPlayer1.Text = p1.ToString();
            LblPlayer2.Text = p2.ToString();

            string log = "";

            while (p1.HP > 0 && p2.HP > 0)
            {
                Random rnd = new Random();

                //Kontrola jestli hráč 1 žije
                if (p1.HP <= 0)
                {
                    log += p1.ToString() + " vs " + p2.ToString() + Environment.NewLine;
                    LblLog.Text = log;
                    WinSituation();

                    return;
                }
                double utokHrace1 = rnd.Next(p1.AttackMin, p1.AttackMax + 1) / (double)p2.Deff;
                p2.HP = (int)(10 * utokHrace1);

                // Kontrola jestli hráč 2 žije
                if (p2.HP <= 0)
                {
                    log += p1.ToString() + " vs " + p2.ToString() + Environment.NewLine;
                    LblLog.Text = log;
                    WinSituation();
                    return;
                }

                double utokHrace2 = rnd.Next(p2.AttackMin, p2.AttackMax + 1) / (double)p1.Deff;
                p1.HP = (int)(10 * utokHrace2);
                Refresh();
                //Zpomalení
                System.Threading.Thread.Sleep(1000);
                log += p1.ToString() + " vs " + p2.ToString() + Environment.NewLine;
                LblLog.Text = log;
            }
            WinSituation();


        }
        private void WinSituation()
        {
            ChangeGUI(2);
            if (p1.HP > p2.HP)
            {
                MessageBox.Show($"{p1}", "WIN");
            }
            else
            {
                MessageBox.Show($"{p2}", "WIN");
            }
        }
        private void ChangeGUI(int tmp)
        {
            if (tmp == 0)
            {
                TxtBoxPlayer1.Visible = true;
                TxtBoxPlayer2.Visible = true;
                LblPlayer1.Visible = false;
                LblPlayer2.Visible = false;
                ButtChange.Visible = true;
            }
            else if (tmp == 1)
            {
                TxtBoxPlayer1.Visible = false;
                TxtBoxPlayer2.Visible = false;
                LblPlayer1.Visible = true;
                LblPlayer2.Visible = true;
                ButtChange.Visible = false;
            }
            else if (tmp == 2)
            {
                TxtBoxPlayer1.Visible = false;
                TxtBoxPlayer2.Visible = false;
                LblPlayer1.Visible = true;
                LblPlayer2.Visible = true;
                ButtChange.Visible = true;
            }

        }

        private void TxtBoxPlayer1_Click(object sender, EventArgs e)
        {
            TxtBoxPlayer1.Text = "";
        }

        private void TxtBoxPlayer2_Click(object sender, EventArgs e)
        {
            TxtBoxPlayer2.Text = "";
        }
    }
}
