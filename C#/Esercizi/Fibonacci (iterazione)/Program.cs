using System;

class Program
{
    //FIBONACCI RICORSIVO
    static int Fibonacci_Ricorsivo(int numero)
    {
        return numero == 0 ? 0 : numero == 1 ? 1 : Fibonacci_Ricorsivo(numero - 1) + Fibonacci_Ricorsivo(numero - 2);
    }
    //FIBONACCI ITERATIVO 
    static int Fibonacci(int numero)
    {
        int a = 0;
        int b = 1;
       
        for (int i = 0; i < numero; i++)
        {
            int appoggio = a;
            a = b;
            b = appoggio + b;
        }
        return a;
    }

    static void Main()
    {
        Console.WriteLine("Ricorsiva:");
        for (int Ricorsiva = 0; Ricorsiva < 10; Ricorsiva++)
        {
            Console.WriteLine(Fibonacci_Ricorsivo(Ricorsiva));
        }

        Console.WriteLine("\n");

        Console.WriteLine("Iterativa:");
        for (int Iterativa = 0; Iterativa < 10; Iterativa++)
        {
            Console.WriteLine(Fibonacci(Iterativa));
        }
    }
}