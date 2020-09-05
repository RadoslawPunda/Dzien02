using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7Petle
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHILE
            // 1. Najpierw spradzamy warunek
            // 2. Jak warunek jest prawdziwy to wykonujemy cialo petli

            int licznik = 0;
            while (licznik < 10 )
            {
                Console.WriteLine($"Licznik = {licznik}");
                licznik++;
            }

            Console.WriteLine();

            // DO.WHILE
            // 1. Najpierw wykonuje cialo petli
            // 2. Sprawdzam warunek
            // to oznacza ze ta petla zawsze wykona sie conajmniej raz

            licznik = 0;
            do
            {
                Console.WriteLine($"Licznik = {licznik}");
                licznik++;
            } while (licznik < 10);


            Console.WriteLine();

            // FOR
            /* for (zrob przed rozpoczeciem petli,raz na poczatku ;
                    sprawdz warunek,jak bedzie prawdziwy to wykonuj cialo petli;
                    instrukcja do wykonania po kazdym obrocie petli)
            kazdy z tych elementow jest opcjonalny
            */
            for (int i=0 ; i < 10 ; i++)
            {
                Console.WriteLine($"Licznik = {i} ");
            }
            Console.WriteLine();

            // kazdy z tych segmenow w for jest opcjonalny
            int j = 0;
            for (; ; )
            {
                if ( j < 10 )
                {
                    Console.WriteLine($"j={j}");
                    j++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine();
            // FORREACH
            // super sie sprawdza przy interakcjach przy tablicach/kolekcjach 
            string napis = "ala ma kota";
            foreach (char znak in napis)
            {
                Console.WriteLine(znak);
            }
            Console.WriteLine();
            // moge użyc petli while,do.while i for do iteracji po napisie
            // Ala ma kota -> dlugosc, .Lenght = 11 
            // 012345678910
            for (int i = 0; i < napis.Length; i++) // UWAGA na i<= napis.Lenght!! Bedize wyjatek
            {
                Console.WriteLine(napis[i]);
            }
            Console.WriteLine();

            // petle nieskonczone
            // to takie, gdzie warunek jest zawsze prawdziwy
            // a my decydujemy czy petle przerwac
            // do przerywania petli uzywamy instrukcji break

            Random rand = new Random();
            while (true)
            {
                int liczbaPseudolosa = rand.Next(100); // liczby od 0 do 99
                Console.WriteLine(liczbaPseudolosa);
                if (liczbaPseudolosa % 3 == 0 )
                {
                    break;
                }
            }
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
