// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długości bokow:");

            double bok1 = Convert.ToDouble(Console.ReadLine());
            double bok2 = Convert.ToDouble(Console.ReadLine());
            double bok3 = Convert.ToDouble(Console.ReadLine());

            if (bok1 > 0 && bok2 > 0 && bok3 > 0 && bok1 == bok2 && bok2 == bok3)
            {
                Console.WriteLine("Utworzyłeś trójkąt równoboczny!");
            }
            else
            {
                Console.WriteLine("Podane boki nie mogą utworzyć trójkąta rownobocznego");
            }
        }
    }
}
