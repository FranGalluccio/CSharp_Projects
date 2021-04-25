using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //video 2000€ / 2
            int video = 2000/2;            
            int speseyu = 100;
            int speseta = 200;
            int speseatt = 400;
            int solditotaliyulan = video - speseyu;
            int solditootalitato = video - speseta - speseatt;
            
            Console.WriteLine($"soldiyulan {solditotaliyulan}");
            Console.WriteLine($"solditato {solditootalitato}");
            

        }
    }
}
