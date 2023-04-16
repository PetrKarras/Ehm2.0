namespace XX_11_StopWatch
{// pøejmenujete projekt ve formátu jmeno_11_StopWatch
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int milisekundy = 0;
        int sekundy = 50;
        int minuty = 0;
        private void BtnStart_Click(object sender, EventArgs e)
        {
            TimerWatch.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TimerWatch.Stop();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            milisekundy = 0;
            sekundy = 0;
            minuty = 0;
            LblFormat();
        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            if(milisekundy +1 == 10)
            {
                milisekundy = 0;
                if(sekundy +1 == 60)
                {
                    sekundy = 0;
                    minuty++;
                }
                else
                {
                    sekundy++;
                }
            }
            else
            {
                milisekundy++;
            }
            LblFormat();
        }
        private void LblFormat()
        {
            if(sekundy < 10 && minuty < 10)
            {
                LblWatch.Text = $"0{minuty}:0{sekundy}:{milisekundy}";
            }
            else if(sekundy < 10)
            {
                LblWatch.Text = $"{minuty}:0{sekundy}:{milisekundy}";

            }
            else if(minuty < 10)
            {
                LblWatch.Text = $"0{minuty}:{sekundy}:{milisekundy}";

            }
            else
            {
                LblWatch.Text = $"{minuty}:{sekundy}:{milisekundy}";
            }
        }
    }
}