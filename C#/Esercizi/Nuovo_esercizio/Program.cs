using System;

namespace Nuovo_esercizio
{
    class Pixel
    {
        //field
        private int larghezza;
        private int altezza;

        //metodi
        public Pixel()
        {
        }
        public Pixel(int altezzaPixel, int larghezzaPixel)
        {
            larghezza = larghezzaPixel;
            altezza = altezzaPixel;
        }
        public int Altezza
        {
            get => altezza; set
            {
                this.altezza = altezza <= 1024 && altezza >= 0 ? throw new InvalidOperationException("Valore Altezza non valido") : value;
            }
        }
        public int Larghezza
        {
            get => larghezza; set
            {
                if (larghezza <= 780 && larghezza >= 0)
                {
                    throw new InvalidOperationException("Valore Altezza non valido");
                }
                else
                    this.larghezza = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pixel ControlloPixel2 = new Pixel(700, 500);
            Console.WriteLine($"Metodo Costruttore Overload: {ControlloPixel2.Altezza} {ControlloPixel2.Larghezza}");
            
            
        }
    }
}

// fare 3 metodi per avere il centro dello schermo x ed y , altro metodo per avere l'aspect ratio.
