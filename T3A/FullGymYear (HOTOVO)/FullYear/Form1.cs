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
                            label1.Text += $"Únor:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 3:
                        if (dateTime.Day == 31)
                        {
                            label1.Text += $"Bøezen:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
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
                            label1.Text += $"Kvìten:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 6:
                        if (dateTime.Day == 30)
                        {
                            label1.Text += $"Èerven:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 7:
                        if (dateTime.Day == 31)
                        {
                            label1.Text += $"Èervenec:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
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
                            label1.Text += $"Záøí:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
                            pocitadlo = 0;
                        }
                        break;
                    case 10:
                        if (dateTime.Day == 31)
                        {
                            label1.Text += $"Øíjen:{pocitadlo},Cena:{pocitadlo * 80}" + Environment.NewLine;
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
            label2.Text += $"11 vstupù {pocitadloFull / 11}={pocitadloFull / 11 * 760} permanentek,{pocitadloFull % 11 * 80} =={pocitadloFull / 11 * 760 + pocitadloFull % 11 * 80}" + Environment.NewLine;
            label2.Text += $"22 vstupù {pocitadloFull / 22}={pocitadloFull / 22 * 1550} permanentek,{pocitadloFull % 22}" + Environment.NewLine;

            label2.Text += $"1 mìsíc {11 * 930}" + Environment.NewLine;
            label2.Text += $"3 mìsíc {12/3 * 2590}" +Environment.NewLine;
            label2.Text += $"6 mìsíc {12/6 * 4840}" + Environment.NewLine;
            label2.Text += $"12 mìsíc {12/12 * 9200}" + Environment.NewLine;


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