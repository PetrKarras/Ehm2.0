using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFishModel
{
    internal class Profil
    {
        private enum Names { Petr, Kryštof , Pavel, Ondra, Michal, Jakub, David, Patrik, Martin, Adam, Petra, Lucie, Sabina, Adéla, Klára, Martina, Lana, Mia, Anna, Denisa }
        private enum Hobbys { být_doma, čtení, LARP, deskovky, streamovaní, videohry, serialy, filmy, fotbal, famfrpál, basket, hokej, krasobruslení, hobbyhorsing, chození_do_klubu, }
        public string Hobby { get; set; }
        public string Sign { get; set; }
        public string Sex { get; set; }
        public string Name { get; set; }
        public Image Photo { get; set; }
        public int Age { get; set; }
        public DateTime Bday { get; set; }
        public Random rnd = new();
        public Profil()
        {
            DateTime start = new(1955, 1, 1);
            DateTime end = new(2005, 1, 1);
            int range = ((TimeSpan)(end - start)).Days;
            Bday = start.AddDays(rnd.Next(range));
            Konicky();
            Age = Convert.ToInt32(DateTime.Today.Year - Bday.Year);
            Znameni();
            Pohlavi();

        }

        private void Konicky()
        {

            int[] hobyPole = { 0, 0, 0 };
            int pocitadlo = 0;
            while (pocitadlo != 3)
            {
                hobyPole[2] = rnd.Next(15);
                switch (pocitadlo)
                {
                    case 0:
                        Hobby += (Hobbys)hobyPole[2] + ",";
                        hobyPole[0] = hobyPole[2];
                        pocitadlo++;
                        break;
                    case 1:
                        if (hobyPole[0] != hobyPole[2])
                        {
                            Hobby += (Hobbys)hobyPole[2] + ",";
                            hobyPole[1] = hobyPole[2];
                            pocitadlo++;
                        }
                        else
                        {
                            pocitadlo = 1;
                        }
                        break;
                    case 2:
                        if (hobyPole[1] != hobyPole[2] && hobyPole[0] != hobyPole[2])
                        {
                            Hobby += (Hobbys)hobyPole[2];
                            pocitadlo++;
                        }
                        else
                        {
                            pocitadlo = 1;
                        }
                        break;
                }

            }

        }

        private void Pohlavi()
        {
            switch (rnd.Next(3))
            {
                case 0:
                    Name = $"{(Names)rnd.Next(10)}";
                    Sex = "Muž";
                    Photo = Image.FromFile($"M{(Age / 10)}.png");
                    break;
                case 1:
                    Name = $"{(Names)rnd.Next(10, 20)}";
                    Sex = "Žena";
                    Photo = Image.FromFile($"W{(Age / 10)}.png");
                    break;
                default:
                    Name = $"{(Names)rnd.Next(20)}";
                    Sex = "Jiné";
                    if (rnd.Next(2) == 0)
                    {
                        Photo = Image.FromFile($"W{(Age / 10)}.png");
                    }
                    else
                    {
                        Photo = Image.FromFile($"M{(Age / 10)}.png");
                    }
                    break;
            }
        }

        private void Znameni()
        {
            //https://eprehledy.cz/znameni-zverokruhu-znaky-nazvy-latinsky-anglicky.php
            switch (Bday.Month)
            {
                case 1:
                    if (Bday.Day <= 20)
                    {
                        Sign = "Kozoroh";
                    }
                    Sign = "Vodnář";
                    break;
                case 2:
                    if (Bday.Day <= 20)
                    {
                        Sign = "Vodnář";
                    }
                    Sign = "Ryba";
                    break;
                case 3:
                    if (Bday.Day <= 20)
                    {
                        Sign = "Ryba";
                    }
                    Sign = "Beran";
                    break;
                case 4:
                    if (Bday.Day <= 20)
                    {
                        Sign = "Beran";
                    }
                    Sign = "Býk";
                    break;
                case 5:
                    if (Bday.Day <= 21)
                    {
                        Sign = "Býk";
                    }
                    Sign = "Blíženec";
                    break;
                case 6:
                    if (Bday.Day <= 21)
                    {
                        Sign = "Blíženec";
                    }
                    Sign = "Rak";
                    break;
                case 7:
                    if (Bday.Day < 22)
                    {
                        Sign = "Rak";
                    }
                    Sign = "Lev";
                    break;
                case 8:
                    if (Bday.Day <= 22)
                    {
                        Sign = "Lev";
                    }
                    Sign = "Pana";
                    break;
                case 9:
                    if (Bday.Day <= 22)
                    {
                        Sign = "Pana";
                    }
                    Sign = "Váha";
                    break;
                case 10:
                    if (Bday.Day <= 23)
                    {
                        Sign = "Váha";
                    }
                    Sign = "Štír";
                    break;
                case 11:
                    if (Bday.Day <= 22)
                    {
                        Sign = "Štír";
                    }
                    Sign = "Střelec";
                    break;
                default:
                    if (Bday.Day <= 21)
                    {
                        Sign = "Střelec";
                    }
                    Sign = "Kozoroh";
                    break;
            }
        }

    }
}
