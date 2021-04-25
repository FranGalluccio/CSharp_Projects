using System;

namespace Anno_bisestile
{
    class Program
    {
        static void Main(string[] args)
        {

            //un anno è bisestile se divisibile per 4 o per 400 ma non per 100

            int anno = 2064;


            if (((anno % 4 == 0) || anno % 400 == 0) && anno % 100 != 0)
            {
                Console.WriteLine("L'anno è bisestile");
            }
            else
                Console.WriteLine("Non è bisestile");
        }
    }
}
