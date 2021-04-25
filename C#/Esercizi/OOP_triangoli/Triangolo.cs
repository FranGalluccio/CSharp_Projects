using System;
using System.Collections.Generic;
using System.Text;

namespace Object_oriented

{
    class Triangolo
    {
        public Point vertice1 = new Point();
        public Point vertice2 = new Point();
        public Point vertice3 = new Point();

        public double Perimetro()
        {
            return GetL1() + GetL2() + GetL3();
        }

        public double GetL1()
        {
            return vertice1.Distance(vertice2);
        }
        public double GetL2()
        {
            return vertice2.Distance(vertice3);
        }
        public double GetL3()
        {
            return vertice3.Distance(vertice1);
        }
        public bool IsEquilatero()
        {
            return GetL1() == GetL2() && GetL1() == GetL3();             
        }

        public bool IsIsoscele()
        {
            //return (GetL1() == GetL2()) || (GetL2() == GetL3()) || ((GetL3() == GetL1()) && IsEquilatero() == false);
            return IsEquilatero() ? false : (GetL1() == GetL2()) || (GetL2() == GetL3()) || (GetL3() == GetL1());
        }
        public bool isScaleno()
        {
            return !IsEquilatero() && !IsIsoscele();
        }
    }
}
