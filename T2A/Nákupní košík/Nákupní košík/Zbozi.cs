using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nákupní_košík
{
    internal class Zbozi
    {
        private string typ;
        private string nazev;
        private int cena;
        public Zbozi(int c, string t, string n)
        {
            int cena = c;
            string typ = t;
            string nazev = n;
        }
    }
    class Potravina : Zbozi
    {
        string typ { get; set; }
        public Potravina(string sklad)
        {

        }
    }
    class Drogerie : Zbozi
    {
        string typ { get; set; }
        public Drogerie(string pref)
        {

        }
    }
}
