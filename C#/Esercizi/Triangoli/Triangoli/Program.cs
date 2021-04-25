using System;

namespace Triangoli
{
    class Program
    {
        static void Main(string[] args)
        {
            //determinare il tipo di triangolo in base agli input inseriti 
            double l1 = 4; //l = lati
            double l2 = 5;
            double l3 = 6;
            double c1 = l1; //c = cateti
            double c2 = l2;
            double i = 0; //i = ipotenusa
            double area = c1 * c2 / 2;



            if (l1 + l2 < l3 || l2 + l3 < l1 || l3 + l1 < l2 || l1 < 0 || l2 < 0 || l3 < 0)
            {
                Console.WriteLine("Non è un triangolo"); 
            }            

            else if ((l1 == l2 && l2 != l3) || (l3 == l1 && l2 != l1))
            {
                Console.WriteLine("è un triangolo isoscele"); // TRIANGOLO ISOSCELE
                if (l1 != l2 && l1 != l3)
                {
                    Console.WriteLine($"la base è {l1}");
                }
                else if (l2 != l3 && l2 != l1)
                {
                    Console.WriteLine($"la base è {l2}");
                }
                else if (l3 != l1 && l3 != l2)
                {
                    Console.WriteLine($"la base è {l3}");
                }

            }

            else if ((l1 * l1) + (l2 * l2) == l3 * l3 || (l3 * l3) + (l2 * l2) == l1 * l1)
            {
                if (c2 > c1)
                {
                    Console.WriteLine($"{c2} è il cateto maggiore, l'ipotenusa è {i = c1 * c1}");
                }
                if (c1 > c2)
                {
                    Console.WriteLine($"{c1} è il cateto maggiore, l'ipotenusa è {i = c2 * c2}");
                }
                Console.WriteLine($"è un triangolo rettangolo, l'area è {area = c1 * c2 * i / 2}"); // TRIANGOLO RETTANGOLO        
            }

            else if (l1 == l2 && l2 == l3)
            {
                Console.WriteLine("è un triangolo equilatero"); // TRIANGOLO EQUILATERO
                Console.WriteLine($"la base è {l1}");
            }

            else if (l1 != l2 && l2 != l3 && l3 != l1)
            {
                Console.WriteLine("è un triangolo scaleno"); // TRIANGOLO SCALENO
                if (l1 > l2 && l1 > l3)
                {
                    Console.WriteLine($"{l1} è la base");
                }
                else if (l2 > l3 && l2 > l1)
                {
                    Console.WriteLine($"{l2} è la base");
                }
                else if (l3 > l2 && l3 > l1)
                {
                    Console.WriteLine($"{l3} è la base");
                }
                
               
            }

            Console.WriteLine("\n\n");






        }
    }
}
