// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Wpisz 3 liczby");

            double liczba1 = double.Parse(Console.ReadLine());
            double liczba2 = double.Parse(Console.ReadLine());
            double liczba3 = double.Parse(Console.ReadLine());

            double srednia = (liczba1 + liczba2 + liczba3) / 3;

            Console.WriteLine("Średnia arytmetyczna: " + srednia);
        }
    }
}
