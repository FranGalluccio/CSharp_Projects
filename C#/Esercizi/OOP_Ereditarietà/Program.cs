using System;

namespace OOP_Ereditarietà
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ereditarietà - Inheriatance
            /*
             * L'ereditarietà è quando una classe eredita un qualcosa
             * da una seconda classe
             * 
             * Uso comune quando si spiega in C# è di riferirsi
             * a queste classi come:
             * SUPERCLASSI oppure CLASSI BASE & SOTTOCLASSI
             * o CLASSI DERIVATE
             * 
             * Le SuperClassi, sono le classi che cedono
             * le proprie informazioni.
             * Le SottoClassi invece, sono quelle che le ricevono.
             */

            
            Figlio provafiglio = new Figlio();
            provafiglio.MetodoPadre();
            provafiglio.MetodoFiglio();

        }
    }
    class Dna
    {
        protected string coloreOcchi;
        protected string coloreCapelli;
    }
    class Padre : Dna
    {
        protected string cognome = "Rossi"; // la variabile protect
        private string nome;                //può essere utilizzata dalle sottoclassi
                                            // può essere applicata anche ai metodi
        public void MetodoPadre()
        {
            cognome = "Rossi";
            nome = "Mario";
            coloreOcchi = "Gli occhi sono marroni";
            Console.WriteLine(cognome + " " + nome + " " + coloreOcchi + " " + coloreCapelli);

        }
    }
    class Figlio : Padre //dichiarazione di sottoclasse
    {
        private string nome;

        public void MetodoFiglio()
        {
            nome = "Tiziano";
            cognome = cognome;// Può non essere scritta
            coloreOcchi = "Gli occhi del figlio sono castani";
            coloreCapelli = "Il figlio è calvo";
            Console.WriteLine(cognome + " " + nome + " " + coloreOcchi + " " + coloreCapelli);
        }

    }
}
