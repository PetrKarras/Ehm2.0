namespace Ohmův_Zákon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
           foreach(Control x in this.Controls)
            {
                if(x is NumericUpDown && x.Text == "")
                {
                    x.Text = "0";
                }
            }

            if (NumUDU.Value == 0 && NumUDI.Value != 0 && NumUDR.Value != 0)
            {
                NumUDU.Value = NumUDI.Value * NumUDR.Value;
                Button.Text = "U = R * I";
            }
            else if (NumUDI.Value == 0 && NumUDU.Value != 0 && NumUDR.Value != 0)
            {
                NumUDI.Value = NumUDU.Value / NumUDR.Value;
                Button.Text = "I = U / R";
            }
            else if (NumUDR.Value == 0 && NumUDI.Value != 0 && NumUDU.Value != 0)
            {
                NumUDR.Value = NumUDU.Value / NumUDI.Value;
                Button.Text = "R = U / I";
            }
            else
            {
                MessageBox.Show("Nvm co mám vypočítat", "Chyba");
            }
        }
    }
}