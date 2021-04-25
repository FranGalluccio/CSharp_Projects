using System;

namespace Esercizio_week_end
{
    class Program
    {
        static void Main(string[] args)
        {
            //Il passaggio di un astronauta da una nave di servizio ad un satellite artificiale è permesso se: la nave ed il satellite sono uniti e alla
            // stessa pressione interna, oppure se sono separati e l’astronauta indossa una tuta pressurizzata.In entrambi i casi occorre inoltre che
            // le pile solari del satellite funzionino e giunga il consenso del controllo a terra.



            bool nave = true;
            bool satellite = true;
            bool Pressione_Interna = nave && satellite;
            bool tuta_pressurizzata = true;
            bool Pile_Solari = true;
            bool Consenso = true;


            if ((nave && satellite && Pressione_Interna && Pile_Solari && Consenso == true) || (nave && satellite && tuta_pressurizzata && Consenso && Pile_Solari == true))
                {
                Console.WriteLine("Può avvenire il passaggio");
                }
            else
                {
                Console.WriteLine("Mancano i prerequisiti per il passaggio");
                }
             
            Console.WriteLine("N \t P \t S \t T \t P \t C \t");
            Console.WriteLine(nave + "\t" + Pressione_Interna + "\t" + satellite + "\t" + tuta_pressurizzata + "\t" + Pile_Solari + "\t" + Consenso + "\t");
        }
    }
}
