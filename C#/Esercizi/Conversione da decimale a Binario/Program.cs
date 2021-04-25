using System;

namespace Conversione_da_decimale_a_Binario
{
    class Program
    {
        static void Main(string[] args)
        {
            // da decimale a Binario con operatore >> e & (senza l'utilizzo di cicli)
            int numero = 25;
            int g = 7;

            Console.Write(numero >> g & 1);
            Console.Write(numero >> --g & 1);
            Console.Write(numero >> --g & 1);
            Console.Write(numero >> --g & 1);
            Console.Write(numero >> --g & 1);
            Console.Write(numero >> --g & 1);
            Console.Write(numero >> --g & 1);
            Console.Write(numero >> --g & 1);
        }
    }
}
