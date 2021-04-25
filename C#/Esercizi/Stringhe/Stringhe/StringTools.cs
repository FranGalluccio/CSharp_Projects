using System;
using System.Collections.Generic;
using System.Text;

namespace Stringhe
{
    class StringTools
    {
        public static string[] toCharArray(in string text)
        {
            string text1 = text != null ? text.Replace(" ", "") : "";
            string[] result = new string[text1.Length];
            int resultIndex = 0;

            for (int i = 0; i < text1.Length; i++)
            {
                if (!Check(result, text1[i].ToString()))
                {
                    result[resultIndex++] = text1[i].ToString();
                }
            }
            string[] resultShrink = new string[resultIndex];
            Array.Copy(result, resultShrink, resultIndex);
            return resultShrink;
        }
        public static bool Check(string[] array, string value)
        {
            if (array != null && value != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (value.Equals(array[i]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
