using System;
using System.Collections.Generic;
using System.Text;

namespace Object_oriented
{

    class Point
    {
        private double x;
        private double y;
        private static long counter = 0;        

       
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            counter++;
        }
        public Point(double uguaglianza) : this(uguaglianza, uguaglianza)
        {
        }
        public Point() : this(0, 0) //Metodo costruttore
        {
        }
        public Point(Point inputPoint) : this(inputPoint == null ? 0 : inputPoint.x, inputPoint == null ? 0 : inputPoint.y)// COSTRUTTORE COPIA
        {           
        }
        public static long GetCounter()
        {
            return counter;
        } 
        public void Reset()
        {
            this.x = 0;
            this.y = 0;
        }

        public double Modulo()
        {
            return Math.Sqrt((x * x) + (y * y));
        }
        public double Distance(in Point p)
        {
            double px = p != null ? p.x : 0;
            double py = p != null ? p.y : 0;
            return Math.Sqrt(((x - px) * (x - px)) + ((y - py) * (y - py)));
        }
        public double Distance(in Line l) //Distanza di un punto da una retta/segmento
        {
            // d = |yp - (m*x + q)| / Sqrt(1 + m^2)
            double m = l.CoefficienteAngolare();
            double q = l.Intercetta();
            return Math.Abs(y - ((m * x) + q)) / Math.Sqrt(1 + (m * m));
        }
        public void SetX(double x)
        {
            this.x = x;

        }
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
        }
        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(((p1.x - p2.x) * (p1.x - p2.x)) + ((p1.y - p2.y) * (p1.y - p2.y)));
        }

        public static double Distance2(in Point p1, in Point p2)
        {
            Point Punto = p1 != null ? p1 : new Point();
            return p1.Distance(p2);
            /* if (p1 == null)
             {
                 Point Punto = new Point();
                 return Punto.Distance(p2);
             }*/
        }
    }
}
    
