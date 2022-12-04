using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investiční_účet
{
    internal class Obalka
    {
        private double penize;
        private int procenta;
        private string popis;
        public double Penize { get { return penize; } set { penize += value; } }
        public int Procenta { get { return procenta; } set { procenta = value; } }
        public string Popis { get { return popis; } }

        public Obalka(int p,string n)
        {
            penize = 0;
            procenta = p;
            popis = n;
        }
        public override string ToString()
        {
            return $"Obálka: {penize},{procenta}%,{popis}";
        }
    }
}
