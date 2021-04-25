using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsercizioSuperenalotto
{
    class Superenalotto
    {
        static Random r = new Random();
        static Superenalotto()
        {
        }
        private static int ExtractNext(int[] array)
        {
            int value;
            do
            {
                value = r.Next(1, 90);
            }
            while (ArrayTools.Check(array, value));
            return value;           

        }        
        public static int[] Extraction(int number)
        {
            int[] array = new int[number];
            ArrayTools.Reset(array);
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ExtractNext(array);
            }

            return array;
        }        
        public static int GetJolly()
        {
            return r.Next(1, 90);
        }
    }
}


