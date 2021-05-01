using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Supermarket
{
    public class CreazioneProdotti
    {
        //La variabile di classe è una variabile statica
        //Questi sono attributi PRIVATE di istanza
        string _nomeProdotto;
        double _prezzo;
        int _QuantitaMax;
        int _QuantitaIniziale;
        int _QuantitaRifornita;

        //Proprietà 
        /*Con la creazione della proprietà di un attributo privato, si può richiamare questo attributo anche fuori dalla classe in cui è stato creato
        quindi rende l'attributo visibile anche fuori dalla classe stessa. Con il SET invece la si può "vincolare". */

        public string nomeProdotto
        {
            get
            {
                return _nomeProdotto;
            }
        }

        public double prezzo
        {
            get
            {
                return _prezzo;
            }
        }

        public int QuantitaMax
        {
            get
            {
                return _QuantitaMax;
            }
        }

        public int QuantitaIniziale
        {
            get
            {
                return _QuantitaIniziale;
            }
            /*
            set
            {
                _QuantitaIniziale = value > 0 ? value : 0; //Vincolato con valore positivo e non minore di zero
            }
            */
        }

        public int QuantitaRifornita
        {
            get
            {
                return _QuantitaRifornita;
            }
        }

        //Creazione del Costruttore
        public CreazioneProdotti(string nomeProdotto, double prezzo, int QuantitaMax, int QuantitaRifornita)
        {
            _nomeProdotto = nomeProdotto;
            _prezzo = prezzo;
            _QuantitaMax = QuantitaMax;
            _QuantitaIniziale = QuantitaMax; //Con il "this.QuantitaIniziale" richiamo l'attributo creato nella proprietà
            _QuantitaRifornita = QuantitaRifornita;
        }

        public void add(int quantita)
        {
            if (quantita > 0)
            {
                _QuantitaIniziale += quantita;

                if (_QuantitaIniziale > QuantitaMax)
                {
                    _QuantitaIniziale = QuantitaMax;
                }
            }
        }

        public int remove(int quantita)
        {
            int RimuoviQuantita = 0;

            if (quantita > 0)
            {
                RimuoviQuantita = (quantita > _QuantitaIniziale) ? _QuantitaIniziale : quantita;
                _QuantitaIniziale -= RimuoviQuantita;
            }
            return RimuoviQuantita;
        }

        public void Update()
        {
            add(QuantitaRifornita);
        }
    }

    //class Carrello
    //{
    //   private List<string> spesa = new List<string>();

    //    public void aggiungiProdotto(CreazioneProdotti element, int qnt)
    //    {
    //        spesa.Add(element.nomeProdotto + " " + qnt + " Prezzo: E." + (qnt*element.prezzo));
    //    }

    //    public void stampaCarrello()
    //    {
    //        foreach (string element in spesa)
    //            Console.WriteLine(element);
    //    }
    //}
}