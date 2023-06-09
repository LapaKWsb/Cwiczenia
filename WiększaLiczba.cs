// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj dwie liczby");

            int liczba1 = int.Parse(Console.ReadLine());
            int liczba2 = int.Parse(Console.ReadLine());

            int wieksza = Math.Max(liczba1, liczba2);

            Console.WriteLine("Większa liczba to: " + wieksza);
        }
    }
}
