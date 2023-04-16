namespace _20__Viditelné_spektrum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NumUD.Value = 381;
        }

        private void NumUD_ValueChanged(object sender, EventArgs e)
        {
            decimal hodnota = NumUD.Value;
            if (hodnota <= 430) { BackColor = Color.BlueViolet; LblOUT.Text = "FF8Y2BE2"; }
            else if (hodnota <= 500) { BackColor = Color.Blue; LblOUT.Text = "FF0000FF"; }
            else if (hodnota <= 520) { BackColor = Color.Cyan; LblOUT.Text = "FF00FFFF"; }
            else if (hodnota <= 565) { BackColor = Color.Green; LblOUT.Text = "FF008000"; }
            else if (hodnota <= 590) { BackColor = Color.Yellow; LblOUT.Text = "FFFFFF00"; }
            else if (hodnota <= 625) { BackColor = Color.Orange; LblOUT.Text = "FFFFA500"; }
            else if (hodnota <= 740) { BackColor = Color.Red; LblOUT.Text = "FFFF0000"; }
        }
    }
}