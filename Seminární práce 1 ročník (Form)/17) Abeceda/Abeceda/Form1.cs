namespace Abeceda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public char[] text = Array.Empty<char>();
        public static char[] abeceda = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public int[] pocetVýskytu = new int[abeceda.Length];

        public int[] pocetVyskytuMax = new int[abeceda.Length];
        public int[] pocetVyskytuMaxIndex = new int[abeceda.Length];

        private void Button_Click(object sender, EventArgs e)
        {
            LblOut.Text = "";
            text = TxtBox.Text.ToLower().ToCharArray();
            Obsah();

            // Abecednì od A
            if (RadButtAUp.Checked)
            {
                for (int i = 0; i < abeceda.Length; i++)
                {
                    LblOut.Text += $"{abeceda[i]}  -   {pocetVýskytu[i]} {Environment.NewLine}";
                }
            }

            // Abecednì od Z
            if (RadButtADown.Checked)
            {
                for (int i = abeceda.Length-1; i > -1; i--)
                {
                    LblOut.Text += $"{abeceda[i]}  -   {pocetVýskytu[i]} {Environment.NewLine}";
                }
            }

            if (RadButtBUp.Checked)
            {
                for (int i = 0; i < pocetVýskytu.Length; i++)
                {
                    pocetVyskytuMax[i] = pocetVýskytu.Max();
                    pocetVyskytuMaxIndex[i] = pocetVýskytu.ToList().IndexOf(pocetVýskytu.Max());
                    pocetVýskytu[pocetVyskytuMaxIndex[i]] = -1;
                }
                for (int i = 0; i < abeceda.Length; i++)
                {
                    LblOut.Text += $"{abeceda[pocetVyskytuMaxIndex[i]]}  - {pocetVyskytuMax[i]} {Environment.NewLine}";
                }
            }
            // Nejnepoužívanìjší
            if (RadButtBDown.Checked)
            {
                for (int i = pocetVýskytu.Length-1; i >-1; i--)
                {
                    pocetVyskytuMax[i] = pocetVýskytu.Max();
                    pocetVyskytuMaxIndex[i] = pocetVýskytu.ToList().IndexOf(pocetVýskytu.Max());
                    pocetVýskytu[pocetVyskytuMaxIndex[i]] = -1;
                }
                for (int i = 0; i < abeceda.Length; i++)
                {
                    LblOut.Text += $"{abeceda[pocetVyskytuMaxIndex[i]]}  - {pocetVyskytuMax[i]} {Environment.NewLine}";
                }
            }

        }
        private void Obsah()
        {
            for (int i = 0; i < abeceda.Length; i++)
            {
                pocetVýskytu[i] = 0;
                pocetVyskytuMax[i] = 0;
                pocetVyskytuMaxIndex[i] = 0;
            }

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < abeceda.Length; j++)
                {
                    if (text[i] == abeceda[j])
                    {
                        pocetVýskytu[j] = pocetVýskytu[j] + 1;
                        break;
                    }
                }
            }
        }
    }
}