using System;

namespace Array__Mid_
{
    class Program
    {
        static void Stampa_array(int[] da_stampare, int quanti)
        {
            for (int i = 0; i < quanti; i++)
                Console.Write($"{da_stampare} ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int max_numeri = 50;
            int[] numeri_casuali = new int[max_numeri];

            int quanti_inseriti = 20;
            Random r = new Random();
            for (int i = 0; i < quanti_inseriti; i++)
                numeri_casuali[i] = r.Next(1, 101);

            Stampa_array(numeri_casuali, quanti_inseriti);

            //INSERIMENTO DI UN NUOVO VALORE IN FONDO
            int nuovo = 101;
            if (quanti_inseriti >= max_numeri)
                Console.Write("Spazio esaurito!");
            else
                numeri_casuali[quanti_inseriti++] = 101;

            Console.WriteLine($"\nDopo aver inserito {nuovo} in fondo");
            Stampa_array(numeri_casuali, quanti_inseriti);

          /*  //INSERIMENTO IN UN NUOVO VALORE IN UN PUNTO QUALUNQUE 
            //RICHIEDE SHIFT A DESTRA!
            // 7 23 12 8 3 56 7 90
            nuovo = 102;
            int punto_inserimento = 5;

            if (quanti_inseriti >= max_numeri)
                Console.Write("Spazio esaurito!");
            else if (punto_inserimento < 0 || punto_inserimento > quanti_inseriti)
                Console.WriteLine("Punto di inserimento non valido");
            else
            {
                //SPOSTIAMO GLI ELEMENTI DALLA POSIZIONE IN CUI INSERIRE
                //TUTTI DI UN POSTO VERSO DESTRA
                for (int i = quanti_inseriti; i > punto_inserimento; i++)
                    numeri_casuali[i] = numeri_casuali[i - 1];
                //INSERISCO IL NUOVO ALLA POSIZIONE LIBERATA
                numeri_casuali[punto_inserimento] = nuovo;
                quanti_inseriti++;
            }
            Console.WriteLine($"\nDopo aver inserito {nuovo} in posizione {punto_inserimento}");
            Stampa_array(numeri_casuali, quanti_inseriti);
          */
        }
    }
}
