using System;
using System.Diagnostics;

namespace GraProceduralnie
{
    class Program
    {
        const string zaduzo = "ZA DUŻO";
        const string zamało = "ZA MAŁO";
        const string trafiono = "TRAFIONO";
        static void Main(string[] args)
        {
            Console.WriteLine("Gra w za dużo za mało");
            int a = WczytajLiczbę("Podaj dolny zakres losowania: ");
            int b = WczytajLiczbę("Podaj górny zakres losowania: ");
            int wylosowana = Losuj(a, b);
#if DEBUG
            Console.WriteLine(wylosowana);
#endif
            int licznik = 0;
            var stoper = new Stopwatch();
            stoper.Start();
            while (true)
            {
                //
                //2. człowiek zgaduje
                //

                licznik++; //licznik = licznik + 1;
                int propozycja = WczytajLiczbę("Podaj odpowiedź lub \"X\" aby zakończyć: ");
                string wynik = Ocena(wylosowana, propozycja);
                Console.WriteLine(wynik);
                if (wynik == trafiono)
                    break;
            }
            stoper.Stop();
            Console.WriteLine($"LICZBA RUCHÓW = {licznik}");
            Console.WriteLine($"CZAS GRY = {stoper.Elapsed}");
            Console.WriteLine("KONIEC GRY");
        }
        /// <summary>
        /// Losuje liczbę z podanego zakresu włącznie
        /// </summary>
        /// <param name="min">dolne ograniczenie</param>
        /// <param name="max">górne ograniczenie</param>
        /// <returns></returns>
        static int Losuj(int min = 1, int max = 100)
        {
            var min1 = Math.Min(min, max);
            var max1 = Math.Max(min, max);

            var rnd = new Random();
            var los = rnd.Next(min1, max1 + 1);
            return los;
        }

        static int WczytajLiczbę(string prompt = "")
        {
            bool poprawnie = false;
            
            int wynik = 0;
            do
            {
                Console.Write(prompt);
                string wczytano = Console.ReadLine();
                if (wczytano == "X" || wczytano == "x")
                    Environment.Exit(0);

                try
                {
                    wynik = int.Parse(wczytano);
                    poprawnie = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby. Spróbuj jeszcze raz");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Przekroczony zakres");
                }
                catch (Exception)
                {
                    Console.WriteLine("Nieznany błąd");
                }

            }
            while (!poprawnie);
            return wynik;
        }

        static string Ocena(int wylosowana, int propozycja)
        {
            if (wylosowana < propozycja)
            {
                return zaduzo;               
            }
            else if (wylosowana > propozycja)
            {
                return zamało;
            }
            else
            {
                return trafiono;
            }
        }
    }
}
