using System;

namespace Stringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usando .IndexOf , il metodo dovrà dirmi quante volte una stringa è presente in un altra stringa.
            //1) modo iterativo.
            //2) modo ricorsivo.
            //Verificare se una stringa è palindroma.
            // ciao.IndexOf('C') 
            //string frase = Console.ReadLine();
            //string nome = "kayak";
            //Console.WriteLine(IsPalindrom(nome));
            //Console.WriteLine(IncludeStringa("pappa", "p"));
            //Console.WriteLine($"\n\n La parola {frase}" + (IsPalindromo(frase, true, true, true) ? "" : " non") + " è palindroma");
            string poesia = "Narciso Il tuo odore E il fondo del fiume. Voglio restare sulla tua riva Fiore dell’amore. Narciso. Onde e pesci addormentati passano nei tuoi bianchi occhi nei miei, uccelli e farfalle si stilizzano Tu minuscolo e io grande. Fiore dell’amore. Narciso. Le rane quanto sono scaltre Ma non lasciano tranquillo lo specchio in cui si guardano il tuo delirio e il mio delirio.Narciso. Il mio dolore… E mio dolore medesimo";
            Console.WriteLine(IncludeStringa2(poesia, "c"));
            //Console.WriteLine(poesia.Replace(" ", "").Replace(".", ""));




        }
        public static string IncludeStringa2(string frase, string lettera)
        {
            int contatore = 0;
            foreach (char c in frase)
            {
                if (frase.Contains(lettera))
                {
                    for (int i = 0; i < frase.Length; i++)
                    {
                        contatore++;
                    }
                }
            }
            Console.WriteLine(lettera);
            return lettera;
        }
        public static int IncludeStringa(string frase, string lettera)
        {
            int c = 0;
            for (int i = 0; i <= frase.Length; i++)
                if (frase.IndexOf(lettera) >= 0)
                {
                    frase = frase.Substring(frase.IndexOf(lettera) + 1);
                    c++;
                }
            return c;
        }
        public static bool IsPalindrom(string stringa)
        {
            string prima = stringa.Substring(0, stringa.Length / 2);
            char[] arr = stringa.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string seconda = temp.Substring(0, temp.Length / 2);
            return prima.Equals(seconda);
        }
        public static bool IsPalindromo(in string frase, bool ignoreSpaces, bool ignoreCase, bool trim)
        {
            if (frase != null)
            {
                
                string text = trim ? frase.Trim() : frase;                 
                text = ignoreCase ? text.ToUpper() : text;
                text = ignoreSpaces ? text.Replace(" ", "") : text;
                int rightIndex = text.Length - 1;

                for (int i = 0; i < text.Length / 2; i++)
                {
                    if (text[i] != text[rightIndex--])
                    {
                        return false;
                    }                    
                }
                return true;                
            }
            return false;
        }
        public static bool IsPalindromoRicorsivo(in string frase, int i, int j)
        {
            if (i < frase.Length / 2)
            {
                return frase[i] != frase[j] ? false : IsPalindromoRicorsivo(frase, ++i, --j);
            }
            return false;
        }
        public static bool IsPalindromoRicorsivo2(in string frase)
        {
            return frase.Length > 1 ? (frase[0] == frase[frase.Length-1]) && IsPalindromoRicorsivo2(frase.Substring(1, frase.Length- 2)) : true;
        }

    }
}
  
