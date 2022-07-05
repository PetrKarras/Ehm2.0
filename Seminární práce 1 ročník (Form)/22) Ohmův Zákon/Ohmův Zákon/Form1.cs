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
                if(x is TextBox && x.Text == "")
                {
                    x.Text = "0";
                }
            }
            double U = Convert.ToDouble(TxtBoxU.Text);
            double I = Convert.ToDouble(TxtBoxI.Text);
            double R = Convert.ToDouble(TxtBoxR.Text);
            if (U == 0)
            {
                TxtBoxU.Text = $"{I * R}";
            }
            else if (I == 0)
            {
                TxtBoxI.Text = $"{U / R}";
            }
            else if (R == 0)
            {
                TxtBoxR.Text = $"{U / I}";
            }
            else
            {
                MessageBox.Show("Nvm co mám vypočítat", "Chyba");
            }
        }
    }
}