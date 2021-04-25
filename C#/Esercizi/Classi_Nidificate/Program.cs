using System;

namespace Classi_Nidificate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classi Annidate = Nasted Class
            /* Le classi annidate sono predefinite private.
             * Ai metodi di queste classi , si può accedere solo tramite le classi
             * in cui sono contenute, se non vengono settate come pubbliche (public)
             * 
             * Queste classi sono usate in maniera spontanea quando si programma ad oggetti
             * Può capitare che una classe dipenda TOTALMENTE da un altra, e quindi si decide di implementarla 
             * al suo interno.
             * */

            ClassePrincipale RiferimentoClassePrincipale = new ClassePrincipale();
            RiferimentoClassePrincipale.VarClassePrincipale += 1000;
            RiferimentoClassePrincipale.MetodoClassePrincipale();
            ClassePrincipale.Interna RiferimentoClasseInterna = new ClassePrincipale.Interna();
            //E' una dichiarazione esplicita della classe, non un riferimento.
            RiferimentoClasseInterna.VarClasseInterna += 2000;
            RiferimentoClasseInterna.MetodoInterno();

        }
    }
    class ClassePrincipale
    {
        public int VarClassePrincipale = 10;

        public class Interna
        {
            public int VarClasseInterna = 50;

            public void MetodoInterno()
            {
                Console.WriteLine($"Dal MetodoInterno() = \n"+
                    $"La var ClasseInterna ha un valore di {VarClasseInterna}.\n"+
                    $"Questo è quanto.");
            }
        }
        Interna interna = new Interna();
        public void MetodoClassePrincipale()
        {
            VarClassePrincipale = 100;
            interna.MetodoInterno();
            interna.VarClasseInterna += 30;
            Console.WriteLine($"Dal MetodoClassePrincipale() = \n"+
                $"La varClassePrincipale ha un valore di: {VarClassePrincipale} \n"+
                $"La varClasseInterna ha un valore di: {interna.VarClasseInterna}.\n"+
                $"Questo è quanto.");
        }
    }
}
