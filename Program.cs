using System;

namespace CombinationVS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int choice;
            int wynik;

            Console.WriteLine("Witaj w programie obliczajacym kombinacje i permutacje.");
            Console.WriteLine("Wpisz 2 liczby. Liczba pierwsza musi byc wieksza badz rowna drugiej.");
            Console.WriteLine("Pierwsza z nich to ilosc dostepnych mozliwosci a druga to ilosc opcji na probe\n");

            while (true)
            {
                Console.Write("Podaj pierwsza liczbe: ");
                num1 = NumbersCheck();

                Console.Write("Podaj druga liczbe: ");
                num2 = NumbersCheck();

                if (num1 >= num2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nPierwsza liczba jest mniejsza od drugiej. Wpisz poprawne dane\n");
                }
            }

            Console.Write("\nJesli chcesz obliczyc permutacje wybierz 1, a jesli chcesz obliczyc kombinacje wybierz 2: ");
            while (true)
            {
                choice = NumbersCheck();

                if (choice == 1 || choice == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Podano zly numer. Sprobuj jeszcze raz");
                    Console.Write("Podaj numer: ");
                    Console.WriteLine();
                }
            }

            if (choice == 1)
            {
                wynik = Permutacja(num1, num2);
                Console.WriteLine($"\nWynik dla permutacji wynosi {wynik} mozliwosci.");
            }
            else if (choice == 2)
            {
                wynik = Kombinacja(num1, num2);
                Console.WriteLine($"\nWynik dla kombinacji wynosi {wynik} mozliwosci.");
            }
        }

        static int NumbersCheck()
        {
            Nullable<int> num = null;
            while (true)
            {
                if (num < 0 || num == 0)
                {
                    Console.WriteLine("Nieprawidlowe dane lub pierwsza liczba mniejsza lub rowna 0");
                    Console.Write("Sprobuj jeszcze raz: ");
                    num = null;
                }
                if (num != null && num > 0)
                {
                    break;
                }
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Nieprawidlowe dane lub pierwsza liczba mniejsza lub rowna 0");
                    Console.Write("Sprobuj jeszcze raz: ");
                }
            }
            return (int)num;
        }

        static int Permutacja(int num1, int num2)
        {
            int silniaNum1 = num1;
            int roznica;
            int silniaRoznica;
            int wynik;

            for (int i = 1; i < num1; i++)
            {
                silniaNum1 *= i;
            }

            roznica = num1 - num2;
            silniaRoznica = roznica;

            for (int i = 1; i < roznica; i++)
            {
                silniaRoznica *= i;
            }

            wynik = silniaNum1 / silniaRoznica;

            return wynik;
        }

        static int Kombinacja(int num1, int num2)
        {
            int wynik;
            int silniaNum2 = num2;
            int permutacja = Permutacja(num1, num2);

            for (int i = 1; i < num2; i++)
            {
                silniaNum2 *= i;
            }

            wynik = permutacja / silniaNum2;

            return wynik;
        }
    }
}
