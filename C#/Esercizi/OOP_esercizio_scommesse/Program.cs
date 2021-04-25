using System;

namespace OOP_esercizio_ippodromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Giocatore g1 = new Giocatore();
            while (g1.budget > 5)
            {                
                Console.WriteLine("Quale cavallo scegli?");
                int a = int.Parse(Console.ReadLine());
                g1.Scommessa();
                Random r = new Random();
                int vincente = r.Next(1, 10);
                Console.WriteLine($"Il cavallo vincente è: {vincente}");
                if (a == vincente)
                {
                    Console.WriteLine("Complimenti hai vinto!");
                    g1.Vincita();
                    Console.WriteLine($"Il budget rimanente è: {g1.budget}");
                }
                else
                {
                    Console.WriteLine("Hai perso, riprova.");
                    Console.WriteLine($"Il budget rimanente è: {g1.budget}");
                }
            }            
        }
    }
}
