using System.IO;
using System.Text;

namespace _05_KnihaJizd
{
    public partial class Form1 : Form
    {
        private List<Jizda> seznamJizd;
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnReadFile_Click_1(object sender, EventArgs e)
        {
            seznamJizd = new List<Jizda>();
            if (TxtFileName.Text == "")
            {
                MessageBox.Show("Zadejte název souboru");
                return;
            }
            LblOutDatum.Text = "";
            using (StreamReader sr = new StreamReader(TxtFileName.Text, Encoding.Latin1))
            {
                while (!sr.EndOfStream)
                {
                    Jizda tmp = GetJizda(sr.ReadLine());
                    if (tmp != null) seznamJizd.Add(tmp);
                }

            }
            ZobrazitJizdu();
        }

        private Jizda GetJizda(string? v)
        {
            if (v == "stroj;spz")
            {
                return null;
            }
            string[] kks = v.Split(";");
            return new(kks[0], kks[1], kks[2], kks[3], kks[4]);
        }
        private void ZobrazitJizdu()
        {
            Jizda j = seznamJizd[index];
            LblOUTRidic.Text = j.Ridic;
            LblOutDatum.Text = j.Datum;
            LblOutAuto.Text = j.Auto;
            LblOutZbozi.Text = j.Zbozi;
            LblOutSpz.Text = j.Spz;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (seznamJizd == null)
            {
                MessageBox.Show("Naèti soubor", "ERROR 12");
                return;
            }
            index++;
            if (index == seznamJizd.Count - 1) index = 0;
            ZobrazitJizdu();
        }

        private void ButtLeft_Click(object sender, EventArgs e)
        {
            if (seznamJizd == null)
            {
                MessageBox.Show("Naèti soubor", "ERROR 12");
                return;
            }
            index--;
            if (index == -1) index = seznamJizd.Count - 1;
            ZobrazitJizdu();
        }
    }
}