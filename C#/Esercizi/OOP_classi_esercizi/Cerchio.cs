using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_classi_esercizi
{
    class Cerchio
    {
        public Punto Centro { get; set; } = new Punto (0, 0);
        public int Colore { get; set; } = 0;
        public int Spessore { get; set; } = 0;
        private double raggio = 1;
        public double Raggio
        {
            get => raggio;
                set
            {
                if (value > 0)
                    raggio = value;
                else
                    throw new ArgumentOutOfRangeException("Il raggio deve essere maggiore di 0");
            }
        }
        public Cerchio() { }
        public double Perimetro() { return 2 * Math.PI * raggio; }
        public double Area() { return Math.PI * raggio * raggio; }
    }
}
