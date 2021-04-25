using System;

namespace OOP_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polimorfismo - Polymorphism
            /* Il polimorfismo è quando in una ClasseBase (O SuperClasse) dichiariamo un metodo
             * e poi richiamiamo lo stesso metodo nelle sue sottoclassi 
             * a cosa serve?
             * serve a far si che tutte le classi prese in considerazione, svolgano 
             * le stesse funzioni ma ognuna in modo diverso
             * */
            SuperClass[] prova1 = new SuperClass[3];
            prova1[0] = new SuperClass();
            prova1[1] = new Sottoclasse();
            prova1[2] = new SottoclasseDue();
            
            foreach (SuperClass i in prova1)
            {
                i.MetodoA();
            }
            
        }
    }
    class SuperClass
    {
        protected int variabile = 10;

        public virtual void MetodoA()
        {
            variabile += 5;
            Console.WriteLine(variabile);
        }            
    }
    class Sottoclasse : SuperClass
    {
        public override void MetodoA() //override , ogni classe svolge la funzione, ma in maniera diversa.
        {
            variabile += 100;
            Console.WriteLine(variabile);
        }
    }
    class SottoclasseDue : SuperClass
    {
        public override void MetodoA() //override , ogni classe svolge la funzione, ma in maniera diversa.
        {
            variabile += 1000;
            Console.WriteLine(variabile);
        }
    }
}
