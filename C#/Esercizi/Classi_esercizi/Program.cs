using System;

namespace Classi_esercizi
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseDiStudenti RiferimentoOggetto1 = new ClasseDiStudenti();
            //RiferimentoOggetto1.Nome = "Mario";
            RiferimentoOggetto1.Cognome = "Rossi";
            RiferimentoOggetto1.MediaScolastica = 10;

            ClasseDiStudenti RiferimentoOggetto2 = new ClasseDiStudenti();
            RiferimentoOggetto2.Nome = "Tiziano";
           //RiferimentoOggetto2.Cognome = "Coppi";
           //RiferimentoOggetto2.MediaScolastica = 5;

            Console.WriteLine(RiferimentoOggetto1.Nome + " " + RiferimentoOggetto1.Cognome + " " + RiferimentoOggetto1.MediaScolastica);
            Console.WriteLine(RiferimentoOggetto2.Nome + " " + RiferimentoOggetto2.Cognome + " " + RiferimentoOggetto2.MediaScolastica);
        }
        static int Selezionatore(int valore, int soglia, int alternativa)
        {
            return valore > soglia ? valore : alternativa;
        }
    }
}
