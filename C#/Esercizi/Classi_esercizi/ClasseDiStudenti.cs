using System;
using System.Collections.Generic;
using System.Text;

namespace Classi_esercizi
{
    class ClasseDiStudenti
    {
        /*
         * GET = viene eseguito al momento della lettura
         * esso prende il valore della variabile
         * 
         * SET = viene eseguito al momento di scrittura,
         * set viene eseguito quando viene assegnato un NUOVO valore alla variabile.
         * 
         * GET & SET NON sono classificabili come variabili,
         * non è quindi possibile passare come riferimento "REF" o "OUT"
         */
        public string nome;
        private string cognome;
        int mediaScolastica;

        public string Nome
        {            
            get => nome;
            set => nome = value;            
        }
        public string Cognome
        {
            get => cognome;
            set => cognome = value;
        }
        public int MediaScolastica
        {
            get => mediaScolastica;
            set => mediaScolastica = value;
        }

        public ClasseDiStudenti() // COSTRUTTORE della classedistudenti
        {
            nome = "Gennaro";
            cognome = "Esposito";
            mediaScolastica = 1980;
        }
    }
}
