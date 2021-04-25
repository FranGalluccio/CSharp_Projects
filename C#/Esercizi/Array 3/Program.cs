using System;

namespace Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //MATRICE CON ARRAY (VOTI ALUNNI)
            string[] alunni =  { "Rossi", "Celsi", "Giaccio" };
            string[] materie = { "lettere", "Inglese", "Storia"};

            int[,] voti = new int[3,3];
            Random r = new Random();

            for (int alunno = 0; alunno < voti.GetLength(0); alunno++)// Il metodo Get.Lenght prende la lunghezza di uno dei 2 array (0 è il primo in questo caso) 
                for (int materia = 0; materia < voti.GetLength(0); materia++)
                    voti[alunno, materia] = r.Next(1, 11);

            //STAMPA DEL TABELLONE
            Console.Write("\t\t");
            foreach (string materia in materie) Console.Write($"{materia}\t");
            Console.WriteLine();

            for (int alunno = 0; alunno < voti.GetLength(0); alunno++)
            {
                Console.Write($"{alunni[alunno]}\t\t");
                for (int materia = 0; materia < voti.GetLength(1); materia++)
                    Console.Write($"{voti[alunno, materia]}\t");
                Console.WriteLine();
            }

            // Cercare i voti di un alunno
            Console.Write("Quale alunno: ");
            string cercato = Console.ReadLine();
            int pos_trovato = -1;
            for (int alunno=0; alunno<alunni.Length; alunno++)
            if (alunni[alunno] == cercato)
                {
                    pos_trovato = alunno;
                    break;
                }
            if (pos_trovato == -1)
            {
                Console.WriteLine("Alunno inesistente");
            }
            else
            {
                for (int materia = 0; materia < materie.Length; materia++)
                {
                    Console.WriteLine($"{materie[materia]}: {voti[pos_trovato, materia]}");
                }
            }

            


            


        }
    }
}
