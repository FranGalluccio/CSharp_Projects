using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizio_Supermarket
{
    class Carrello
    {
        List<ElementoCarrello> lista = new List<ElementoCarrello>();

        public void add(CreazioneProdotti product, int qnt)
        {
            if (qnt > 0)
            {
                ElementoCarrello elemento = trova(product);
                if (elemento == null)
                {
                    elemento = new ElementoCarrello(product);
                    lista.Add(elemento);
                }
                elemento.add(qnt);
            }
        }

        private ElementoCarrello trova(CreazioneProdotti prodotto)
        {
            foreach (ElementoCarrello element in lista)
            {
                if (element.Prodotto.nomeProdotto.Equals(prodotto.nomeProdotto))
                {
                    return element;
                }
            }
            return null;
        }

        public int remove(CreazioneProdotti prodotto, int quantita)
        {
            if (quantita > 0)
            {
                ElementoCarrello elemento = trova(prodotto);
                if (elemento != null)
                {
                    int quantitarimossa = elemento.remove(quantita);
                    
                    if (elemento.Quantita == 0)
                    {
                        lista.Remove(elemento);
                    }
                    return quantitarimossa;
                }
            }
            return 0;

        }

        public void svuota()
        {
            lista.Clear();
        }

        public void stampaScontrino()
        {
            foreach (ElementoCarrello element in lista)
            {
                Console.WriteLine(element.stampa());
            }
            Console.WriteLine(stampaTotale());
            
        }

        private int quantitaTotale()
        {
            int quantitaTotale = 0;
            foreach (ElementoCarrello element in lista)
                quantitaTotale += element.Quantita;

            return quantitaTotale;
        }

        private double prezzoComplessivo()
        {
            double prezzoComplessivo = 0;
            foreach (ElementoCarrello element in lista)
                prezzoComplessivo += element.Quantita * element.Prodotto.prezzo;
            return prezzoComplessivo;

        }

        public string stampaTotale()
        {
            return $"Totale: \t {quantitaTotale()} \t {prezzoComplessivo()}";
        }


    }


    class ElementoCarrello
    {
        private CreazioneProdotti _prodotto;
        private int quantita = 0;

        public CreazioneProdotti Prodotto
        {
            get { return _prodotto; }
            set { _prodotto = value; }
        }

        public int Quantita
        {
            get { return quantita; }
        }



        public ElementoCarrello(CreazioneProdotti prodotto)
        {
            this.Prodotto = prodotto;
         
        }

        public void add(int quantita)
        {
            this.quantita += quantita;
        }

        public int remove(int quantita)
        {
            int quantitaresidua = (this.quantita > quantita) ? quantita : this.quantita;
            this.quantita -= quantitaresidua;
            return quantitaresidua;   
        }

        public string stampa()
        {
            return $"{Prodotto.nomeProdotto} \t {quantita} \t {Prodotto.prezzo * quantita}";
        }


    }
}
