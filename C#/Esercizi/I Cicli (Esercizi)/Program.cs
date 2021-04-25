using System;

namespace I_cicli__Esercizi_semplici_
{
    class Program
    {
        static void Main(string[] args)
        {
            //stampa dei numeri interi da 1 a 500
            Console.WriteLine("stampa dei numeri interi da 1 a 500: \n");
            int n = 0;
            while (n <= 100)
            {
                Console.Write(n + " ");
                n++;                
            }

            Console.WriteLine("\n");


            //stampa dei primi 100 numeri interi dispari
            Console.WriteLine("stampa dei primi 100 numeri interi dispari: \n");
            int n1 = 1;
            while (n1 <= 100)
            {
                Console.Write($"{n1} ");
                n1 += 2;
            }


            Console.WriteLine("\n");


            //stampa dei primi 50 multipli del 7
            Console.WriteLine("stampa dei primi 50 multipli del 7: \n");
            int n2 = 7;
            while (n2 <= 7 * 50)
            {
                Console.Write($"{n2} ");
                n2 += 7;
            }

            Console.WriteLine("\n");


            // somma dei primi 100 numeri interi (Formula gauss: N+N+1 / 2)
            Console.WriteLine("somma dei primi 100 numeri interi: \n");
            int n3 = 2;
            int somma = 2;
            while (n3 <= 100)
            {
                somma += n3++;
                Console.Write($"{somma} ");
            }

            Console.WriteLine("\n");


            //stampare numeri casuali (valori da 1-1000), fino a che non viene estratto un numero maggiore di 900
            Console.WriteLine("stampare numeri casuali (valori da 1-1000), fino a che non viene estratto un numero maggiore di 900: \n");
            Random r = new Random();
            int estratto = 0;
            while (estratto <= 900)
            {
                estratto = r.Next(1, 1000); // il metodo .Next genera un numero casuale intero
                Console.Write($"{estratto} ");
            }

            Console.WriteLine("\n");

            
        }
    }
}
