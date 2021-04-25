using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioSuperenalotto
{
    class ArrayTools
    {
        public static bool Check(int[] array, int value)
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void Fill(int[] array, int value)
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = value;
                }
            }
        }
        public static void Reset(int[] array)
        {
            Fill(array, 0);
        }
        public static bool Check(int[,] array, int value)
        {
            if (array != null)
            {
                foreach(int x in array)
                {
                    if (x == value)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

