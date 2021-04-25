using System;

namespace Trovare_N
{
    class Program
    {
        static int Logaritmo_approssimato(int b, int x)
        {
            int n = 0;
            int y = 1;
            for (; y < x; y = b, n++) ;
            return n;
        }
        static void Main(string[] args)
        {
                 
            {
                int x;
                do
                {
                    Console.Write("Inserire il valore x: ");
                    x = Int32.Parse(Console.ReadLine());
                }

                while (x < 0);
                int n = Logaritmo_approssimato(3, x);
                int y = 1;
                while (y < x)
                {
                    y = y * 2;
                    n++;
                }
                Console.WriteLine("L'esponente più piccolo che bisogna assegnare a 2 in modo tale che 2n >= x , con x numero intero positivo è: " + n);
                for (n = 0, y = 1; y < x; y *= 2, n++) ; 
                Console.WriteLine("L'esponente più piccolo che bisogna assegnare a 2 in modo tale che 2n >= x , con x numero intero positivo è: " + n);
            }
        }
    }
}