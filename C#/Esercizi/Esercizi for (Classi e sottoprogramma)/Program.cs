using System;

namespace Esercizi_for__3_
{
    class Program
    {
        /*static void IncrementoDispari(int min, int max, bool pari)
        {
            for (int i = min; i <= max; i++)
            {
                if (pari && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (pari == false && i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }*/
        static void Incremento_Dispari(int min, int max, bool pari)
        {
            for (int i = min; i <= max; i++)
            {
                if (pari ? (i % 2 == 0) : (i % 2 != 0)) Console.WriteLine(i);
              
            }
        }



        static void Main(string[] args)
        {
            //Visualizzare sullo schermo i numeri da -18 a + 36
            //for (int i = -18;i <= 36; i++)
            //{
            //    Console.WriteLine(i);
            //}           
            Incremento_Dispari(1, 1000, true);
            Incremento_Dispari(3001, 4000, false);

        }
    }
}
