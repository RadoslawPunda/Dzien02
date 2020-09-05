using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8TabliczkaMnozenia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Wylosuj dwie liczby całkowite z zakresu od 0 do 10.
            Zapytaj uytkownika o wynik mnozenia tych dwoch liczb i sprawdz czy wynik 
            jest poprawny. Pytaj uzytkownika tak dlugo o wynik az poda poprawny
            */
            // 1. Trzeba wylosowac 2 liczby
            // 2. pokazac uzytkownikowi
            // 3 . w petli while pytac o rozwiazanie az poda wlasciwe
            Random rand = new Random();
            int liczba1 = rand.Next(11);
            int liczba2 = rand.Next(11);
            Console.WriteLine($"Ile to jest {liczba1}*{liczba2}");
            int wynik = liczba2 * liczba1;
            while (true)
            {
                Console.WriteLine("Podaj wynik");
                int podanyWynik = 0;
                podanyWynik = Convert.ToInt32(Console.ReadLine());
                if (podanyWynik != wynik)
                {
                    Console.WriteLine("Niepoprawny wynik!");
                }
                else
                {
                    Console.WriteLine("Brawo!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
