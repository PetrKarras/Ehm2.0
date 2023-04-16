using System;

namespace CatFishModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtGenerate_Click(object sender, EventArgs e)
        {
            Profil profil = new();
            LblInfo.Text = "";
            LblInfo.Text += profil.Name + Environment.NewLine;
            LblInfo.Text += $"{profil.Age}" + Environment.NewLine;
            LblInfo.Text += $"{profil.Bday.ToShortDateString()}" + Environment.NewLine;
            LblInfo.Text += profil.Sex + Environment.NewLine;
            LblInfo.Text += profil.Sign + Environment.NewLine;
            LblInfo.Text += profil.Hobby.Replace("_"," ")+ Environment.NewLine;
            PicBoxPhoto.Image = profil.Photo;



        }
    }
}