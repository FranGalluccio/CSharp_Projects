using System;
using System.Collections.Generic;
using System.Text;
using Esercizio_X_Y;

namespace Screen
{
    class Pixel
    {
        int _x;
        int _y;

        const int DEFH = 600;
        const int DEFW = 800;


        public static int w;
        private static int h;

        static int maxy;
        static int maxx;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = (value < 0) ? 0 : (value > maxx ? maxx : value);
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = (value < 0) ? 0 : (value > maxy ? maxy : value);
            }
        }
        public string Name { get; set; }

        static Pixel() // costruttore statico
        {
            SetW(DEFW);
            SetH(DEFH);
            Console.WriteLine("Chiamata a costruttore statico");
        }

        public Pixel() : this(0, 0)
        {
            Console.WriteLine("Nuova istanza di Pixel");
        }
        public Pixel(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static void SetW(int w)
        {
            Pixel.w = w;
            Pixel.maxx = w - 1;
        }

        public int GetW()
        {
            return w;
        }

        public static void SetH(int h)
        {
            Pixel.h = h;
            Pixel.maxy = h - 1;
        }

        public int GetH()
        {
            return h;
        }


        public static Pixel GetCentro()
        {
            //int pcentroh = h / 2;
            //int pcentrow = w / 2;            
            //Pixel centro = new Pixel(pcentroh,pcentrow);
            //return centro; 

            //Pixel centro = new Pixel();
            //centro.setx(w/2);
            //centro.sety(h/2);
            //return centro;
            return new Pixel(w / 2, h / 2);
        }
        public static double GetAspetto()
        {
            return (double)w / (double)h;
        }
        //public static Pixel[] GeneraRiga()
        //{
        //    Pixel[] riga = new Pixel[w];
        //        for(int i = 0; i<w; i++)
        //    {
        //        riga[i] = new Pixel(i, y);
        //    }
        //    return riga;
        //}

    }
}
