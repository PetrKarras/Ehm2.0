using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

namespace System_IO
{
    public partial class Form1 : Form
    {
        private List<Jizda> jizdaList = new();
        public Form1()
        {
            InitializeComponent();
            foreach (Control x in this.Controls)
            {
                if (x is ComboBox)
                {
                    ((ComboBox)x).SelectedIndex = Convert.ToInt32(x.Tag);
                }
            }
        }

        private void ButtPress_Click(object sender, EventArgs e)
        {
            jizdaList = new();

            if (TxtBox.Text == "")
            {
                MessageBox.Show("Napiš soubor který chceš pøeèíst", "Error 007");
            }
            LblRidicOUT.Text = "";
            int pocitadlo = 0;
            using (StreamReader sr = new(TxtBox.Text))
            {
                while (!sr.EndOfStream)
                {
                    if (pocitadlo != 0)
                    {
                        Jizda tmp = GetJizda(sr.ReadLine());
                        if (tmp != null) jizdaList.Add(tmp);

                    }
                    pocitadlo = 1;
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is Label && ((Label)x).Tag != null)
                {
                    ((Label)x).Text = "";
                }
            }
            LblRidicOUT.Tag = CMBBox1.SelectedIndex;
            LblDatumOUT.Tag = CMBBox2.SelectedIndex;
            LblZboziOUT.Tag = CMBBox3.SelectedIndex;
            LblAutoOUT.Tag = CMBBox4.SelectedIndex;
            LblSpzOUT.Tag = CMBBox5.SelectedIndex;

            foreach (Jizda jizda in jizdaList)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is Label && ((Label)x).Tag != null)
                    {
                        switch (Convert.ToInt32(((Label)x).Tag))
                        {
                            case 0:
                                ((Label)x).Text += jizda.Ridic.ToString() + Environment.NewLine;
                                break;
                            case 1:
                                ((Label)x).Text += jizda.Datum.ToString() + Environment.NewLine;
                                break;
                            case 2:
                                ((Label)x).Text += jizda.Zbozi.ToString() + Environment.NewLine;
                                break;
                            case 3:
                                ((Label)x).Text += jizda.Auto.ToString() + Environment.NewLine;
                                break;
                            case 4:
                                ((Label)x).Text += jizda.Spz.ToString() + Environment.NewLine;
                                break;
                        }
                    }
                }
            }
        }

        private static Jizda GetJizda(string v)
        {
            if (v == "datum;øidiè;typ zboží;stroj;spz")
            {
                return null;
            }
            string[] kks = v.Split(";");
            return new(kks[0], kks[1], kks[2], kks[3], kks[4]);
        }

        private void CheckBoxCheck(object sender, EventArgs e)
        {
            LblRidicOUT.Visible = CheckBoxRidic.Checked;
            LblDatumOUT.Visible = CheckBoxDatum.Checked;
            LblZboziOUT.Visible = CheckBoxZbozi.Checked;
            LblAutoOUT.Visible = CheckBoxAuto.Checked;
            LblSpzOUT.Visible = CheckBoxSpz.Checked;
        }
    }
}
