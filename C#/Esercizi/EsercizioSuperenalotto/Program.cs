using System;

namespace EsercizioSuperenalotto
{
    class Program
    {
        public static void PrintMatrix(int [,] matrix)
        {            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                  
                }
            }
        }
        public static void StampaArray(int[] array, int jolly)
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Il " + (i + 1) + " numero estratto è ...");
                    System.Threading.Thread.Sleep(500);
                    Console.Write(array[i]);
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("");
                }
                Console.WriteLine("Numero Jolly: " + jolly);
            }
        }
        public static void StampaEstrazione(Extractor extractor)
        {
            if (extractor != null)
            {
                for (int i = 0; i < extractor.ExtractionNumber; i++ )
                {
                    Console.Write("Il " + (i + 1) + " numero estratto è ...");
                    System.Threading.Thread.Sleep(500);
                    Console.Write(extractor.GetNextValue());
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("");
                }
                Console.WriteLine("Numero Jolly: " + extractor.GetValue());
            }
        }
        static void Main(string[] args)
        {
            //Superenalotto.StampaArray(Superenalotto.Estrazione);
            //Console.WriteLine("Seconda estrazione");
            //Superenalotto.EstrazioneNumeri();
            //Superenalotto.StampaArray(Superenalotto.Estrazione);
            //Program.StampaArray(Superenalotto.Extraction(6),Superenalotto.GetJolly());
            //Console.WriteLine("\n");
            //Program.StampaArray(Superenalotto.Extraction(6), Superenalotto.GetJolly());
            Extractor extractor = new Extractor(6,1,90);
            StampaEstrazione(extractor);                
            

        }
    }
}
