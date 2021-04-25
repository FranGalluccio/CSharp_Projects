using System;

namespace Metodi_Statici
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodoStatico();
            ClasseDiMetodiNonStatici tutorial = new ClasseDiMetodiNonStatici();
            tutorial.MetodoNonStatico();
        }
        static void MetodoStatico()
        {
            Console.WriteLine("Un salutone dal metodo statico");
        }      
    }
    class ClasseDiMetodiNonStatici
    {
        public void MetodoNonStatico()
        {
            Console.WriteLine("Un salutone dal metodo NON statico");
        }

    }
}

