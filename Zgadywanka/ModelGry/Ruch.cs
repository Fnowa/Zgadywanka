using System;

namespace ModelGry
{
    public class Ruch
    {
        public readonly int Propozycja;
        public readonly ODP Odpowiedz;
        public readonly DateTime Kiedy;

        public Ruch(int prop, ODP odp)
        {
            Propozycja = prop;
            Odpowiedz = odp;
            Kiedy = DateTime.Now;
        }

        public override string ToString() => $"{Propozycja} | {Odpowiedz} | {Kiedy}";
        
    }
}