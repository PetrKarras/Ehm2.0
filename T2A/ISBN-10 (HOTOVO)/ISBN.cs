using System;
using System.Collections.Generic;
using System.Text;

namespace ISBN_10
{
    class ClassISBN
    {
        //Atributy
        public string ISBNClassKod;
        public string PuvodKnihyString;
        public bool VysledekExistuje;
        public int CheckNumberInt = 0;
        public bool CheckNumberExistuje;
        public string NazevKnihy;
        // Konsutruktor třídy ISBN
        public ClassISBN(string ISBNKod, string NazevKnihy)
        {
            this.ISBNClassKod = ISBNKod.Replace(" ", "-");
            this.NazevKnihy = NazevKnihy;
            char[] separator = new char[2];
            separator[0] = ' ';
            separator[1] = '-';
            string kodISBNCely = ISBNKod.Replace('-', ' ').Replace("ISBN", null).Trim();
            //Puvod knihy
            string[] poleISBN = kodISBNCely.Split(separator, 4);
            PuvodKnihyString = ZjisteniPuvoduKnihy(int.Parse(poleISBN[0]));
            //Validace + dopočet check number
            kodISBNCely = kodISBNCely.Replace(" ", null);
            char[] KodISBNChar = kodISBNCely.ToCharArray();
            if (KodISBNChar.Length == 10) { ValidaceISBN(KodISBNChar); }
            if (KodISBNChar.Length == 9) { DopocetCheckNumber(KodISBNChar); }
            if (CheckNumberExistuje == true)
            {
                string checkKodISBNCely = ISBNClassKod.Replace('-', ' ').Replace("ISBN", null).Trim();
                string[] checkPoleISBN = checkKodISBNCely.Split(separator, 4);
                PuvodKnihyString = ZjisteniPuvoduKnihy(int.Parse(checkPoleISBN[0]));
                checkKodISBNCely = checkKodISBNCely.Replace(" ", null);
                char[] checkKodISBNChar = checkKodISBNCely.ToCharArray();
                if (checkKodISBNChar.Length == 10) { ValidaceISBN(checkKodISBNChar); }
            }
        }
        //Pomocné metody
        public override string ToString()
        {
            if (VysledekExistuje == true)
            {
                return $"{ISBNClassKod};{PuvodKnihyString};{NazevKnihy}";
            }
            return null;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return obj != null && obj is ClassISBN && ((ClassISBN)obj).ISBNClassKod == ISBNClassKod;
        }
        //Metoda pro zjištení původu knihy
        public string ZjisteniPuvoduKnihy(int puvodKnihyInt)
        {
            if (puvodKnihyInt == 0 || puvodKnihyInt == 1) { PuvodKnihyString = "ENG"; }
            if (puvodKnihyInt == 2) { PuvodKnihyString = "FRA"; }
            if (puvodKnihyInt == 3) { PuvodKnihyString = "GER"; }
            if (puvodKnihyInt == 4) { PuvodKnihyString = "JAP"; }
            if (puvodKnihyInt == 5) { PuvodKnihyString = "RUS"; }
            if (puvodKnihyInt == 7) { PuvodKnihyString = "CHI"; }
            if (puvodKnihyInt == 80) { PuvodKnihyString = "CZE"; }
            if (puvodKnihyInt == 83) { PuvodKnihyString = "PLN"; }
            if (puvodKnihyInt == 915) { PuvodKnihyString = "FIN"; }
            if (puvodKnihyInt != 0 && puvodKnihyInt != 1 && puvodKnihyInt != 2 && puvodKnihyInt != 3 && puvodKnihyInt != 4 && puvodKnihyInt != 5 && puvodKnihyInt != 7 && puvodKnihyInt != 80 && puvodKnihyInt != 83 && puvodKnihyInt != 915) { PuvodKnihyString = "OTH"; }
            return PuvodKnihyString;
        }
        //Metoda pro validaci ISBN kodu 
        public bool ValidaceISBN(char[] valPoleISBN)
        {
            int vysledek = 0;
            int[] poleISBNInt = new int[10];

            for (int i = 0; i < valPoleISBN.Length; i++)
            {
                if (valPoleISBN[i] == 'X') { poleISBNInt[i] = 10; }
                if (poleISBNInt[i] == 0) { poleISBNInt[i] = valPoleISBN[i] - 48; }
            }
            for (int i = 0; i < 10; i++)
            {
                int a = 10 - i;
                vysledek += poleISBNInt[i] * a;
            }
            if (vysledek % 11 == 0)
            {
                return VysledekExistuje = true;
            }
            return VysledekExistuje = false;
        }
        //Metoda pro zjištení chybějícího check numberu čísla
        public bool DopocetCheckNumber(char[] dopPoleISBN)
        {
            int[] poleISBNInt = new int[10];
            poleISBNInt[9] = 0;
            int vysledek = 0;

            for (int i = 0; i < dopPoleISBN.Length; i++)
            {
                if (dopPoleISBN[i] == 'X') { poleISBNInt[i] = 10; }
                else { poleISBNInt[i] = dopPoleISBN[i] - 48; }
                int a = 10 - i;
                vysledek += poleISBNInt[i] * a;
            }
            while (CheckNumberInt < 11)
            {
                if ((vysledek + CheckNumberInt) % 11 == 0)
                {
                    if (ISBNClassKod.EndsWith("-") == false)
                    {
                        if (CheckNumberInt == 10) { ISBNClassKod += $"-X"; }
                        else { ISBNClassKod += $"-{CheckNumberInt}"; }
                    }
                    else
                    {
                        if (CheckNumberInt == 10) { ISBNClassKod += $"X"; }
                        else { ISBNClassKod += $"{CheckNumberInt}"; }
                    }
                    return CheckNumberExistuje = true;
                }
                else { CheckNumberInt++; }
            }
            return CheckNumberExistuje = false;
        }
    }
}
