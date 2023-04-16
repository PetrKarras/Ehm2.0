using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Analýza_souboru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Jméno čteného souboru
        private string fileName = "";
        //Tlačítko na vybrání souboru
        private void ButtFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = OpenFileDialog.FileName;
                LblFile.Text = OpenFileDialog.SafeFileName;
                ButtAnalyze.Enabled = true;
            }
        }
        // Tlačítko pro analyzování souboru
        private void ButtAnalyze_Click(object sender, EventArgs e)
        {
            int radek = 0;
            int slovo = 0;
            string tmp = "";

            using (StreamReader sr = new(fileName))
            {

                while (!sr.EndOfStream)
                {
                    tmp += Zrcadleni(sr.ReadLine()) + Environment.NewLine;
                    radek++;
                }
                sr.Close();
            }
            string kks = tmp.Replace(Environment.NewLine, " ");
            string[] spaces = tmp.Split(" ");
            string[] splitText = kks.Split(" ");

            foreach (string s in splitText)
            {
                if (Zrcadleni(s) == TxtBoxWord.Text)
                {
                    slovo++;
                }
            }
            //Výpis
            LblOut.Text = "";
            LblOut.Text += $"Počet řádků:{radek}" + Environment.NewLine;
            LblOut.Text += $"Počet znaků: {(tmp.Length - 2 * radek) - (spaces.Length - 1)}" + Environment.NewLine;
            LblOut.Text += $"Počet slov:{splitText.Length - 1}" + Environment.NewLine;
            LblOut.Text += $"{TxtBoxWord.Text} se vyskytuje:{slovo}" + Environment.NewLine;

            using StreamWriter sw = GetSw();
            sw.WriteLine(tmp);
            sw.Close();
        }

        private StreamWriter GetSw()
        {
            return new StreamWriter($"{fileName.Replace(".txt", "")}_zrcadleni.txt");
        }
        //zrcadlení textu
        private static string Zrcadleni(string text)
        {
            char[] textArray = text.ToCharArray();
            string reverse = "";
            for (int i = textArray.Length - 1; i > -1; i--)
            {
                reverse += textArray[i] switch
                {
                    '\n' => "\r",
                    '\r' => "\n",
                    _ => textArray[i],
                };
            }
            return reverse;
        }
    }
}