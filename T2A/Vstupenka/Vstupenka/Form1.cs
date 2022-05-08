namespace Vstupenka
{
    public partial class Form1 : Form
    {
        //TODO
        //ULožení do .jpg
        //resize
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtPrint_Click(object sender, EventArgs e)
        {
            PanFront.Refresh();
        }
        public int[] x = new int[6];
        public int[] y = new int[6];
        public Image picture = Image.FromFile("rozmery.png");
        private void PanFront_Paint(object sender, PaintEventArgs e)
        {
            string pohadka = TxtBoxName.Text;
            //urèeí vlastností textu
            FontStyle fontStyleB = FontDialogB.Font.Style;
            FontStyle fontStyleM = FontDialogM.Font.Style;
            FontStyle fontStyleL = FontDialogL.Font.Style;

            Graphics g = e.Graphics;
            Font bigF = new(FontDialogB.Font, fontStyleB);
            Font mediumF = new(FontDialogM.Font, fontStyleM);
            Font littleF = new(FontDialogL.Font, fontStyleL);
            Brush brush = new SolidBrush(ColorDialog.Color);
            g.DrawImage(picture, 0, 0);

            //Posun
            if (CheBoxVstup.Checked)
            {
                x[0] = Convert.ToInt32(NumUpDownX.Value);
                y[0] = Convert.ToInt32(NumUpDownY.Value);
            }
            Point pointA = new(280 + x[0], 0 + y[0]);

            if (CheBoxDiv.Checked)
            {
                x[1] = Convert.ToInt32(NumUpDownX.Value);
                y[1] = Convert.ToInt32(NumUpDownY.Value);
            }
            Point pointB = new(280 + x[1], 25 + y[1]);

            if (CheBoxZvon.Checked)
            {
                x[2] = Convert.ToInt32(NumUpDownX.Value);
                y[2] = Convert.ToInt32(NumUpDownY.Value);
            }
            Point pointC = new(310 + x[2], 45 + y[2]);

            if (CheBoxPoh.Checked)
            {
                x[3] = Convert.ToInt32(NumUpDownX.Value);
                y[3] = Convert.ToInt32(NumUpDownY.Value);
            }
            Point pointD = new(250 + x[3], 70 + y[3]);

            if (CheBoxDat.Checked)
            {
                x[4] = Convert.ToInt32(NumUpDownX.Value);
                y[4] = Convert.ToInt32(NumUpDownY.Value);
            }
            Point pointE = new(260 + x[4], 90 + y[4]);

            if (CheBoxCena.Checked)
            {
                x[5] = 280 + Convert.ToInt32(NumUpDownX.Value);
                y[5] = 0 + Convert.ToInt32(NumUpDownY.Value);
            }
            Point pointF = new(280 + x[5], 130 + y[5]);

            if (pohadka.Contains('*'))
            {
                pohadka = pohadka.Replace("*", Environment.NewLine);
            }
            //Vypsání
            g.DrawString("Vstupenka", bigF, brush, pointA);
            g.DrawString("Loutkové divadlo", littleF, brush, pointB);
            g.DrawString("ZVONEK", littleF, brush, pointC);
            g.DrawString(pohadka, mediumF, brush, pointD);
            g.DrawString(DaTiPick.Text, littleF, brush, pointE);
            g.DrawString($"{NumUpDownPrice.Value}", bigF, brush, pointF);
        }
        private void ButtPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog vyhledavac = new();
            Image pictureTmp;
            if (vyhledavac.ShowDialog() == DialogResult.OK)
            {
                string path = vyhledavac.FileName;
                pictureTmp = Image.FromFile(path);

            }
            PanFront.Refresh();
        }
        private void ButtColor_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
        }
        private void ButtFontB_Click(object sender, EventArgs e)
        {
            FontDialogB.ShowDialog();
        }


        private void ButtFontM_Click(object sender, EventArgs e)
        {
            FontDialogM.ShowDialog();
        }

        private void ButtFontL_Click(object sender, EventArgs e)
        {
            FontDialogL.ShowDialog();
        }
    }
}