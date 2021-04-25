using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_properties
{
    class Libro
    {
        private double costoSenzaIva = 12.9;
        private int iva = 4;
        private string autore = "Manzoni";
        //private string titolo = "";

        /*public string Titolo
        {
            get => titolo;
            set => titolo = value;
        }*/
        public double CostoSenzaIva => costoSenzaIva * (1 + (iva / 100));
        
        public string Titolo { get; private set; } = "I promessi sposi";
        public string Autore { get => autore; }

    }
}
