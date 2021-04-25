using System;

namespace Esercizi_base
{
    class Libro
    {
        private string autore = "";
        private string titolo = "";

        public string Titolo { get; set; } = "I promessi sposi";
        public string Autore { get => autore; }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Libro l = new Libro();
            Console.WriteLine(l.Titolo);
            Console.WriteLine(l.Autore);



        }
    }
}
