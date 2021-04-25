using System;

namespace Object_oriented
{

    public class MyClass //Tipi di classe (raggiungibilità)
    {
        public int a = 1;
        internal string b = "ciao";
        private string c = "Hello";
        protected int d = 2;
        int e = 3;
        protected internal int f = 4;
        private protected int g = 5;


    }
    class Program
    {    
        static void Main(string[] args)
        {
            /*Line Linea = new Line();
            Linea.p1.x = 0;
            Linea.p1.y = 0;
            Linea.p2.x = 4;
            Linea.p2.y = 0;
            /*Point Distanza = new Point();            
            Point Punto = new Point ();            
            Console.WriteLine("Inserisci il valore di x: ");
            Punto.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il valore di y: ");
            Punto.y = int.Parse(Console.ReadLine());
            Console.WriteLine($"La distanza dall'origine è: {Punto.Modulo()}");*/
            //Metodi costruttori.
            Point Punto1 = new Point(3,4); //prenderanno il valore di 3,4
            Console.WriteLine($"il Punto1 ha valore: {Punto1.x} e {Punto1.y} - {Point.GetCounter()}");
            Point Punto2 = new Point();  //prenderanno il valore di 0 e 0
            Console.WriteLine($"il Punto2 ha valore: {Punto2.x} e {Punto2.y} - {Point.GetCounter()}");

            Point Punto3 = new Point(5);//prenderanno entrambi il valore 5.
            Console.WriteLine($"il Punto3 ha valore: {Punto3.x} e {Punto3.y} - {Point.GetCounter()}");

            Point Punto4 = new Point(Punto1); // Farà la coia di Punto
            Console.WriteLine($"il Punto4 ha valore: {Punto4.x} e {Punto4.y} - {Point.GetCounter()}");

            Point Punto5 = (null);

            Point Punto6 = new Point(Punto5);
            Console.WriteLine($"il Punto6 ha valore: {Punto6.x} e {Punto6.y} - {Point.GetCounter()}");


            //Console.WriteLine(Point.Distance(Punto5, Punto3));
            //Console.WriteLine(Punto5.Distance(Punto3));


            //Console.WriteLine($"il Punto5 ha valore: {Punto5.x} e {Punto5.y}"); Eccezione Non gestita!
            /*Punto1.x = 2;
            Punto1.y = 2;
            Console.WriteLine($"La distanza è {Punto1.Distance(Linea)}");
            Triangolo Triangolo = new Triangolo();
            Triangolo.vertice1.x = 0;
            Triangolo.vertice1.y = 0;
            Triangolo.vertice2.x = 4;
            Triangolo.vertice2.y = 0;
            Triangolo.vertice3.x = 0;
            Triangolo.vertice3.y = 0;
            Console.WriteLine($"Lato 1 è: {Triangolo.GetL1()} Il lato 2 è: {Triangolo.GetL2()} il lato 3 è: {Triangolo.GetL1()}");
            Console.WriteLine($"Il perimetro è: {Triangolo.Perimetro()}");*/


        }
    }
}
