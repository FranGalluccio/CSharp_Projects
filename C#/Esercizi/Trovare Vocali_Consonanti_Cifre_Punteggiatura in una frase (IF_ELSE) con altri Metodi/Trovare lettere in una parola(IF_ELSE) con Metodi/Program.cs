using System;

namespace Trovare_lettere_in_una_parola_IF_ELSE__con_Metodi
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
                    if (char.IsPunctuation(c)) // .IsPunctuation verifica se il carattere rispetto all'Unicode è un simbolo di punteggiatura.
                    punteggiatura++;
                else
                    if (char.IsDigit(c)) // .IsDigit verifica se il carattere rispetto all'Unicode è un simbolo numerico.
                    cifre++;
                else
                    if (char.IsLetter(c)) // .Isletter verifica se il carattere rispetto all'Unicode è una lettera.
                    consonanti++;

            }
            Console.WriteLine($"Vocali: {vocali}, Consonanti: {consonanti}, Cifre: {cifre}, Punteggiatura: {punteggiatura} ");
        }
    }
}
