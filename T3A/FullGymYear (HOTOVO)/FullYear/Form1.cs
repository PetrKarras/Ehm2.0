using System;

namespace FullYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int pocitadlo = 0;
        private int pocitadloFull = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Today.AddDays(1);


            while (dateTime.Year < 2024)
            {
                DAYOfWeek(dateTime);

                switch (dateTime.Month)
                {
                    case 1:
                        if (dateTime.Day == 31)
                        {
                            label1.Text += $"Leden:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 2:
                        if (dateTime.Day == 28)
                        {
                            label1.Text += $"�nor:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 3:
                        if (dateTime.Day == 31)
                        {
                            label1.Text += $"B�ezen:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 4:
                        if (dateTime.Day == 30)
                        {
                            label1.Text += $"Duben:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 5:
                        if (dateTime.Day == 31)
                        {
                            label1.Text += $"Kv�ten:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 6:
                        if (dateTime.Day == 30)
                        {
                            label1.Text += $"�erven:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 7:
                        if (dateTime.Day == 31)
                        {
                            label1.Text += $"�ervenec:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 8:
                        if (dateTime.Day == 31)
                        {
                            label1.Text += $"Srpen:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 9:
                        if (dateTime.Day == 30)
                        {
                            label1.Text += $"Z���:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 10:
                        if (dateTime.Day == 31)
                        {
                            label1.Text += $"��jen:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 11:
                        if (dateTime.Day == 30)
                        {
                            label1.Text += $"Listopad:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 12:
                        if (dateTime.Day == 31)
                        {
                            label1.Text += $"Prosinec:{pocitadlo}, Cena:{pocitadlo * 80}" + Environment.NewLine;
                        }
                        break;
                    default:
                        break;
                }

                dateTime = dateTime.AddDays(1);
            }
            label2.Text += $"Dny:{pocitadloFull},Cena:{pocitadloFull * 80}," + Environment.NewLine;
            label2.Text += $"11 vstup� {pocitadloFull / 11}={pocitadloFull / 11 * 760} permanentek,{pocitadloFull % 11 * 80} =={pocitadloFull / 11 * 760 + pocitadloFull % 11 * 80}" + Environment.NewLine;
            label2.Text += $"22 vstup� {pocitadloFull / 22}={pocitadloFull / 22 * 1550} permanentek,{pocitadloFull % 22}" + Environment.NewLine;

            label2.Text += $"1 m�s�c {11 * 930}" + Environment.NewLine;
            label2.Text += $"3 m�s�c {12/3 * 2590}" +Environment.NewLine;
            label2.Text += $"6 m�s�c {12/6 * 4840}" + Environment.NewLine;
            label2.Text += $"12 m�s�c {12/12 * 9200}" + Environment.NewLine;


        }
        private void DAYOfWeek(DateTime dateTime)
        {
            if (dateTime.DayOfWeek == DayOfWeek.Monday || dateTime.DayOfWeek == DayOfWeek.Wednesday || dateTime.DayOfWeek == DayOfWeek.Friday)
            {
                pocitadlo++;
                pocitadloFull++;
            }
        }
    }
}