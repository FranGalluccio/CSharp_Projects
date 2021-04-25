using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioSuperenalotto
{
    class Cartella
    {
        public Cartella()
        {
            GeneraCartella(cartella);
        }
        Random r = new Random();
        int[] numCartella;
        int[,] cartella = new int[3, 5];

        public void GeneraCartella(int[,] matrix)
        {
            int value = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    do
                    {
                        value = r.Next();
                        matrix[i, j] = value;
                    }
                    while (ArrayTools.Check(matrix, value));
                }
            }
        }

    }
}
