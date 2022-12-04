using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investiční_účet
{
    internal class Kasicka
    {
        private List<Obalka> listObalek;
        private double penize;
        public List<Obalka> ListObalek { get { return listObalek; } }
        public double Penize { get { return penize; } set { penize += value; } }
        public Kasicka()
        {
            listObalek = new();
            penize = 0;
        }
    }
}
