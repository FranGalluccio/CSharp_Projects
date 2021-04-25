using System;

namespace I_Cicli__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string scelta = Console.ReadLine();


            // uso naturale del DO WHILE
             do
            {
                Console.WriteLine("MENU\n");
                Console.WriteLine("1 - Somme ");
                Console.WriteLine("2 - Prodotti ");
                Console.WriteLine("INVIO per terminare");
                Console.Write("SCEGLI -> ");

                scelta = Console.ReadLine();

                Console.WriteLine($"\nHai scelto {scelta} - premi un tasto per continuare");
                Console.ReadKey();
                Console.Clear();
            }
            while (scelta != "");


            // Uso naturale del WHILE DO
            Random generatore = new Random(); // genera un valore casuale
            int n = generatore.Next(-100, 100); // genera un numero da 0 a 100
            Console.WriteLine($"Estratto il numero: {n}");
            while (n>=0)
            {
                Console.WriteLine($"La radiice quadrata di {n} è {Math.Sqrt(n)}");  //il metodo Math.Sqrt esegue la radice quadrata.
                n -= 1; // decremento n per far si che si esca dal ciclo.
            }

        }
    }
}
