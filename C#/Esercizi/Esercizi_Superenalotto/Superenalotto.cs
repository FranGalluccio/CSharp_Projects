using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizi_Superenalotto
{
    class Superenalotto
    {
        private int numeroEstratto;
        private int maxNumeri = 100;
        Random r = new Random();
        private int[] numeriEstratti = new int[100];

        public int MaxNumeri
        {
            get 
            {
                return maxNumeri;
            }
            set
            {
                for (int i = maxNumeri; i > 0; i--)
                {
                }
            }
        }



    }
}
