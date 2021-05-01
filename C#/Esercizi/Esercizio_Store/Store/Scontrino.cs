using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Supermarket
{
    public class Scontrino
    {
        public List<string> spesa = new List<string>();
        double somma = 0;
        double totale = 0;

        public void inserimentoLista(CreazioneProdotti prodotto, int quantita)
        {
            double sp = quantita * prodotto.prezzo;
            spesa.Add(prodotto.nomeProdotto + "\t" + quantita + "\t" + sp);
            somma += sp;
            totale += quantita;
        }

        public void stampaScontrino()
        {
            foreach (string element in spesa)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("totale" + "\t" + totale + "\t" + somma);
        }
    }
}
