using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_esercizio_ippodromo
{
    class Giocatore
    {
        public String nome;
        public String cognome;
        public double budget = 100;

        public double Scommessa()
        {
            budget -= 5;
            return budget;
        }
        public void Vincita()
        {
            budget += 100;
        }


    }
}
