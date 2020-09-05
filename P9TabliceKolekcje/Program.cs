using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9TabliceKolekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            //OperacjeNaTablicach();
            //OperacjeNaListach();
            //OperacjeNaSlowniku();
            //OperacjeNaSortedList();
            //OperacjeNaStosie();
            OperacjeNaKolejkach();
        }

        static void OperacjeNaKolejkach()
        {
            // kolejka
            Queue<string> kolejka = new Queue<string>();
            kolejka.Enqueue("Zgloszenie 1");
            kolejka.Enqueue("Zgloszenie 2");
            kolejka.Enqueue("Zgloszenie 3");

            foreach (var zgloszenie in kolejka)
            {
                Console.WriteLine(zgloszenie);
            }
            Console.WriteLine();

            string zgloszenieDoObsluzenia = kolejka.Dequeue();
            Console.WriteLine(zgloszenieDoObsluzenia);

            Console.WriteLine();

            foreach (var zgloszenie in kolejka)
            {
                Console.WriteLine(zgloszenie);
            }
            Console.WriteLine();

            zgloszenieDoObsluzenia = kolejka.Dequeue();
            Console.WriteLine(zgloszenieDoObsluzenia);
            zgloszenieDoObsluzenia = kolejka.Dequeue();
            Console.WriteLine(zgloszenieDoObsluzenia);

            Console.WriteLine(kolejka.Count);

            // zgloszenieDoObsluzenia = kolejka.Dequeue();
            // Console.WriteLine(zgloszenieDoObsluzenia); // dostaniemy wyjatek

            Console.ReadLine();
        }
        static void OperacjeNaStosie()
        {
            //stos

            Stack<char> stosLiterek = new Stack<char>();
            stosLiterek.Push('a');
            stosLiterek.Push('b');
            stosLiterek.Push('c');
            stosLiterek.Push('d');
            stosLiterek.Push('e');

            foreach (var litera in stosLiterek)
            {
                Console.WriteLine(litera);
            }

            Console.WriteLine();

            char znakZGoryStosu = stosLiterek.Pop();
            Console.WriteLine(znakZGoryStosu);

            Console.WriteLine();

            foreach (var litera in stosLiterek)
            {
                Console.WriteLine(litera);
            }

             Console.ReadLine();
        }
        static void OperacjeNaSortedList()
        {
            //Sorted list
            // typ klucza i wartosci mozemy definiowac sami
            // automatycznie sortowana wg klucza
            SortedList<string, string> ludzie = new SortedList<string, string>();
            ludzie.Add("AN", "Ala Nowak");
            ludzie.Add("ZN", "Zdzislaw Nowak");
            ludzie.Add("PGG", "Piotr Grabski-Gradzinski");

            foreach (var inicjal in ludzie.Keys)
            {
                Console.WriteLine($"{inicjal} = {ludzie[inicjal]}");
            }

            Console.ReadLine();
        }


        static void OperacjeNaSlowniku()
        {
            // Dictionary - okreslamy typ klucza i wartosci
            // Hashtale - kluczem, wartoscia moze byc cokolwiek

            Dictionary<string, string> kraje = new Dictionary<string, string>();
            kraje.Add("PL", "Polska");
            kraje.Add("DE", "Niemcy");
            kraje.Add("FR", "Francja");

            Console.WriteLine(kraje["FR"]);

            kraje["CZ"] = "Czechy";

            Console.WriteLine(kraje["CZ"]);
            Console.WriteLine(kraje.ContainsKey("DE"));
            Console.WriteLine(kraje.ContainsKey("US"));
            Console.WriteLine(kraje.ContainsValue("Polska"));

            Console.WriteLine();

            foreach (string kraj in kraje.Values)
            {
                Console.WriteLine(kraj);
            }

            Console.WriteLine();

            foreach (string kodKraju in kraje.Keys)
            {
                Console.WriteLine($"{kodKraju} = {kraje[kodKraju]}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kvp in kraje)
            {
                Console.WriteLine($"{kvp.Key} = {kvp.Value}");
            }
            Console.ReadLine();
         }

        static void OperacjeNaListach()
        {

            // Array List
            // dynamiczna wielkosc
            // mozemy trzymac roznego typu elementy

            ArrayList imiona = new ArrayList(3);
            imiona.Add("Ala");
            imiona.Add("Tomek");
            imiona.Add("Krysia");
            imiona.Add(123);

            Console.WriteLine(imiona[0]);
            imiona[0] = "Piotr";
            Console.WriteLine(imiona[0]);

            Console.WriteLine();

            foreach (var imie in imiona)
            {
                Console.WriteLine(imie);
            }


            Console.WriteLine(imiona.Count);
            Console.WriteLine(imiona.Capacity); // ilosc zaraezerwowanego miejsca
            imiona.Add("Zosia");
            Console.WriteLine(imiona.Count);
            Console.WriteLine(imiona.Capacity); // kolekcja przeskalowuje sie wedlug initialCapacity

            Console.WriteLine();

            // List
            // w List definiujemy jakiego typu elementy trzymamy

            List<string> kraje = new List<string>();
            kraje.Add("Polska");
            kraje.Add("Niemcy");
            kraje.Add("Francja");

            foreach (var kraj in kraje)
            {
                Console.WriteLine(kraj);
            }

            Console.WriteLine(kraje[2]);
            Console.WriteLine();

            // wstawianie elementu na okreslone miejsce

            kraje.Insert(1, "Czechy");

            foreach (var kraj in kraje)
            {
                Console.WriteLine(kraj);
            }
            Console.WriteLine();

            // sortowanie
            kraje.Sort();

            foreach (var kraj in kraje)
            {
                Console.WriteLine(kraj);
            }
            Console.WriteLine();

            // usuwanie elementu
            kraje.Remove("Czechy");

            foreach (var kraj in kraje)
            {
                Console.WriteLine(kraj);
            }
            Console.WriteLine();

            kraje.RemoveAt(2);
            foreach (var kraj in kraje)
            {
                Console.WriteLine(kraj);
            }
            Console.WriteLine();

            List<string> kraje2 = new List<string>()
            {
                "Kanada",
                "Brazy",
                "Argentyna"
            };
            foreach (var kraj2 in kraje2)
            {
                Console.WriteLine(kraj2);
            }



            Console.ReadLine();
        }
        static void OperacjeNaTablicach()
        {
                // ARRAYS
                int[] pomiary = new int[10]; // jak duza ma byc tablica, indeksy beda od 0 do 9
                pomiary[0] = 10; // [0] operator dostepu 
                pomiary[1] = 20;
                pomiary[2] = 30;
                pomiary[3] = 40;

                Console.WriteLine(pomiary[2]); // 30
                Console.WriteLine(pomiary[8]); // 0 - c# inicjalizuje tablice wartosciami zerowymi
                                               // Console.WriteLine(pomiary[20]); // wyjatek bo nie ma takiego indeksu ,tablica ma tylko 10 elementow
                string[] test = new string[10];
                Console.WriteLine(test[0]); // tutaj bedzie null

                // tworzenie tablicy od razu z elementami
                int[] liczby = new int[5] { 10, 20, 30, 40, 50 }; // musze podac dokladnie tyle elementow jaki jest rozmiar tablicy
                Console.WriteLine(liczby[2]); // 30

                int[] liczby2 = new int[] { 100, 200, 300 };
                Console.WriteLine(liczby2[2]); // 300
                Console.WriteLine(liczby2.Length); // ile jest elementow w tablicy

                for (int i = 0; i < liczby2.Length; i++)
                {
                    Console.WriteLine($"Element {i} = {liczby2[i]}");
                }
                // foreach - wygodna iteracja po elementach tablicy
                // roznica miedzy for a foreach:
                // w przypadku foreach nie mamy dostepu do aktualnego indeksu ktory przetwarzamy
                foreach (int liczba in liczby2)
                {
                    Console.WriteLine($"Kolejna liczba z tablicy liczby2: {liczba}");
                }
                Console.WriteLine();

                foreach (var liczba in liczby2)
                {
                    Console.WriteLine($"Kolejna liczba z tablicy liczby2: {liczba}");
                }

                // ograniczenie tablic: raz utworzona tablica nie zmienia rozmiarow
                // jesli chcemy ja zwiekszyc to musimy utworzyc nowa tablice
                // i dane z niej przekopiowac

                int[] oceny1 = new int[] { 1, 2, 3, 4, 5, 6 };
                int[] oceny2 = oceny1;

                oceny1[0] = 100;

                foreach (var ocena in oceny1)
                {
                    Console.WriteLine($"Oceny1 - {ocena}");

                }
                Console.WriteLine();
                foreach (var ocena in oceny2)
                {
                    Console.WriteLine($"Oceny2 - {ocena}");

                }
                Console.WriteLine();

                // jak poprawnie skopiowac tablice
                int[] oceny3 = (int[])oceny1.Clone();
                oceny3[0] = 300;
                foreach (var ocena in oceny3)
                {
                    Console.WriteLine($"Oceny3 - {ocena}");

                }
                Console.WriteLine();
                foreach (var ocena in oceny2)
                {
                    Console.WriteLine($"Oceny2 - {ocena}");

                }
                Console.WriteLine();

                // zmiana rozmiaru tablicy
                int[] oceny4 = new int[20];
                Array.Copy(oceny1, oceny4, oceny1.Length);

                foreach (var ocena in oceny4)
                {
                    Console.WriteLine($"Oceny4 - {ocena}");

                }
                Console.WriteLine();

                // tablice wielowymiarowe regularna
                // [3,4] = 3 wierszze, 4 kolumny
                int[,] macierz = new int[3, 4]
                {
                {1, 2, 3, 4 },
                {10, 20, 30, 40 },
                {100, 200, 300, 400 }
                };
                Console.WriteLine(macierz[1, 3]); // 40 -> wiersze i kolumny sa indeksowane od 0

                // macierz.GetLength(wymiar) - zwraca dlugosc danego wymiaru
                for (int wiersz = 0; wiersz < macierz.GetLength(0); wiersz++)
                {
                    for (int kolumna = 0; kolumna < macierz.GetLength(1); kolumna++)
                    {
                        Console.Write($"{macierz[wiersz, kolumna]}, ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                // tablice nieregularne - jagged arrays

                int[][] temperatury = new[]
                {
                new int[] {10, 20, 30 },
                new int[] {1, 2, 3, 4, 5, 6 },
                new int[] {150, 300 }
                };
                Console.WriteLine(temperatury[2][1]);

                for (int i = 0; i < temperatury.Length; i++)
                {
                    for (int j = 0; j < temperatury[i].Length; j++)
                    {
                        Console.Write($"{temperatury[i][j]}, ");
                    }
                }

                Console.WriteLine();

                foreach (var czujnik in temperatury)
                {
                    foreach (var pomiar in czujnik)
                    {
                        Console.Write($"{pomiar}, ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        
    }
}
