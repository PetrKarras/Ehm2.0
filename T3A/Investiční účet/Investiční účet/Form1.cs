namespace Investiční_účet
{
    public partial class Form1 : Form
    {
        private Kasicka mojeKasicka = new();
        public Form1()
        {
            InitializeComponent();
            LblMoney.Text = $"{mojeKasicka.Penize}";
        }

        private void ButtObalka_Click(object sender, EventArgs e)
        {
            int tmp = Convert.ToInt32(TxtBoxProcenta.Text);
            if (tmp > 100 || tmp < 0)
            {
                MessageBox.Show("Procenta nesedí", "Error 005");
                return;
            }
            Obalka obalka = new(tmp, TxtBoxNote.Text);
            mojeKasicka.VlozitObalku(obalka);
            Aktualizace();
        }

        private void ButtMoney_Click(object sender, EventArgs e)
        {

            int tmp = Convert.ToInt32(TxtBoxMoney.Text);
            if (tmp < 0)
            {
                MessageBox.Show("Peníze nesedí", "Error 005");
                return;
            }
            mojeKasicka.VlozitPenize(tmp);

            Aktualizace();
        }
        private void Aktualizace()
        {
            LblMoney.Text = $"{mojeKasicka.Penize}";
            LblObalky.Text = "";
            foreach (Obalka item in mojeKasicka.ListObalek)
            {
                LblObalky.Text += $"{item}{Environment.NewLine}";
            }
        }
    }
}