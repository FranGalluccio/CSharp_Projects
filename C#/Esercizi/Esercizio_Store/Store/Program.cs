using System;

namespace Esercizio_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Benvenuto nel nostro store!");
            Console.WriteLine();
            Magazzino store = new Magazzino(); //Nuova istanza di Magazzino -> store
          // Scontrino resoconto = new Scontrino(); //Nuova istanza di Scontrino -> resoconto            
            store.stampaArray();
            bool flag;
            Carrello carrello = new Carrello();
           
            do
            {
                Console.Write("Cosa desidera acquistare? ");
                string risposta = Console.ReadLine(); //Contiene la risposta dell'utente inerente al prodotto che si vuole acquistare
                CreazioneProdotti prodotto = store.cercaProdotto(risposta);

                if (prodotto != null)
                {
                    Console.Write("Quanto ne vuoi comprare? ");
                    int rispostaQuantita = int.Parse(Console.ReadLine()); //Contiente la risposta inerente alla quantità
                    
                    // resoconto.inserimentoLista(prodotto, QuantitaPrelevata);
                    if (rispostaQuantita > 0)
                    {
                        int QuantitaPrelevata = prodotto.remove(rispostaQuantita);
                        carrello.add(prodotto, QuantitaPrelevata);

                    }
                    else
                    {
                        int quantitarimossa = carrello.remove(prodotto, Math.Abs(rispostaQuantita)); // Ritorno
                        prodotto.add(quantitarimossa);
                    }
                   
                }
                else
                {
                    Console.WriteLine("Il prodotto non è presente nel magazzino");
                }

                Console.Write("Desidera altro? 1. Si / 2. No -> ");
                string risposta3 = Console.ReadLine();
                flag = (risposta3.ToLower() == "si") ? true : false;
               
               
            }
            while (flag);

            Console.WriteLine();
            Console.WriteLine("Il conto è: ");
            carrello.stampaScontrino();

            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
