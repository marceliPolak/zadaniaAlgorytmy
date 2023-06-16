using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Podaj liczbę: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Pary liczb naturalnych o sumie: " + n);
        WypiszParyLiczb(n);
    }

    private static void WypiszParyLiczb(int n)
    {
        for (int i = 1; i <= n / 2; i++)
        {
            int j = n - i;

            if (i < j)
            {
                Console.WriteLine("({0}, {1})", i, j);
            }
            else if (i == j)
            {
                Console.WriteLine("({0}, {1})", i, j);
                break; // Przerywa pętle by nie powtarzać ostatniej pary liczb przy liczbie parzystej 
            }
        }
    }
}
