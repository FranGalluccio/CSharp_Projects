using System;

namespace Esercizi_cicli__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Visualizzare sullo schermo 100 volte il valore di pi greco
            double Pi = 3.1415926535897931;
            int contatore = 0;


            for (int i = 0; i < 100; i++)
            {               
                contatore++;
                Console.WriteLine($"{Pi}  {contatore}");
            }







    }
    }
}
