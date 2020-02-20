using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra w za dużo za mało");


            //
            //1. komputer losuje
            //
            #region losowanie
            Random los = new Random(); // Tworzę obiekt typu Random
            int Wylosowana = los.Next(1, 101);
#if DEBUG           
            Console.WriteLine(Wylosowana);
#endif
            Console.WriteLine("Wylosowałem liczbę od 1 do 100.\nOdgadnij ją.");
            #endregion

            bool odgadniete = false;
            // dopuki nie odgadniesz
            while (!odgadniete) 
            {
                //
                //2. człowiek zgaduje
                //

                Console.Write("Podaj odpowiedź: ");

                int Propozycja = int.Parse(Console.ReadLine());
                //
                //3. komputer ocenia
                //

                if (Propozycja < Wylosowana)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Za mało");
                    Console.ResetColor();
                }
                else if (Propozycja > Wylosowana)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Za dużo");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Trafiono");
                    Console.ResetColor();
                    odgadniete = true;
                }
            }

            Console.WriteLine("Dobra robota");
        }
    }
}
