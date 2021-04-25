using System;

namespace OOP_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro l = new Libro();            
            Console.WriteLine($"Titolo: {l.Titolo}");
            Console.WriteLine($"Autore: {l.Autore}");
            
        }
    }
}
