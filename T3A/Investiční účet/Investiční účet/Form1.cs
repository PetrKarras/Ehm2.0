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
            Obalka obalka = new(tmp, TxtBoxNote.Text);
            mojeKasicka.ListObalek.Add(obalka);
        }

        private void ButtMoney_Click(object sender, EventArgs e)
        {
            int tmp = Convert.ToInt32(TxtBoxMoney.Text);
            mojeKasicka.Penize = tmp;
            LblMoney.Text = $"{mojeKasicka.Penize}";
        }
    }
}