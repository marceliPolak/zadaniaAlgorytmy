using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Czy wprowadzona liczba x jest silnią liczby n?");
        Console.Write("Podaj liczbę x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę n:" );
        int n = int.Parse(Console.ReadLine());

        if (CzyJestSilnia(x, n))
        {
            Console.WriteLine("Liczba {0} jest silnią liczby {1}.", x, n);
        }
        else
        {
            Console.WriteLine("Liczba {0} nie jest silnią liczby {1}.", x, n);
        }
    }

    private static bool CzyJestSilnia(int x, int n)
    {
        int silnia = 1;

        for (int i = 1; i <= n; i++)
        {
            silnia *= i;

            if (silnia == x)
            {
                return true;
            }
            else if (silnia > x)
            {
                return false;
            }
        }

        return false;
    }
}
