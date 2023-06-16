
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę wyrazów ciągu Fibancciego: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
        else
        {
            Console.WriteLine("Podana wartość musi być dodatnia");
        }
        
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            int poprzedni = 0;
            int obecny = 1;
            int wynik = 0;

            for (int i = 2; i <= n; i++)
            {
                wynik = poprzedni + obecny;
                poprzedni = obecny;
                obecny = wynik;
            }

            return wynik;
        }
     

        
    }
    /*
     * Metoda bez z góry założonych dwóch pierwszych wyrazów ciągu
     * Przy dużym "n" program działa wolno gdzyz nie przechowuje poprzednich wyrazów ciągu 
     * i musi je liczyć na nowo za każdym razem

    static int Fibonacci(int n)
    {
        if (n == 0 || n == 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    */
}
