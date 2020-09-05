using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Metody
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperature w stopniach Celcjusza:");
            double tempCelcjusz = Convert.ToDouble(Console.ReadLine());

            // double tempFahrenhite = 32.0 + 9.0 / 5.0 * tempCelcjusz;
            // Console.WriteLine($"{tempCelcjusz} C = {tempFahrenhite} F ");

            //double tempFahrenheit = CelcjuszNaFahrenheit(tempCelcjusz);

            double tempFahrenheit = KonwerterJednostek.CelcjuszNaFahrenheit(tempCelcjusz);
            Console.WriteLine($"{tempCelcjusz} C = {tempFahrenheit} F ");

            Console.ReadLine();

        }

        /*static double CelcjuszNaFahrenheit(double celcjusz)
        {
            return 32.0 + 9.0 / 5.0 * celcjusz;
            // return konczy wywolanie metody
        }*/
    }
}
