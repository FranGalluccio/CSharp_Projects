using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizi_frazioni
{
    class Frazione
    {
        public int Num { get; set; } = 0;
        private int den;

        public int Den
        {
            get => den;
            set
            {
                if (value == 0) throw new ArgumentException("Denominatore 0");
                den = value;
            }
        }
        public Frazione() { }

        public Frazione(int num, int den)
        {
            Num = num; Den = den;
        }
        public Frazione(int n) : this(n, 1) { }

        public Frazione(string s)
        {
            if (string.IsNullOrEmpty(s)) return;
            string[] dati = s.Split('/'); // dati 0 = N, split '/', dati 1 = N   (es: 25/7 => ["25", "7"])
            try
            {
                Num = int.Parse(dati[0]);
            }
            catch (FormatException e)
            {
                throw new FormatException("La stringa non è nel formato N/N o N");
            }
            if (dati.Length == 1) // 25 (lo split non è stato effettuato)
                Den = 1; // frazione impropria
            else
            {
                try
                {
                    Den = int.Parse(dati[1]);
                }
                catch
                {
                    throw new FormatException("La stringa non è nel formato N/N o N");
                }
            }
        }
        override public string ToString() { return $"{Num}/{Den}"; }

        static public Frazione operator +(Frazione f1, Frazione f2)
        {
            return new Frazione((f1.Num * f2.Den) + (f2.Num * f1.Den), f1.Den * f2.Den);
        }
        public static implicit operator Frazione(int n) => new Frazione(n);
        public static explicit operator Frazione(string s) => new Frazione(s);
        public static bool operator ==(Frazione f1, Frazione f2)
        {
            return f1.Num * f2.Den == f2.Num * f1.Den;
        }
        public static bool operator !=(Frazione f1, Frazione f2)
        {
            return !(f1 == f2);
        }

        //static public frazione operator +(frazione f1, int n)
        //{
        //    return f1 + new frazione(n, 1);
        //}
    }
    
}
