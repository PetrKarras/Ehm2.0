namespace Nákupní_košík
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtAdd_Click(object sender, EventArgs e)
        {
            Zbozi zbozi = new Zbozi(Convert.ToInt32(TxtBoxCena.Text),CBoxTyp.Text,CBoxTyp.Text);
        }


        private void ButtRes_Click(object sender, EventArgs e)
        {
            LblOut.Text = "";
        }
    }
}