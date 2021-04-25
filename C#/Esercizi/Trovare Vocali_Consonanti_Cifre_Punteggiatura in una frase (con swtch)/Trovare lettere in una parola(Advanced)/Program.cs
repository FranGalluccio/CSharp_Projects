using System;

namespace Trovare_lettere_in_una_parola_Advanced_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una frase");
            string lettura = Console.ReadLine();

            int vocali = 0, consonanti = 0, punteggiatura = 0, cifre = 0;

            foreach (char c in lettura)
                switch(char.ToLower(c))  // Metodo della classe char (ToLower e ToUpper) che ci permette di prendere sia maiuscole che minuscole.
                {
                    case 'a': case 'e': case 'i': case 'o': case 'u':
                        vocali++;
                        break;

                    case '.': case ',': case ';': case ':': case '!':
                        punteggiatura++;
                            break;
                    case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9':
                        cifre++;
                        break;
                    default:
                        consonanti++;
                        break;
                }

            Console.WriteLine($"Vocali: {vocali}, Consonanti: {consonanti}, Punteggiatura: {punteggiatura}, Cifre: {cifre}");
        }
    }
}
