using System;

namespace Calcolo_fattoriale
{
    class Program
    {
        // ALGORITMO ITERATIVO 
        static int Fattoriale_ricorsivo(int numero)
        {
            return (numero <= 1) ? 1 : numero * Fattoriale_ricorsivo(numero - 1);
        }
        static int Fattoriale(int numero)
        {
            
            for (int prod = numero -1; prod>0; prod--)
            {
                Console.Write($"{numero}*{prod} ");
                numero *= prod;                
            }
            return numero;
        }

        static void Main(string[] args)
        {
            
                
            Console.WriteLine("Inserisci un numero intero positivo:");
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine(Fattoriale(x));
            }
            else
            {
                Console.WriteLine($"Valore non valido");
            }

        }
    }
}
