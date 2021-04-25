using System;

namespace Triangoli__if_else_
{
    class Program
    {
        static double Perimetro (double l1 , double l2 , double l3)
        {
            return l1 + l2 + l3;
        }
        
        
        static void Main(string[] args)
        {


            do
            {
                Console.WriteLine("* - * - * - * - * - * - * - * - * ");
                Console.WriteLine("          * TRIANGOLI *");
                Console.WriteLine("* - * - * - * - * - * - * - * - *\n");

                //determinare il tipo di triangolo in base agli input inseriti
                Console.WriteLine("Inserire un valore NUMERICO\n");
                Console.WriteLine("Inserire il valore del primo lato:");
                double l1 = double.Parse(Console.ReadLine()); //l = lati
                Console.WriteLine("Inserire il valore del secondo lato:");
                double l2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserire il valore del terzo lato:");
                double l3 = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (l1 + l2 <= l3 || l2 + l3 <= l1 || l3 + l1 <= l2 || l1 <= 0 || l2 <= 0 || l3 <= 0)
                {
                    Console.WriteLine("Non è un triangolo");
                }
                else
                {
                    double Base = 0;
                    double ll1 = l1 * l1;
                    double ll2 = l2 * l2;
                    double ll3 = l3 * l3;
                    Perimetro(l1,l2,l3);
                    double cosl1 = (((ll3) + (ll2) - (ll1)) / (2 * l3 * l2)); // coseno
                    double radl1 = Math.Acos(cosl1); // radiante
                    double angolo1 = (radl1 * 180) / Math.PI;
                    double cosl2 = ((ll3) + ll1 - ll2) / (2 * l3 * l1);
                    double radl2 = Math.Acos(cosl2);
                    double angolo2 = (radl2 * 180) / Math.PI;
                    double cosl3 = (ll1 + ll2 - ll3) / (2 * l1 * l2);
                    double radl3 = Math.Acos(cosl3);
                    double angolo3 = (radl3 * 180) / Math.PI;
                    double p_mezzo = Perimetro(l1,l2,l3) / 2;
                    double altezza = 0;
                    double lato = 0;
                    double Area_Erone = Math.Sqrt(p_mezzo * (p_mezzo - l1) * (p_mezzo - l2) * (p_mezzo - l3));
                    double Area_Erone_Troncata = (double)(int)(Area_Erone * 100) / 100;
                    //Esempio: Area_Erone = 4,5964 -> Area_Erone * 100 = 459,64 -> (int)(Area_Erone * 100) = 459              
                    
                    if (l1 == l2 && l2 == l3) // TRIANGOLO EQUILATERO
                    {
                        Base = l1;
                        lato = l1;
                        altezza = Math.Sqrt((lato * lato) - ((Base / 2) * (Base / 2)));
                        Console.WriteLine($"E' un triangolo equilatero\n");                        
                    }
                    else // TRIANGOLO NON EQUILATERO
                    {
                        if (l1 == l2 || l2 == l3 || l1 == l3) // TRIANGOLO ISOSCELE
                        {
                            Console.WriteLine("E' un triangolo isoscele");
                            Base = (l1 == l2) ? l3 : ((l1 == l3) ? l2 : l1);
                            lato = (l1 == l2) ? l1 : ((l1 == l3) ? l1 : l2);
                            altezza = Math.Sqrt(lato * lato - (Base / 2 * Base / 2));
                        }
                        else // TRIANGOLO SCALENO
                        {
                            Console.WriteLine("E' un triangolo scaleno");
                            //Base = ((l1 > l2 && l1 > l3)? l1: (l2 > l1 && l2 > l3)? l2 : l3);
                            //Base = (l1 > l2) ? ((l1 > l3) ? l1 : l3): ((l2>l3)? l2 : l3); 
                            Base = Math.Max(l1, Math.Max(l2, l3));
                        }
                        double c1 = 0;
                        double c2 = 0;
                        double i = 0;

                        //if (ll2 + ll3 == ll1 || ll1 + ll3 == ll2 || ll1 + ll2 == ll3)
                        //{
                        //    c1 = (ll1 + ll2 == ll3) ? l1 : ((ll2 + ll3 == ll1) ? l2 : l3);
                        //    c2 = (ll1 + ll2 == ll3) ? l2 : ((ll2 + ll3 == ll1) ? l3 : l1);
                        //    i = ((l1 != c1) && (l1 != c2) ? l1 : ((l2 != c1) && (l2 != c2) ? l2 : l3));
                        //}
                        
                        if (ll2 + ll3 == ll1)
                        {
                            c1 = l2;
                            c2 = l3;
                            i = l1;
                        }
                        else if (ll1 + ll3 == ll2)
                        {
                            c1 = l3;
                            c2 = l1;
                            i = l2;
                        }
                        else if (ll1 + ll2 == ll3)
                        {
                            c1 = l1;
                            c2 = l2;
                            i = l3;
                        }

                        if (i > 0) // TRIANGOLO RETTANGOLO
                        {
                            double cmax = Math.Max(c1, c2);
                            double cmin = Math.Min(c1, c2);
                            //double cmax = (c1 > c2) ? c1 : c2;
                            //double cmin = (c2 > c1) ? c2 : c1;
                            Console.WriteLine("Il triangolo è rettangolo");
                            Console.WriteLine($"il cateto maggiore è {cmax}, il cateto minore è {cmin}, l'ipotenusa è {i}");
                            Base = cmax;
                            altezza = cmin;
                        }

                        else
                        {
                            Console.WriteLine("Non è un triangolo rettangolo");
                        }
                    }
                    Console.WriteLine($"la base è {Base}");
                    Console.WriteLine($"l'altezza {altezza}");
                    Console.WriteLine($"l'area è {Base * altezza / 2}");
                    Console.WriteLine($"l'area del triangolo calcolata con il metodo di Erone è {Area_Erone}");
                    Console.WriteLine($"l'area del triangolo calcolata con il metodo di Erone è {Area_Erone_Troncata}");
                    Console.WriteLine($"Il perimetro è {Perimetro(l1,l2,l3)}");
                    Console.WriteLine($"gli angoli sono {angolo1} {angolo2} {angolo3}");
                }
                Console.WriteLine($"\nScrivi \"exit\" per uscire, premi \"invio\" per continuare\n");
            } while (Console.ReadLine() != "exit");
        }
    }
}