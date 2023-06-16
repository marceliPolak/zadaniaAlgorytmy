using System;

public class Program
{
    public static void Main(string[] args)
    {
        int dolnaGranica = 1;
        int gornaGranica = 20;
        
        bool znaleziono = false;

        Console.WriteLine("Pomyśl liczbę z przedziału od 1 do 20.");

        while (!znaleziono)
        {
           int propozycja = generujLosowaLiczbe(dolnaGranica, gornaGranica);

            Console.WriteLine("Czy Twoja liczba to {0}?", propozycja);
            Console.WriteLine("Podaj odpowiedź:");
            Console.WriteLine("\"-\" gdy liczba jest mniejsza,");
            Console.WriteLine("\"+\" gdy liczba jest większa");
            Console.WriteLine("\"tak\" gdy zgadłem");
            string odpowiedz =Console.ReadLine();

            if (odpowiedz == "-")
            {
                gornaGranica = propozycja - 1;
            }
            else if (odpowiedz == "+")
            {
                dolnaGranica = propozycja + 1;
            }
            else if (odpowiedz == "tak")
            {
                znaleziono = true;
                Console.WriteLine("Odgadłem! Twoja liczba to {0}.", propozycja);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa odpowiedź. Podaj -1, 1 lub 0.");
            }
        }
    }

    private static int generujLosowaLiczbe(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }
}
