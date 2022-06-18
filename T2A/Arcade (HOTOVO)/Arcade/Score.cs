using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade
{
     class Skore
    {
        public string jmeno;
        public int score;
        public string tecka = "...................";

        public Skore(string jmena,int skore)
        {
            jmeno = jmena;
            score = skore;
            
        }
        public override string ToString()
        {
            return $"{jmeno}{tecka}{score}";
        }
    }
}
