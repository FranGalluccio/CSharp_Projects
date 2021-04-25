using System;

namespace Strutture_selettive__1_
{
    class Program
    {
        static void Main(string[] args)
        {

            //espressioni condizionali o Operatore ternario

            string lettura = "";

            do
            {
                Console.WriteLine("Quanti anni hai? -> (exit per terminare)");
                lettura = Console.ReadLine();

                if (int.TryParse(lettura, out int eta) && eta > 0 && eta < 120)
                    Console.WriteLine(eta >= 18 ? "Sei maggiorenne" : "Sei minorenne");
                else
                    Console.WriteLine("Valore inserito non valido");

            } while (lettura != "exit");
            
        }
    }
}
