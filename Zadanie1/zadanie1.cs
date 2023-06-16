
using System;

internal class Zadanie1
{
    static void Main()
    {
        Console.Write("Podaj podstawę: ");
        int podstawa = int.Parse(Console.ReadLine());
        Console.Write("Podaj wykładnik: ");
        int wykladnik = int.Parse(Console.ReadLine());

        int result = Potegowanie(podstawa, wykladnik);

        Console.WriteLine("Wynik potęgowania: " + result);

    }
    internal static int Potegowanie(int podstawa, int wykladnik)
    {
        int result = 1;
        for(int i = 0; i < wykladnik; i++)
        {
            result *= podstawa;
        }
        return result;
    }
}
