using System;

namespace Esercizi_for__4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inseriti due numeri A e B da tastiera visualizzare tutti i numeri da A a B; 
            //a fianco di ciascun numero deve apparire la scritta "ciao"
            Console.WriteLine("Inserisci il primo numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero:");
            int b = int.Parse(Console.ReadLine());

            if (a<b)
            {
                for (; a <= b; a++)
                {
                    Console.WriteLine($"{a} ciao");
                }
            }else
            {
                for (; b <= a; b++)
                {
                    Console.WriteLine($"{b} ciao");
                }
            }



        }
    }
}
