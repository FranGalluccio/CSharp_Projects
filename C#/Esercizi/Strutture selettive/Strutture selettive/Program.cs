using System;

namespace Strutture_selettive
{
    class Program
    {
        static void Main(string[] args)
        {
            //ciclo e struttura selettiva
            string lettura = "";
            bool prima_volta_in_italia = false;

            do
            {
                Console.Write("Quanti anni hai (exit per terminare)? ->");
                lettura = Console.ReadLine();
                
                if (int.TryParse(lettura, out int eta) && eta > 0 && eta <= 120) //il TryParse tenta di convertire una stringa in un numero int.
                {                                                               //"out int" mette la variabile "int" in output , porta il valore fuori dalla funzione e lo assegna ad "eta"
                    Console.WriteLine(eta >= 18 ? "Sei maggiorenne" : "sei minorenne");

                    if (eta >= 12 && eta < 18 || eta >= 65 && eta <= 75)
                        Console.WriteLine("Hai diritto ad uno sconto");

                    if (eta < 12 || eta > 65 && prima_volta_in_italia)
                        Console.WriteLine("ingresso gratuito!");
                }
                else
                    Console.WriteLine("Devi inserire un valore numerico valido! Fra 1 e 120");

            } 
            while (lettura != "exit");

        }
    }
}
