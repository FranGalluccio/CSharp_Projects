using System;

namespace Il_ciclo_For
{
    class Program
    {
        static void Main(string[] args)
        {
           
             //Ciclo for
            //La variabile sarà utilizzabile (raggiungibile) solo dentro il ciclo for           
            Console.WriteLine("Esempio di ciclo for:");
            for (int i = 0; i < 10; i++) //dichiarazione della variabile "i" nell'intestazione
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n" + "\n");

            //stampa dei numeri pari minori di 100
            Console.WriteLine("stampa dei numeri pari minori di 100:");
            for (int i = 0, j = 0; i+j<100; i++, j++)
            {
                Console.Write(i + j + " ");
            }
            Console.WriteLine("\n" + "\n");


            //altri esempi del ciclo for
            Random x = new Random(); //creazione oggetto "x" con valore random
                                    //.Next genera un valore casuale.
            for (Console.WriteLine("Questo si ripete una volta"); x.Next(100) < 90; Console.WriteLine("Questo si ripete ad ogni iterazione"))
                Console.WriteLine("Istruzioni da eseguire...");
            Console.WriteLine("\n" + "\n");


            //stampa di una stringa in verticale con il ciclo for
            string s = "Stampa in verticale";
            for (int i = 0; i < s.Length; i++) //la propietà .Lenght indica il numero di caratteri
                Console.WriteLine(s[i]);      //indentificatore delle variabile "s", e fra parentesi quadre [] si specifica l'indice della variabile
                                              //l'indice è la posizione degli elementi atomici elementari della variabile "s"
            Console.WriteLine("\n" + "\n");

            //stampa in verticale con Foreach
            string st = "stampa in verticale";
            foreach (char c in st) Console.WriteLine(c); //per ogni carattere (c) nella stringa (st), stampa il valore
            Console.WriteLine("\n" + "\n");


           

            Console.WriteLine($"\n\nPremi un tasto per continuare...");
            Console.ReadKey();


        }
    }
}
