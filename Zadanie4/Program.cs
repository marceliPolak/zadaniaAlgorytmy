using System;

public class Program
{
    public static void Main(string[] args)
    {
        decimal kwotaPoczatkowa, oprocentowanie;
        int liczbaMiesiecy;

        Console.Write("Podaj kwotę początkową na koncie: ");
        kwotaPoczatkowa = decimal.Parse(Console.ReadLine());

        Console.Write("Podaj oprocentowanie konta w skali roku (%): ");
        oprocentowanie = decimal.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        liczbaMiesiecy = int.Parse(Console.ReadLine());

        decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        decimal podatekBelki = 0.19m; // 19% - wartość przykładowa, można dostosować do obowiązującego podatku Belki

        decimal kwotaKoncowa = kwotaPoczatkowa * (decimal)Math.Pow(1 + (double)oprocentowanieMiesieczne, liczbaMiesiecy);
        decimal podatek = (kwotaKoncowa - kwotaPoczatkowa) * podatekBelki;
        decimal kwotaZysku = kwotaKoncowa - kwotaPoczatkowa - podatek;

        //Zakładając że wynikiem ma być sam zarobek
        Console.WriteLine("Kwota zarobku to: {0:F2} zł", kwotaZysku);
    }
}
