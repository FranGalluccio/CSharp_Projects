using System;
using System.Collections.Generic;

namespace Esercizi_Superenalotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEstratto;
            int maxNumeri = 100;
            Random r = new Random();
            List<int> numeriEstratti = new List<int>();


            for (var i = maxNumeri; i > 0; i--)
            {
                if (maxNumeri > 0)
                {
                    System.Threading.Thread.Sleep(500);
                    numeroEstratto = r.Next(1, maxNumeri);

                    if (!numeriEstratti.Contains(numeroEstratto))
                    {
                        numeriEstratti.Add(numeroEstratto);
                        Console.WriteLine(string.Concat(i, " ", "Numero estratto", " ", numeroEstratto));
                        maxNumeri -= 1;
                    }

                    else
                    {
                        Console.WriteLine(string.Concat(i, " ", "Numero già estratto", " ", numeroEstratto));
                    }
                }
            }

            foreach (var x in numeriEstratti)
            {
                Console.WriteLine(string.Concat("Tutti i numeri", " ", x));
            }

            Console.ReadKey();
        }
    }
}
