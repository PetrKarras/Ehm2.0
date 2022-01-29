using System;

namespace BMI
{
    class Program
    {
        public static void Main(string[] archs)
        {
            Console.WriteLine("Kalkulačna na BMI");
            Console.WriteLine("Vyber si svoje pohlavý");
            Console.WriteLine("M-muž");
            Console.WriteLine("Z-žena");
            Console.WriteLine("Napiš písmeno svého pohlaví");
            string option = Console.ReadLine();
            switch (option.ToUpper())
            {
                case "M":
                    Muz();
                    break;
                case "Z":
                    Zena();
                    break;
                default:
                    Console.WriteLine("Neznámé zadání");
                    break;
            }
        }
        public static void Muz()
        {
            Console.WriteLine("Kalkulačna na  mužské BMI");
            Console.WriteLine("Váha v kg ");
            double vaha = double.Parse(Console.ReadLine());
            Console.WriteLine("Výška v m");
            double vyska = double.Parse(Console.ReadLine());
            double BMI = vaha / Math.Pow(vyska, vyska); ;
            if ((vaha > 40) && (vaha < 200))
                if ((vyska > 1) && (vyska < 2.15))
                {
                    Console.WriteLine("BMI={0}", BMI);
                    if (BMI <= 20) { Console.WriteLine("Podváha"); }
                    else
                    if (BMI < 24.9) { Console.WriteLine("Normální váha"); }
                    else
                    if (BMI < 29.9) { Console.WriteLine("Mírná obezita"); }
                    else
                    if (BMI < 39.9) { Console.WriteLine("Středí obezita"); }
                    else
                    if (BMI > 40) { Console.WriteLine("Těžký stupeň"); }
                }
        }
        private static void Zena()
        {
            Console.WriteLine("Kalkulačna na ženské BMI");
            Console.WriteLine("Váha v kg ");
            double vaha = double.Parse(Console.ReadLine());
            Console.WriteLine("Výška v m");
            double vyska = double.Parse(Console.ReadLine());
            double BMI = vaha / Math.Pow(vyska, vyska);
            if ((vaha > 40) && (vaha < 200))
                if ((vyska > 1) && (vyska < 2.15))
                {
                    Console.WriteLine("BMI={0}", BMI);
                    if (BMI <= 19) { Console.WriteLine("Podváha"); }
                    else
                    if (BMI < 23.9) { Console.WriteLine("Normální váha"); }
                    else
                    if (BMI < 28.9) { Console.WriteLine("Mírná obezita"); }
                    else
                    if (BMI < 38.9) { Console.WriteLine("Středí obezita"); }
                    else
                    if (BMI > 39) { Console.WriteLine("Těžký stupeň"); }
                }
        }
    }


}
