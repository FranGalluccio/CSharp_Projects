using System;

namespace Costrutto_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string scelta = "";
            do
            {
                Console.WriteLine("MENU\n");
                Console.WriteLine("1 - somme");
                Console.WriteLine("2 - sottrazioni");
                Console.WriteLine("3 - moltiplicazioni");
                Console.WriteLine("4 - divisioni");
                Console.WriteLine("5 - potenze");
                Console.WriteLine("9 - Esci");

                Console.WriteLine();

                Console.WriteLine("SCEGLI -> ");
                scelta = Console.ReadLine();
                bool esito = int.TryParse(scelta, out int operazione);
                int op1 = 0, op2 = 0;



                if (operazione != 9 && operazione >= 1 && operazione <= 5)
                {
                    Console.Write("Primo operando -> ");
                    int.TryParse(Console.ReadLine(), out op1);

                    Console.Write($"{Environment.NewLine}Secondo operando -> ");
                    int.TryParse(Console.ReadLine(), out op2);
                }

                switch (operazione)
                {
                    case 0:
                        Console.WriteLine("non hai inserito " + (esito ? "una scelta valida" : "un numero"));
                        break;
                    case 1:
                        Console.WriteLine($"{op1} + {op2} = {op1 + op2}");
                        break;
                    case 2:
                        Console.WriteLine($"{op1} - {op2} = {op1 - op2}");
                        break;
                    case 3:
                        Console.WriteLine($"{op1} * {op2} = {op1 * op2}");
                        break;
                    case 4:
                        if (op2 != 0)
                            Console.WriteLine($"{op1} / {op2} = {(double)op1 / op2}");
                        else
                            Console.WriteLine("Impossibile dividere per 0");
                        break;
                    case 5:
                        Console.WriteLine($"{op1} elevato alla {op2} = {Math.Pow(op1, op2)}");
                        break;
                    case 9:
                        Console.WriteLine("Alla prossima operazione!");
                        break;
                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }


            } while (scelta != "9");

        }
    }
}



