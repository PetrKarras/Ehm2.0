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
        public double Penize { get { return penize; } set { penize = value; } }
        public Kasicka()
        {
            listObalek = new();
            listObalek.Add(new(100, "Vychozí Obalka"));
            penize = 0;
        }
        internal void VlozitObalku(Obalka ob)
        {
            int odectenaProcenta = ob.Procenta/listObalek.Count;
            foreach (Obalka item in listObalek)
            {
                if(item.Procenta - odectenaProcenta <= 0)
                {
                    item.Procenta = 1;
                }
                else
                {
                    item.Procenta -= odectenaProcenta;
                }
            }
            ListObalek.Add(ob);
        }

        internal void VlozitPenize(int tmp)
        {
            Penize = tmp;
            double procento = Penize / 100;
            foreach (Obalka item in listObalek)
            {
                item.Penize = procento * item.Procenta;
            }

        }
    }
}
