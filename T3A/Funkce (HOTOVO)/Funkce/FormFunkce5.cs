using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Funkce
{
    public partial class FormFunkce5 : Form
    {
        public FormFunkce5()
        {
            InitializeComponent();
            LblOut.Text = "Jméno Přijmení, Plat" + Environment.NewLine;
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            if (TxtBoxName.Text == "")
            {
                MessageBox.Show("Chybí jméno", "Error 005");
                return;
            }
            if (TxtBoxSurname.Text == "")
            {
                MessageBox.Show("Chybá příjmení", "Error 006");
                return;
            }
            Osoba osoba = new(TxtBoxName.Text,TxtBoxSurname.Text,(int)NumUDPlat.Value);
            
            LblOut.Text += osoba.ToString() + Environment.NewLine;
        }
        struct Osoba
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Plat { get; set; }

            public Osoba(string name,string surname,int plat)
            {
                Name = name;
                Surname = surname; 
                Plat = plat;
            }
            public override string ToString()
            {
                return $"{Name} {Surname},{Plat}";
            }
        }
    }
}
