using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ISBN_10
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void ButtDek_Click(object sender, EventArgs e)
        {
            //Proměné pro zamezení chybného vstupu
            bool prazdno = TxtBoxNazev.Text == "" | TxtBoxISBN.Text == "";
            bool delka = TxtBoxISBN.TextLength < 16;
            bool spravnyObsah = false;
            bool spravnyZapis = TxtBoxISBN.Text[4] == ' ' | TxtBoxISBN.Text[4] == '-';
            for (int i = 5; i < TxtBoxISBN.Text.Length; i++)
            {
                string[] pole = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "X", "-", " " };
                if (!(pole.Contains(TxtBoxISBN.Text[i].ToString())))
                {
                    MessageBox.Show($"ISBN nemuže obsahovat {TxtBoxISBN.Text[i]}", "ERROR");
                    spravnyObsah = true;
                }
            }
            // Využizí proměných pro zamezení chybného vstupu
            if (prazdno == true | delka == true | spravnyObsah == true | spravnyZapis == false)
            {
                if (prazdno == true) MessageBox.Show("Kniha nemá název nebo ISBN kód","ERROR");
                if (delka == true) MessageBox.Show("Kniha nemá dostatečnou délku ISBN kód", "ERROR");
                if (spravnyZapis == false) MessageBox.Show("Prosím zadejte ISBN podle příkladu", "ERROR");
            }
            else
            {               
                ClassISBN hodnota = new ClassISBN(TxtBoxISBN.Text.ToUpper(), TxtBoxNazev.Text);
                //Zamezení dulpikace
                if (ListOut.Items.Contains(hodnota) | hodnota.VysledekExistuje == false)
                {
                    if(hodnota.VysledekExistuje == false)
                    {
                        MessageBox.Show("ISBN nemůže existovat");
                    }
                    else
                    {
                        MessageBox.Show("ISBN tu už je", "ERROR");
                    }
                }
                else
                {
                    ListOut.Items.Add(hodnota);
                }
            }
        }
        //Mazací tlačítko
        private void ButtDel_Click(object sender, EventArgs e)
        {
            DialogResult potvrzeniDel = MessageBox.Show("Chcete Opravdu odsrtranit toto ISBN",
                "Odstranění", MessageBoxButtons.YesNo);
            if (potvrzeniDel == DialogResult.Yes)
            {
                if (ListOut.SelectedIndex == -1)
                {
                    MessageBox.Show("Musíte vybrat ISBN kód");
                }
                else
                {
                    ListOut.Items.RemoveAt(ListOut.SelectedIndex);
                }
            }
        }
        //Mazání pomocí dvoukliku
        private void ListOut_DoubleClick(object sender, EventArgs e)
        {
            DialogResult potvrzeniDel = MessageBox.Show("Chcete Opravdu odsrtranit toto ISBN",
                "Odstranění", MessageBoxButtons.YesNo);
            if (potvrzeniDel == DialogResult.Yes)
            {
                ListOut.Items.RemoveAt(ListOut.SelectedIndex);
            }
        }
        //Exportovací tlačítko
        private void ButtExp_Click(object sender, EventArgs e)
        {
            SaveFileDialog vyhledavac = new SaveFileDialog { DefaultExt = "csv" };
            if (vyhledavac.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(vyhledavac.FileName);
                sw.WriteLine("ISBN;region;název");
                foreach (var item in ListOut.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
            }
        }
        //Čistící tlačítko
        private void ButtClear_Click(object sender, EventArgs e)
        {
            ListOut.Items.Clear();
        }

        private void ListOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


