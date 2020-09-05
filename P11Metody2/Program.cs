using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11Metody2
{
    class Program
    {
        static void Main(string[] args)
        {
            // wartosci domyslne
            OpiszPracownika("Jan", "Kowalski", 23, 1500.89 * 1.23);
            OpiszPracownika("Jan", "Kowalski", 23);
            OpiszPracownika("Jan", "Kowalski", wynagrodzenie: 1500.89 * 1.23); // parametr nazwany,named parametr
            Console.WriteLine();

            int x = 100;
            int y = 200;
            
            Console.WriteLine($"x={x}, y={y}"); // x=100, y=200

            //zamienZmienne(x, y); // powoduje przekazanie do metody zamienzmienne kopii wartosci
            zamienZmienne(ref x, ref y);
            Console.WriteLine($"x={x}, y={y}"); // x=200, y100



            Console.ReadLine();
        }

        static void zamienZmienne(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"a={a}, b={b}");
        }

        static void OpiszPracownika(string imie, string nazwisko, int wiek = 0, double wynagrodzenie = 0.0)
        {
            Console.WriteLine($"{imie} {nazwisko}, lat {wiek}, pensja {wynagrodzenie:C2}");


        }

    }

}
