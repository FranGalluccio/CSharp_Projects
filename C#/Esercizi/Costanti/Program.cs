using System;

namespace Costanti
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159; // non è possibile riassegnare un valore ad una costante
            double raggio = 10;
            Console.WriteLine($"Il valore di pi greco è: {pi}");
            Console.WriteLine($"Il valore radiale di un angolo giro è: {2 * pi}");
            Console.WriteLine($"L'area di un cerchio di raggio 10 è: {pi * raggio * raggio}");
            Console.WriteLine($"Il perimetro di un cerchio di un raggio 10 è: {2 * pi * raggio}");
        }
    }
}
