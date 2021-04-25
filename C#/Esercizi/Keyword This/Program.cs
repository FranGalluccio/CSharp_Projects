using System;

namespace Keyword_This
{
    class Program
    {
        static void Main(string[] args)
        {
            Ordine prove = new Ordine();
            prove.RichiamoOggetto("Prova1", "Prova2");
        }
    }
    class Ordine
    {
        string mittente = "Caro amico ";
        string messaggio1 = "Ti scrivo ";
        string messaggio2 = "Cosi mi distraggo un po";

        public void RichiamoOggetto(string mittente, string messaggio1)
        {
            mittente = "Buona Giornata, ";
            messaggio1 = "A tutti voi! ";
            
            Console.WriteLine(mittente + this.messaggio1 + messaggio2);
        }
    }
}
