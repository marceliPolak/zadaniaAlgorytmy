using System;
public class Zadanie3
{
   public static void Main()
    {
        Console.WriteLine("Podaj liczbę n większą od 5: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbę k większą od 5: ");
        int k = int.Parse(Console.ReadLine());
        if(n < k)
        {
            Console.WriteLine("Liczba n musi być większa od k");
        }
        else
        {
            if (n >= 5 && k >= 5)
            {
                long m = (obliczanieSilni(n) - obliczanieSilni(k)) / obliczanieSilni(k);
                Console.WriteLine("Wynik to:" + m);
            }
            else
            {
                Console.WriteLine("Jedna z podanych wartości jest mniejsza od 5");
            }
        }
        

    }
    static long obliczanieSilni(int x)
    {
        if (x == 0) return 1;
        long silnia = 1;

        for (int i = 1; i <= x; i++)
        {
            silnia *= i;
        }
        return silnia;

    }
}

