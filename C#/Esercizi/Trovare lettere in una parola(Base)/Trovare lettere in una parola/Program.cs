using System;

namespace Trovare_lettere_in_una_parola
{
    class Program
    {
        static void Main(string[] args)
        {
            int conta_aA = 0;
            string lettura = Console.ReadLine();

            foreach (char c in lettura)
                if ("aA".Contains(c)) conta_aA++;

            Console.WriteLine($"trovate {conta_aA} a/A");
            
        }
    }
}
