using System;

namespace Prodotti__OOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            Prodotto patata = new Prodotto();
            patata.codice = 44334;
            patata.descrizione = "Patata novella";
            patata.prezzo = 1;
            Prodotto uva = new Prodotto();
            uva.codice = 12332;
            patata.descrizione = "Uva fragola";
            patata.prezzo = 0.1;

            Console.WriteLine(patata.prezzo);
            patata.ApplicaSconto(5);
            Console.WriteLine($"Il prezzo scontato è {patata.prezzo}");


                
        }
    }
}
