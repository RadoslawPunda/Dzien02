using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Kierunki
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Wczytaj od uzytkownika kierunek [N, S, W, E]. Na tej podstawie wyświetl informacje czy jest to Północ, Południe, Wschód czy Zachód. 
            Obsłuż sytuację kiedy użytkownik poda nieprawidłowy kierunek.
            */

            Console.WriteLine("Podaj kierunek [N, S, W, E]:");
            string kierunek = Console.ReadLine().ToUpper(); // method chaining , lancuchowe wywolanie metod
            if (kierunek.Equals("N"))
            {
                Console.WriteLine("Polnoc");
            }
            else if (kierunek.Equals("S"))
            {
                Console.WriteLine("Poludnie");
            }
            else if (kierunek.Equals("W"))
            {
                Console.WriteLine("Zachod");
            }
            else if (kierunek.Equals("E"))
            {
                Console.WriteLine("Wschod");
            }
            else
            {
                Console.WriteLine("Podales zly kierunek");
            }

            // switch - do przelaczania wartosci danej zmiennej

            switch(kierunek)
            {
                case "N":
                    Console.WriteLine("Polnoc");
                    break;
                case "S":
                    Console.WriteLine("Poludnie");
                    break;
                case "W":
                    Console.WriteLine("Zachod");
                    break;
                case "E":
                    Console.WriteLine("Wschod");
                    break;
                default:
                    Console.WriteLine("Podales zly kierunek");
                    break;
            }

            Console.ReadLine();
        }
    }
}
