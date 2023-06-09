// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby:");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            if (liczba1 > liczba2)
            {
                Console.WriteLine("Większa liczba: " + liczba1);
            }
            else if (liczba2 > liczba1)
            {
                Console.WriteLine("Większa liczba: " + liczba2);
            }
            else
            {
                Console.WriteLine("Liczby są równe");
            }
        }
    }
}
