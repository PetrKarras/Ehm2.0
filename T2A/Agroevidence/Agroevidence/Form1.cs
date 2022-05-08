namespace Agroevidence
{
    public partial class Form1 : Form
    {
        private string[] pseudodatab�ze = new string[10];
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtSave_Click(object sender, EventArgs e)
        {       
            if (ValidaceForms())
            {
                if (index < 10)
                {
                    if (CmdCIN.SelectedIndex == 0 || CmdCIN.SelectedIndex == 1)
                    {
                        if (TxtboxNAZ.Text != "" && CmdCIN.SelectedIndex != -1 && TxtboxVYM.Text != "")
                        {

                        }
                    }
                    else
                    {
                        string novaCinnost = TiskCinnosti();
                        MessageBox.Show(novaCinnost);
                        pseudodatab�ze[index] = novaCinnost;
                        index++;
                    }
                }
                else
                {
                    MessageBox.Show("Pln� datab�ze");
                }
            }
        }
        private void ButtZob_Click(object sender, EventArgs e)
        {
            string ret = "";
            foreach(string item in pseudodatab�ze)
            {
                if(item != "")
                {
                    ret += item + Environment.NewLine;
                }             
            }
            LblDatabaze.Text = ret;
        }
        private string TiskCinnosti()
        {
            return $"{CmdCIN.Text} na parcele {TxtboxNAZ.Text} ({TxtboxVYM.Text}ha) provedena." +
                $" {TiskAplikace()}{TxtboxPOZ.Text}";
        }

        private string TiskAplikace()
        {
            if (TxtboxMno.Text != "" && CmdJED.SelectedIndex != -1 && TxtboxPro.Text != "")
            {
                return $"Aplikace {TxtboxPro.Text} v mno�stv� {TxtboxMno.Text}{CmdJED.Text}";
            }
            else
            {
                return "";
            }
        }

        private bool ValidaceForms()
        {
            if (TxtboxNAZ.Text != "" && CmdCIN.SelectedIndex != -1 && TxtboxVYM.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Chyba");
                return false;
            }
 
        }
    }
}