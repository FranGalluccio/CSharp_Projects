using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            // CONTA OCCORRENZE VERSO GLI ARRAY
            // soluzione 1 (senza array)
            /* int a = 0;
             int b = 0;
             int c = 0;
             int d = 0;             
             foreach (char lettera in lettura)
                 switch (lettera)
                 {
                     case 'a': a++; break;
                     case 'b': b++; break;
                     case 'c': c++; break;
                     case 'd': d++; break;
                         //ecc... */
            //     }


            //Con le stringhe (variante 2)
            /*string alfabeto = "abcdefghilmnopqrstuvz"; // ecc...
            foreach (char lettera in alfabeto)
            {
                {
                    int occorrenze = 0;
                    foreach (char c in lettura)
                    {
                        if (c == lettera)
                        {
                            occorrenze++;
                        }
                    }

                    if (occorrenze > 0)
                    {
                        Console.WriteLine($"Simbolo {lettera} trovato {occorrenze} volt{(occorrenze > 1? 'e' : 'a')}");
                    }
                }

            }*/


            //Console.WriteLine("Inserisci una frase:");
            /*string lettura = Console.ReadLine();

            string alfabeto = "abcdefghilmnopqrstuvz";
            int[] contatori = new int[alfabeto.Length]; // tutta la lunghezza della string alfabeto

            contatori[0] = 222;
            contatori[10] = 1000;
            Console.WriteLine($"L'array contatori può memorizzare {contatori.Length} numeri interi");
            */
            int max_numeri = 50;
            int[] numeri_casuali = new int[max_numeri];

            Random r = new Random();
            for (int i = 0; i< max_numeri; i++)
            {
                numeri_casuali[i] = r.Next(1,101);
            }
            foreach (int n in numeri_casuali)
            {
                Console.Write($"{n} ");
            }

            int pos_min = 0;
            for (int i = 1; i < numeri_casuali.Length; i++)
            {
                if (numeri_casuali[i] < numeri_casuali[pos_min])
                {
                    pos_min = i;
                }
            }

            Console.WriteLine($"\nPrimo dei valori minimi ({numeri_casuali[pos_min]}) trovato nella posizione {pos_min}");


            //sommatoria 
            /*long somma = 0;
            foreach(int n in numeri_casuali)
            {
                somma += n;
            }
            Console.Write($"\n\nSommatoria {somma} ");

            double media = (double)somma / max_numeri;
            Console.Write($"\n\nLa media è {media} ");*/











        }
    }
}
