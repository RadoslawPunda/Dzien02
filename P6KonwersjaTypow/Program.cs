using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace P6KonwersjaTypow
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmiennaInt; // 4bajty
            byte zmiennaByte = 10; // 1 bajt

            zmiennaInt = zmiennaByte;
            Console.WriteLine($"zmiennaInt={zmiennaInt}");

            zmiennaInt = 12_345;
            zmiennaByte = (byte) zmiennaInt; // jawna konwersja
            Console.WriteLine($"zmiennnaByte={zmiennaByte}");

            /*
             * 12345 = 110000 00111001
             * 543210
             * 00111001 = 2^5+2^4+2^3+1 = 32 + 16 + 8 + 1 = 57
             */

            zmiennaInt = 2_147_483_647;
            zmiennaInt += 1;
            Console.WriteLine(zmiennaInt); // -2147483648

            bool zmiennaBool = true;
            // zmiennaInt = (int)zmiennaBool;
            zmiennaInt = Convert.ToInt32(zmiennaBool);
            Console.WriteLine(zmiennaInt);

            zmiennaInt = -10;
            zmiennaBool = Convert.ToBoolean(zmiennaInt); // 0->false, null-> false, cala reszta true
            Console.WriteLine(zmiennaBool);

            // string na int
            string zmiennaString = "123"; //"123asd" bedzie wyjatek,tego nie da sie 
            zmiennaInt = Convert.ToInt32(zmiennaString);
            Console.WriteLine(zmiennaInt);

            // int na string
            zmiennaInt = 200;
            zmiennaString = zmiennaInt.ToString();
            Console.WriteLine(zmiennaString);

            // string na double
            // przy tej konwersji wazne sa ustawienia regionalne w systemie
            zmiennaString = "3,14";
            double zmiennaDouble = Convert.ToDouble(zmiennaString);
            Console.WriteLine(zmiennaDouble);

            // string na bool
            zmiennaString = "false"; // "true" -> true, "false" ->false, cokolwiek innego daje wyjatek
            zmiennaBool = Convert.ToBoolean(zmiennaString);
            Console.WriteLine(zmiennaBool);

            // double int
            zmiennaDouble = 3.14;
            zmiennaInt = Convert.ToInt32(zmiennaDouble);
            zmiennaInt = (int)zmiennaDouble;
            Console.WriteLine(zmiennaInt);


            Console.ReadKey();
        }
    }
}
