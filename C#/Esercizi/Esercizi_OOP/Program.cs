using System;

namespace Esercii_OOP
{
    class Data
    {
        //field - campi- attributi
        private int g = 1;
        private int m = 1;
        private int a = 1;
        //costruttore
        public Data(int _g, int _m, int _a)
        {
            G = _g; M = _m; A = _a;
        }
        public Data(string laData)
        {
            int posTrattino = laData.IndexOf('-');
            if (posTrattino == -1)
                throw new InvalidOperationException("Formato data non valido");
            string g = laData.Substring(0, posTrattino);
            G = int.Parse(g);

            posTrattino = laData.IndexOf('-', posTrattino + 1);
            if (posTrattino == -1) throw new InvalidOperationException("Formato data non valido");

            string m = laData.Substring(g.Length, posTrattino - g.Length - 1);
            M = int.Parse(m);

            string a = laData.Substring(posTrattino + 1, laData.Length - posTrattino - 1);
            int A = int.Parse(a);
        }
        //metodi
        bool Bisestile(int anno)
        {
            return a % 400 == 0 || (a % 4 == 0 && a % 100 != 0);
        }
        public int G //properties
        {
            get => g;
            set { if (value > GiorniMese() || value < g)
                    throw new InvalidOperationException("Formato giono non valido");
                else g = value;
            }
        }
        public int M //properties
        {
            get => m;
            set
            {
                if (value > 12 || value < 1)
                    throw new InvalidOperationException("Formato mese non valido");
                else m = value;
            }
        }
        public int A //properties
        {
            get => a;
            set
            {
                if (value < 1)
                    throw new InvalidOperationException("Formato anno non valido");
                else a = value;
            }
        }
        int GiorniMese()
        {
            switch (m)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return 28 + (a % 400 == 0 || (a % 4 == 0 && a % 100 != 0) ? 1 : 0);
                default:
                    return 31;
            }
        }
        public void SettaData(int gg, int mm, int aa)
        {
            G = gg; M = mm; A = aa;
        }
        public override string ToString()
        {
            return $"{G}-{M}-{A}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data(24, 12,90);           

            Console.WriteLine(d);
        }

    }
    
}
