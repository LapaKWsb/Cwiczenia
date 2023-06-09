// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double liczba1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj druga liczbę: ");
            double liczba2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numer działania (1.Dodawanie, 2.Odejmowanie, 3.Mnożenie, 4.Dzielenie): ");
            int numerDzialania = Convert.ToInt32(Console.ReadLine());

            double wynik = 0;

            if (numerDzialania == 1)
                wynik = liczba1 + liczba2;
            else if (numerDzialania == 2)
                wynik = liczba1 - liczba2;
            else if (numerDzialania == 3)
                wynik = liczba1 * liczba2;
            else if (numerDzialania == 4 && liczba2 != 0)
                wynik = liczba1 / liczba2;
            else
                wynik = liczba1 / 0;

            Console.WriteLine("Wynik: " + wynik);
        }
    }
}