using System;

namespace Esercizi_cicli
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrivere un programma che stampi a video tutti i numeri pari compresi tra due estremi a e b letti da tastiera.
            //Il programma deve dire anche quanti sono.
            Console.Write("a =  ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b =  ");            
            int b = int.Parse(Console.ReadLine());
            int i = a;
            if (a % 2 != 0)
            {
                i++;
                while (i <= b)
                {
                    Console.WriteLine(i);
                    i += 2;
                }
                Console.WriteLine("Tutti i numeri pari compresi fra a e b");
            }
            else
            {
                Console.WriteLine("Non ci sono numeri pari che vanno dal valore a al valore b");
            }







        }

    }
}

