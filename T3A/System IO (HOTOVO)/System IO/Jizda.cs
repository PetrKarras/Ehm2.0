using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_IO
{
    internal class Jizda
    {
        private string ridic;
        private string datum;
        private string zbozi;
        private string auto;
        private string spz;
        public string Ridic { get { return ridic; } }
        public string Datum { get { return datum; } }
        public string Zbozi { get { return zbozi; } }
        public string Auto { get { return auto; } }
        public string Spz { get { return spz; } }
        public Jizda(string _ridic,string _datum, string _zbozi,string _auto,string _spz)
        {
            ridic = _ridic;
            datum = _datum; 
            zbozi = _zbozi; 
            auto = _auto;
            spz = _spz;
        }
    }
}
