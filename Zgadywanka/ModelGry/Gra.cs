using System;
using System.Collections.Generic;

namespace ModelGry
{
    public class Gra
    {
        // dane
        private readonly int wylosowana; // tylko  i tylko jeden raz przypisuje wartości

        public StanGry Stan { get; private set; }

        public List<Ruch> HistoriaGry { get; }
        
        //metody
        public Gra(int a = 1, int b = 100)
        {
            Random rnd = new Random();
            wylosowana = rnd.Next(a, b + 1);
            Stan = StanGry.Trwa;
        }

        public int Wylosowana
        {
            get
            {
                if (Stan == StanGry.Zakonczona)
                    return wylosowana;
                else throw new NotSupportedException("W trakcie gry nie dostaniesz tej informacji");
            }
        }

        public ODP Odpowiedz(int propozycja)
        {
            if (wylosowana < propozycja)
                return ODP.ZaMalo;
            else if (wylosowana > propozycja)
                return ODP.ZaDuzo;
            else
            {
                Stan = StanGry.Zakonczona;
                return ODP.Trafiono;

            }
        }

        public void Poddaj()
        {
            Stan = StanGry.Zakonczona;
        }


    }

    public enum StanGry
    {
        Rozpoczenta,
        Trwa,
        Zapauzowana,
        Zakonczona
    }

    public enum ODP
    {
        ZaMalo = -1,
        Trafiono = 0,
        ZaDuzo = 1
    }
}
