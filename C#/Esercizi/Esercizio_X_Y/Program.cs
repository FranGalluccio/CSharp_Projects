using System;
using Screen;

namespace Esercizio_X_Y
{


    class Program
    {
        static void Main(string[] args)
        {
            //  Pixel.setW(1024);
            /*  Console.WriteLine("Prima della chiamata di Pixel");

              Pixel p = new Pixel();

              Console.WriteLine("Dopo la chiamata di Pixel");

             // Pixel.setH(768);
             // Pixel.setW(1024);

              int nuovox = 100;
              int nuovoy = 200;

              p.setx(nuovox);
              p.sety(nuovoy);

              Pixel p2 = new Pixel();
              p2.setx(900);
              p2.sety(400);

              Console.WriteLine(p.getx() + " " + p.gety());
              Console.WriteLine(p2.getx() + " " + p2.gety());
            */
            //Pixel p2 = new Pixel(1024, 768);
            //Pixel p3 = new Pixel();
            //Pixel p4 = new Pixel();
            //Pixel.SetW(1920);
            //Pixel.SetH(1080);
            Pixel p1 = new Pixel
            {
                X = 2000,
                Y = 300
            };
            //Console.WriteLine(p1.X + " " + p1.Y);


            Pixel[] riga = new Pixel[Pixel.w];
            for (int i = 0; i < riga.Length; i++)
                Console.WriteLine($"{Array.Length(riga)}");
        }
    }
}
