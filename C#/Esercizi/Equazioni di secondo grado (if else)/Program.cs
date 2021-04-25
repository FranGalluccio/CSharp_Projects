using System;

namespace Equazioni_di_secondo_grado__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("*-.-**-.-**-.-**-.-**-.-**-.-*");
                Console.WriteLine(" EQUAZIONI DI SECONDO GRADO");
                Console.WriteLine("*-.-**-.-**-.-**-.-**-.-**-.-*\n");
                Console.WriteLine("Inserisci il valore di a:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci il valore di b:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci il valore di c:");
                double c = double.Parse(Console.ReadLine());
                double x = 0;
                double x1 = 0;
                double x2 = 0;
                double Δ = (b * b) - (+4 * (a * c));

                if (a == 0 && b != 0)
                {
                    x = -c / b;
                    Console.WriteLine("l'equazione è di primo grado, nella forma:");
                    Console.WriteLine("bx+c=0");
                    Console.WriteLine($"il valore della x è: {x}");
                }
                else if (a == 0 && b == 0)
                {
                    Console.WriteLine("l'equazione non è valida");
                }
                else if (a != 0 && b == 0 && c == 0)
                {
                    Console.WriteLine("l'equazione è monomia nella forma:");
                    Console.WriteLine("ax^2 = 0");
                    Console.WriteLine("con due soluzioni reali e coincidenti uguali a zero:\nx1 = 0 x2 = 0");
                }
                else if (a != 0 && b != 0 && c == 0)
                {
                     x1 = 0;
                     x2 = -b / a;
                    Console.WriteLine("l'equazione è spuria, nella forma:");
                    Console.WriteLine("ax^2 + bx = x(ax + b) = 0");                    
                }
                else if (a != 0 && c != 0 && b == 0)
                {
                    Console.WriteLine("l'equazione è pura, nella forma:");
                    Console.WriteLine("ax^2 + c = 0");
                    if (-(c / a) > 0)
                    {
                         x1 = -Math.Sqrt(-(c / a));
                         x2 = Math.Sqrt(-(c / a));                        
                    }
                    else if (-(c / a) < 0)
                    {
                         x1 = -Math.Sqrt(Math.Abs(c / a));
                         x2 = Math.Sqrt(Math.Abs(c / a));                        
                    }
                }
                else if (a != 0 && b != 0 && c != 0)
                {
                    Console.WriteLine("l'equazione è completa, nella forma:");
                    Console.WriteLine("ax^2 + c = 0");
                    Console.WriteLine($"il delta è {Δ}");
                    if (Δ > 0)
                    {
                        x1 = (-b - Math.Sqrt(Δ)) / (a * 2); 
                        x2 = (-b + Math.Sqrt(Δ)) / (a * 2);
                    }
                    else if (Δ == 0)
                    {
                         x1 = -b / (a * 2);
                         x2 = -b / (a * 2);                    
                    }
                    else
                    {
                        x1 = -(b / (a * 2)) + (Math.Sqrt(Math.Abs(Δ)) / (a * 2));
                        x2 = -(b / (a * 2)) - (Math.Sqrt(Math.Abs(Δ)) / (a * 2));
                        Console.WriteLine("Le soluzioni sono complesse e coniugate");
                    }
                }
                //Console.WriteLine($"il valore di x1 è {(Δ < 0 || -(c / a) < 0 ? x1 + 'i' : x1)}");
                //Console.WriteLine($"il valore di x2 è {(Δ < 0 || -(c / a) < 0 ? x2 + 'i' : x2)}");
                if (Δ < 0 || -(c / a) < 0)
                {
                    Console.WriteLine($"il valore di x1 è {x1} -1i ed il valore di x2 è {x2} +1i");
                }
                else
                {
                    Console.WriteLine($"il valore di x1 è {x1} ed il valore di x2 è {x2}");
                }
                Console.WriteLine("\nScrivi \"exit\" per uscire, premi \"invio\" per continuare.");
            } while (Console.ReadLine() != "exit");
        }
    }
}
