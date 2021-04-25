using System;

namespace esercizi2
{
    class Program
    {
        static void mcm_mcd (int n1, int n2, out int mcd, out int mcm)
        {
            int n1n2 = n1 * n2;
            
            while (n1 != n2)
            {
                if (n1 > n2)
                {
                    n1 -= n2;
                }
                n2 -= n1; 
            }
            mcd = n1;
            mcm = n1n2 / mcd;
        }





        static void Main(string[] args)
        {
            //           var n1, n2, x, y, mcd, mcm :int
            //begin
            //           x = 0;
            //           y = 0;
            //           n1 = x;
            //           n2 = y;
            //           do
            //               begin
            //               read(x);            //Lettura del primo valore "x" 
            //           end;
            //           while (n1 <= 0)        //Se n1<=0 viene richiesto di inserire il primo valore "x"
            //               do
            //                   begin
            //                   read(y);        //Lettura del secondo valore "y"
            //           end;
            //           while (n2 <= 0)        //Se n2<=0 viene richiesto di inserire il secondo valore "y"
            //               while (n1 != n2)
            //                   do
            //                       begin
            //               if (n1 > n2) then
            //                     begin
            //                        n1 = n1 - n2;
            //           end;
            //               else
            //               begin
            //                   n2 = n2 - n1;
            //           end;
            //           mcd = n1;
            //           write("Il massimo comune divisore è:  mcd ");
            //           mcm = ((xy) / (mcd));
            //           write("Il minimo comune multiplo è':  mcm");
            //           end;
            int n1 = x;
            int n2 = y;
            int x = 0;
            int y = 0;
            int mcd;
            int mcm;
            while (n1 <=0)
            {
                while (n2 <= 0)
                    while ( n1 != n2)
                    {
                        if (n1 > n2)
                        {
                            n1 = n1 - n2;
                        }
                        else
                        {
                            n2 = n2 - n1;
                        }
                    }
                Console.WriteLine($"Il massimo comun divisore è: {mcd}");
            }
            
        }
    }
}
    

