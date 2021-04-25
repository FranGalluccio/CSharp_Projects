using System;

namespace OOP_classi_esercizi
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerchio c1 = new Cerchio();
            Cerchio c2 = new Cerchio();
            Console.WriteLine($"Perimetro di c1: {c1.Perimetro()}, Area di c2: {c2.Area()}");
        }
    }
}
