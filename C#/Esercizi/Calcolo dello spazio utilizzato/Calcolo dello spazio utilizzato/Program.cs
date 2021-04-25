using System;
using System.IO;


namespace Calcolo_dello_spazio_utilizzato
{
    class Program
    {
        static void Main(string[] args)
        static void Main(string[] args)
        {
            DirectoryInfo cartella = new DirectoryInfo("."); // Il punto sta ad indicare la cartella in cui ci troviamo (Riferimento shell)
            long totale_spazio = 0;

            foreach (FileInfo file in cartella.GetFiles())  //GetFiles è un metodo che va ad agire su DirectoryInfo. E' un elenco/collezione che possiamo esplorare ed enumerare elemento per elemento.
                                                            // per ciascun oggetto FileInfo nella collezione di GetFiles, possiamo accedere alle propietà e metodi di FileInfo per estrarre informazioni. 
            {
                Console.WriteLine($"File: {file.Name.PadRight(60, ' ')} - DImensione: {file.Length}bytes");    //PadRight = se il nome del file è più corto di 60 caratteri , aggiunge spazi riempitivi (a destra).
                totale_spazio += file.Length;            
            }

            Console.WriteLine($"\n------Totale spazio occupato dalla cartella {totale_spazio}bytes");

        }
    }
}
