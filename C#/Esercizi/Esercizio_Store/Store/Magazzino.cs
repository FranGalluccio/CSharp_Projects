using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Supermarket
{
    public class Magazzino
    {
        CreazioneProdotti[] _prodotti = new CreazioneProdotti[10];

        public CreazioneProdotti[] prodotti
        {
            get
            {
                return _prodotti;
            }
        }

        //Metodo per inizializzare il magazzino
        public Magazzino()
        {
            prodotti[0] = new CreazioneProdotti("Uova", 0.30, 120, 24);
            prodotti[1] = new CreazioneProdotti("Panini", 0.40, 50, 20);
            prodotti[2] = new CreazioneProdotti("Latte", 1.00, 60, 12);
            prodotti[3] = new CreazioneProdotti("Olio", 7.00, 60, 12);
            prodotti[4] = new CreazioneProdotti("Biscotti", 1.30, 30, 10);
            prodotti[5] = new CreazioneProdotti("Spaghetti", 0.90, 30, 15);
            prodotti[6] = new CreazioneProdotti("Riso", 1.20, 20, 10);
            prodotti[7] = new CreazioneProdotti("Fagioli", 0.50, 50, 25);
            prodotti[8] = new CreazioneProdotti("Lenticchie", 0.60, 50, 25);
            prodotti[9] = new CreazioneProdotti("Mele", 0.30, 100, 30);
        }

        public void rifornimentoMagazzino()
        {
            foreach (CreazioneProdotti element in prodotti)
            {
                element.Update();
            }
        }

        public bool venditaProdotto(string nomeProdotto, int Quantita)
        {
            CreazioneProdotti prodotto = cercaProdotto(nomeProdotto);
            if (prodotto != null)
            {
                prodotto.remove(Quantita);
                return true;
            }
            /*
                foreach (CreazioneProdotti element in prodotti)
                {
                    if (nomeProdotto.ToLower().Equals(element.nomeProdotto.ToLower()))
                    {
                         if(element.QuantitaIniziale > Quantita)
                         {
                            element.QuantitaIniziale = element.QuantitaIniziale - Quantita;
                            return true;
                         }
                         else
                         {
                            Console.WriteLine("Non è disponibile la quantità richiesta");
                            return false;
                         }
                    }
                     else
                     {
                        Console.WriteLine("Prodotto non disponibile");
                         return false;
                     }
                } */
            return false;
        }

        public void stampaArray()
        {
            foreach (CreazioneProdotti element in prodotti)
            {
                Console.WriteLine("Nome del prodotto: " + element.nomeProdotto + "\n" + "Prezzo del prodotto: " + element.prezzo + "\n" + "Quantità: " + element.QuantitaIniziale + "\n");
            }
        }

        public CreazioneProdotti cercaProdotto(string nomeProdotto)
        {
            foreach (CreazioneProdotti element in prodotti)
            {
                if (element.nomeProdotto.ToLower().Equals(nomeProdotto.ToLower()))
                {
                    return element;
                }
            }
            return null;
        }
    }
}
