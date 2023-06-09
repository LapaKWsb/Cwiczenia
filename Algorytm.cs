// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj cztery liczby całkowite: a, b, c, d");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            if (b != 0 && d != 0)
            {
                int x = a * d + b * c;
                int y = b * d;

                Console.WriteLine("Licznik: " + x);
                Console.WriteLine("Mianownik: " + y);
            }
            else
            {
                Console.WriteLine("Brak rozwiązania");
            }
        }
    }`
}
