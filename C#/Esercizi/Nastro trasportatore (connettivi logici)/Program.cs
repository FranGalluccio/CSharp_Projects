using System;

namespace Nastro_trasportatore
{
    class Program
    {
        static void Main(string[] args)
        {

            //L’avanzamento di un nastro trasportatore può avvenire secondo due modi di funzionamento: 1.è inserito l’interruttore di
            //alimentazione e vi sono pezzi da trasportare; 2.è inserito l’interruttore, vi sono pezzi da trasportare e il numero dei pezzi già
            //trasportati è inferiore ad un limite prefissato N.Inoltre l’avanzamento si deve arrestare automaticamente non appena qualche
            //incidente, per esempio la caduta di un pezzo, altera il funzionamento.

            bool i = true; // inserimento interruttore
            bool c = false; // se c'è un incidente
            bool p = true; // numero di pezzi da trasportare
            bool m = true; // modalità
            bool n = true; // pezzi inferiori
            bool a = i && p && (!c) && (m || n);

            Console.WriteLine("i \t c \t p \t m \t n \t Nastro funzionante");
            Console.WriteLine($"{i} \t {c} \t {p} \t {m} \t {n} \t {a}");

        }
    }
}
