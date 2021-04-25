using System;

namespace Trovare_lettere_in_una_parola__IF_ELSE_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una frase");
            string lettura = Console.ReadLine();  //.ReadLine , legge l'input della tastiera

            int vocali = 0, consonanti = 0, cifre = 0, punteggiatura = 0;

            foreach (char c in lettura)
            {
                if ("aeiou".Contains(char.ToLower(c)))
                    vocali++;
                else
                    if (",.;:!? /{}[]()\"\' ".Contains(char.ToLower(c))) // Metodo .Contains , Cerca tutto quello che è contenente nel target di riferimento.
                    punteggiatura++;
                else
                    if ("0123456789".Contains(char.ToLower(c))) // .ToLower, passa in rassegna anche le maiuscole.
                    cifre++;
                else
                    if ("qwrtypsdfghjklmnbvcxz".Contains(char.ToLower(c))) // .ToLower, passa in rassegna anche le maiuscole.
                    consonanti++;

            }
            Console.WriteLine($"Vocali: {vocali}, Consonanti: {consonanti}, Cifre: {cifre}, Punteggiatura: {punteggiatura} ");


        }
    }
}
