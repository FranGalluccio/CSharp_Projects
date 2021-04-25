using System;

namespace Esercizi_frazioni
{
    class Program
    {
        static void Main(string[] args)
        {            
            Frazione f1 = new Frazione(3, 2); // 3/2
            Frazione f2 = new Frazione("4/5"); //4/5
            Frazione f3 = f1 + f2;
            Frazione f4 = 6; // f4 = new Frazione(6)
            
            Console.WriteLine(3 + f1);
            Console.WriteLine(f1 + 3);

            Frazione f5 = (Frazione)"4/5";
            Console.WriteLine(f5 + f1);

            f1 += f2;
            Console.WriteLine(f1);

            Console.WriteLine(f1 == f2);
            Console.WriteLine(f1 != f2);
            Console.WriteLine((Frazione)"3/7" == (Frazione)"6/14");




        }
    }
}
