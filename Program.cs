// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj współrzędne punktu P (x, y):");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj promień koła r:");
            double r = Convert.ToDouble(Console.ReadLine());

            double distanceSquared = x * x + y * y;

            if (distanceSquared <= r * r)
            {
                Console.WriteLine("Punkt P leży w obrębie koła.");
            }
            else
            {
                Console.WriteLine("Punkt P nie leży w obrębie koła.");
            }
        }
    }
}