// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pole koła");
            double pole = Convert.ToDouble(Console.ReadLine());

            double promien = Math.Sqrt(pole / Math.PI);

            double obwod = 2 * Math.PI * promien;

            Console.WriteLine("Obwód koła wynosi " + obwod);
        }
    }
}
