using System;

namespace Convertitore_numero_in_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*_*-_*-_*-_*-_*-_*-_*-_*-_*");
            Console.WriteLine("CONVERSIONE BINARIA 32 bit");
            Console.WriteLine("*_*-_*-_*-_*-_*-_*-_*-_*-_*\n");
            Console.WriteLine("Inserisci un numero da convertire:");
            int a = int.Parse(Console.ReadLine());
            int o = 1;
            for (int i = 31; i >= 0; i--)
            {
                Console.Write((a >> i) & o);
                Console.Write((i % 4 == 0) ? " " : ""); // aggiunge uno spazio ogni 4 numeri
            }
        }
    }
}
