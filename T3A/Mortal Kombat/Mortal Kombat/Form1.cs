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
            p1 = (Player)ComBoxPlayer1.SelectedItem;
            p2 = (Player)ComBoxPlayer2.SelectedItem;
            if (TxtBoxPlayer1.Text == "" || TxtBoxPlayer2.Text == "")
            {
                MessageBox.Show("Jméno nemůže být prázdné", "Error 001");
                return;
            }
            //Grafická změno objevení labelů,zmizení textboxů
            ChangeGUI(1);

            // Grafická zápis
            LblPlayer1.Text = p1.ToString();
            LblPlayer2.Text = p2.ToString();

            p1.RestoreHP();
            p2.RestoreHP();

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
            switch (tmp)
            {
                case 0:
                    TxtBoxPlayer1.Visible = true;
                    TxtBoxPlayer2.Visible = true;
                    LblPlayer1.Visible = false;
                    LblPlayer2.Visible = false;
                    ButtChange.Visible = true;
                    break;
                case 1:
                    TxtBoxPlayer1.Visible = false;
                    TxtBoxPlayer2.Visible = false;
                    LblPlayer1.Visible = true;
                    LblPlayer2.Visible = true;
                    ButtChange.Visible = false;
                    break;
                case 2:
                    TxtBoxPlayer1.Visible = false;
                    TxtBoxPlayer2.Visible = false;
                    LblPlayer1.Visible = true;
                    LblPlayer2.Visible = true;
                    ButtChange.Visible = true;
                    break;
            }
        }

        private void ButtNewPlayer_Click(object sender, EventArgs e)
        {
            Player p1 = new Player();
            PlayerForm create = new PlayerForm();
            if (create.ShowDialog() == DialogResult.OK)
            {
                p1 = new Player(create.MaxAttack, create.MinAttack, create.Deff, create.PlayerName);
            }

            ComBoxPlayer1.Items.Add(p1);
            ComBoxPlayer1.Items.Add(p1);
        }
    }
}
