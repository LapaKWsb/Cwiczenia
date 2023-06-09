// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            double liczba1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            double liczba2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj trzecią liczbę:");
            double liczba3 = Convert.ToDouble(Console.ReadLine());

            double srednia = (liczba1 + liczba2 + liczba3) / 3;

            Console.WriteLine("Średnia wynosi: " + srednia);
        }
    }
}
