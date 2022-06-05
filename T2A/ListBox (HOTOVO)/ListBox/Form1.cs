using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// Fáze 1
            // Ukáže se random číslo
            Random i = new Random();
            int tmp = i.Next((int)NumUpDown.Value);
            if (LboxDef.Items.Contains(tmp))
            {
                MessageBox.Show($"Číslo {tmp} už tam je", "Chyba");
            }
            else
            {
                LboxDef.Items.Add(tmp);
            }
        }

        private void Bfaze2_Click(object sender, EventArgs e)
        {
            /// Fáze 2
            // Vypíše se řetezec ,který zadá uživatel
            string retezec = TxtBoxCislo.Text;
            if (!(LboxDef.Items.Contains(retezec)))
            {
                LboxDef.Items.Add(retezec);
            }
            else
            {
                MessageBox.Show("Slovo už tam je");
            }
        }
        /// Faze 3
        // Udělá se email podle jména
        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] celeJmeno = TxtBoxJmeno.Text.Split(' ');
            if (celeJmeno.Length == 2)
            {
                string jmeno = celeJmeno[0].ToLower() + "." + celeJmeno[1].ToLower() + "@hradebni.com";
                LboxDef.Items.Add(jmeno);
            }
            else
            {
                MessageBox.Show("Špatně zadané jméno", "Chyba");
            }

        }
        /// Faze 4
        // Třízedí do 2 list boxů
        private void button2_Click(object sender, EventArgs e)
        {
            string[] celeJmeno = TxtBoxJmeno2.Text.Split(' ');
            if(celeJmeno.Length == 2)
            {
                Person p = new Person(celeJmeno[0], celeJmeno[1]);
                
                if (CheckBsub.Checked)
                {
                    LBoxSub.Items.Add(p);
                }
                else
                {
                    LboxDef.Items.Add(p);
                }
            }
            else
            {
                MessageBox.Show("Špatně zadané jméno", "Chyba");
            }
        }
    }
    

    class Person
    {
        public string jmeno { get; }
        public string prijmeni { get; }
        public string mail { get; }
        public Person(string jmeno, string prijmeni)
        {
            mail = $"{prijmeni.ToLower()}.{jmeno.ToLower()}@hradebni.com";
        }


        public override string ToString()
        {
            return mail;
        }
    }
}
