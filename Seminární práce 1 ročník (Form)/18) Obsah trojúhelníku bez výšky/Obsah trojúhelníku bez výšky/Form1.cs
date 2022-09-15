namespace Obsah_trojúhelníku_bez_výšky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (TrojuhelnikovaNerovnost(NumUDA.Value, NumUDB.Value, NumUDC.Value))
            {
                LblOut.Text = $"S = {(NumUDA.Value + NumUDB.Value + NumUDC.Value) / 2}";
            }
            else
            {
                LblOut.Text = "Hele chábře tohle nejde sestrojit";
            }
        }
        private bool TrojuhelnikovaNerovnost(decimal a ,decimal b,decimal c)
        {
            if (a + b > c)
            {
                if (a + c > b)
                {
                    if(b + c > a)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}