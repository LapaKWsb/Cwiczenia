// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wagę w kg:");
            double waga = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wzrost w metrach:");
            double wzrost = Convert.ToDouble(Console.ReadLine());

            double bmi = waga / (wzrost * wzrost);

            Console.WriteLine("Twoje BMI wynosi: " + bmi);
        }
    }
}