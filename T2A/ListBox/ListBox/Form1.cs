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
            // Fáze 1
            Random i = new Random();
            int tmp = i.Next(11);
            if (LboxDef.Items.Contains(tmp))
            {
                MessageBox.Show("číslo už tam je");
            }
            else
            {
                LboxDef.Items.Add(tmp);
            }
        }

        private void Bfaze2_Click(object sender, EventArgs e)
        {
            // Fáze 2
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
        //Faze 3
        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] celeJmeno = TxtBoxJmeno.Text.Split(' ');
            string jmeno = celeJmeno[0].ToLower() + "." + celeJmeno[1].ToLower() + "@hradebni.com";
            LboxDef.Items.Add(jmeno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string[] celeJmeno = TxtBoxJmeno2.Text.Split(' ');
          Person p = new Person(celeJmeno[0], celeJmeno[1]);
            //string jmeno = celeJmeno[0].ToLower() + "." + celeJmeno[1].ToLower() + "@hradebni.com";
            if (CheckBsub.Checked)
            {
                LBoxSub.Items.Add(p);
            }
            
                LboxDef.Items.Add(p);
            
        }

        private void CheckBsub_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    class Person
    {
        public string jmeno { get; }
        public string prijmeni { get; }
        public string mail { get; }
        public Person(string jmeno,string prijmeni)
        {

        }


        public override string ToString()
        {
            return mail;
        }
    }
}
