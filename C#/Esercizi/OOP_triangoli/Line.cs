using System;
using System.Collections.Generic;
using System.Text;

namespace Object_oriented
{
    class Line
    {
        public Point p1 = new Point();
        public Point p2 = new Point();
        public double CoefficienteAngolare()
        {
            // m = y2 - y 1 / (x2 - x1)
            return (p2.y - p1.y) / (p2.x - p1.x);
        }

        public double Intercetta()
        {
            // y1 - m * x1
            return p1.y - (this.CoefficienteAngolare() * p1.x);
        }
    }
   
}

