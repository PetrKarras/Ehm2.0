using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vývojový_diagram
{
    class Program
    {
        static void Main(string[] args)
        {
           int a, b, c;

            Console.WriteLine("Ahoj kámo dej mi sem strany trojůhelníka a Já ti řeknu je-li možné ho sestrojit");
            Console.WriteLine("****************************************************************************************************************************************************");

            Console.Write(" Dej mi první stranu bráško");
            a = int.Parse(Console.ReadLine());

            Console.Write(" Dej mi další stranu kámo");
            b = int.Parse(Console.ReadLine());

            Console.Write("Dej mi dej poslední stranu bro");
            c = int.Parse(Console.ReadLine());

            //*********************************************

            if (a + b > c)
            {
                if (a + c > b)
                {
                    if (b + c > a)
                    {
                        int o = a + b + c;
                        Console.WriteLine("Tý kokos ten tvůj útvar půjde sestrojit. Tak hybaj k pravítku a rýsuj,obvod je {0}", o);
                    }
                    else
                    {
                        Console.WriteLine("Kámo tak takhle to nepůjde. Aspoň to nemusíš rýsovat");
                    }
                }
                else
                {
                    Console.WriteLine("Bráško tak tohle je blbě. Aspoň to nemusíš rýsovat");
                }
            }
            else
            {
                Console.WriteLine("Bro tady máš něco špatně. Aspoň to nemusíš rýsovat");
            }
        }
    }
}

