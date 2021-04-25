using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioSuperenalotto
{
    class Extractor
    {

        private int extractedNumber = 0;
        private Random r = new Random();
        private int _minValue = 1;
        private int _maxValue = 90;        
        private int[] array;
        public int ExtractionNumber { get { return array.Length; } }
        public int ExtractedNumber { get { return extractedNumber; } }
        public int MinValue { get { return _minValue; } set { _minValue = value > 0 ? value : 1; } }
        public int MaxValue { get { return _maxValue; } set { _maxValue = value > 0 ? value : 1; } }   
        
        

        public Extractor(int extractionNumber)
        {
            Reset(extractionNumber);
        }
        public Extractor(int extractionNumber, int minValue, int maxValue) : this(extractionNumber)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }
        public int GetValue()
        {
            return r.Next(MinValue, MaxValue);
        }

        public int GetNextValue()
        {
            int value = 0;
            if (extractedNumber < array.Length)
            {
                do
                {
                    value = GetValue();
                }
                while (ArrayTools.Check(array, value));
                array[extractedNumber] = value;
                extractedNumber++;
            }
            return value;
        }
        public void Reset(int extractionNumber)
        {
            array = new int[extractionNumber];
            ArrayTools.Reset(array);
            extractedNumber = 0;
        }





    }
}
