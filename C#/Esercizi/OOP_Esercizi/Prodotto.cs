using System;
using System.Collections.Generic;
using System.Text;

namespace Prodotti__OOP_
{
    class Prodotto
    {
        public int codice;
        public string descrizione;
        public double prezzo;

        public double ApplicaSconto(int unaPercentuale)
        {
            return prezzo -= prezzo * unaPercentuale / 100;
        }


    }
}
