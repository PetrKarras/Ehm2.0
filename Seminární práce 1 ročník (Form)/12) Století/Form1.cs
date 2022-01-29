using System;
using System.Windows.Forms;

namespace _12__Století
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Butt_Click(object sender, EventArgs e)
        {
            string[] celeDatum = Txtbox.Text.Split(".", 3);
            LblOut.Text = $"Pro datum {Txtbox.Text} platí: {UrceniData(celeDatum)} ";
        }
        public string UrceniData(string[] datum)
        {
            int den = Convert.ToInt32(datum[0]);
            int mesic = Convert.ToInt32(datum[1]);
            int rokInt = Convert.ToInt32(datum[2]);
            float rokFloat = Convert.ToInt64(datum[2]);
            /// Zjištení století
            string stoletiString = "";
            //Zkrácený if               Podmíka která když je splěna přičte se 0 když ne přičte se 1 k výsledku z 1. závorky 
            float stoleti = (rokFloat / 100) + ((rokFloat % 100 == 0) ? 0 : 1);
            if (RadbuttNl.Checked)
            {
                stoletiString = stoleti + " " + RadbuttNl.Text;
            }
            else
            {
                stoletiString = stoleti + " " + RadButtPr.Text;
            }
            /// Zjištení historického období
            string obdobi = "";
            int dnesek = DateTime.Now.Year;
            if (RadButtPr.Checked)
            {
                if (rokFloat >= 2600000000)
                {
                    obdobi = "Prahory";
                }
                else if (rokFloat >= 560000000)
                {
                    obdobi = "Starohory";
                }
                else if (rokFloat >= 230000000)
                {
                    obdobi = "Druhohory";
                }
                else if (rokFloat >= 65000000)
                {
                    obdobi = "Třetihory";
                }
                else if (rokFloat >= 3000000)
                {
                    obdobi = "Čtvrtohory";
                }
                else if (rokFloat >= 4000)
                {
                    obdobi = "Pravěk";
                }
            }
            if (RadbuttNl.Checked)
            {
                if (rokFloat > 476 & rokFloat <= 1492)
                {
                    obdobi = "Středověk";
                }
                else if (rokFloat <= 1918)
                {
                    obdobi = "Novověk";
                }
                else if (rokFloat <= dnesek)
                {
                    obdobi = "Doba moderní";
                }
                else
                {
                    obdobi = "Budoucnost";
                }
            }
            if ((rokFloat < 4000 & RadButtPr.Checked) | (rokFloat <= 476 & RadbuttNl.Checked))
            {
                obdobi = "Starověk";
            }
            ///Zjisteni dne v tydnu
            DateTime date = new DateTime(rokInt, mesic, den);
            return $"{stoletiString.Remove(2,3)},{obdobi},{DenVTýdnu(date)}";
        }
        public string DenVTýdnu(DateTime date)
        {
            int datel = (int)date.DayOfWeek;
            if (datel == 0) { return "Neděle"; }
            else if (datel == 0) { return "Pondělí"; }
            else if (datel == 0) { return "Úterý"; }
            else if (datel == 0) { return "Středa"; }
            else if (datel == 0) { return "Čtvrek"; }
            else if (datel == 0) { return "Pátek"; }
            else { return "Sobota"; }
        }
    }
}

