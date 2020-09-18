using System;

namespace CombinationVS
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double choice;
            double result;

            Console.WriteLine("Hello! This is a program to calculate combination and permutation.");
            Console.WriteLine("Enter two numbers. First number must be greater or equal to second.\n");

            while (true)
            {
                Console.Write("Enter first number: ");
                num1 = NumbersCheck();

                Console.Write("Enter second number: ");
                num2 = NumbersCheck();

                if (num1 >= num2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nFirst number is less than the second. Enter correct numbers.\n");
                }
            }

            Console.Write("\nIf you want calculate permutation enter 1, and if you want calculate combination enter 2: ");
            while (true)
            {
                choice = NumbersCheck();

                if (choice == 1 || choice == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect choice. Try again.");
                    Console.Write("Enter number: ");
                    Console.WriteLine();
                }
            }

            if (choice == 1)
            {
                result = Permutation(num1, num2);
                Console.WriteLine($"\nThe result for permutation is {result} options.");
            }
            else if (choice == 2)
            {
                result = Combination(num1, num2);
                Console.WriteLine($"\nThe result for combination is {result} options.");
            }
        }

        static double NumbersCheck()
        {
            /*Nullable<double> num = null;
            while (true)
            {
                if (num < 0 || num == 0)
                {
                    Console.WriteLine("Incorrect numbers.");
                    Console.Write("Try again: ");
                    num = null;
                }
                if (num != null && num > 0)
                {
                    break;
                }
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect numbers.");
                    Console.Write("Try again: ");
                }
            }
            return (double)num;*/

            string numInput = "";
            double num = 0;

            while (num <= 0)
            {
                numInput = Console.ReadLine();

                while (!double.TryParse(numInput, out num))
                {
                    Console.Write("This is not valid input. Please enter an correct integer value: ");
                    numInput = Console.ReadLine();
                }

                if (num <= 0) Console.Write("This is not valid input. Please enter an correct integer value: ");
            }

            return num;
        }

        static double Permutation(double num1, double num2)
        {
            double factorialNum1 = num1;
            double difference;
            double factorialDifference;
            double result;

            for (int i = 1; i < num1; i++)
            {
                factorialNum1 *= i;
            }

            difference = num1 - num2;
            factorialDifference = difference;

            for (int i = 1; i < difference; i++)
            {
                factorialDifference *= i;
            }

            result = factorialNum1 / factorialDifference;

            return result;
        }

        static double Combination(double num1, double num2)
        {
            double result;
            double factorialNum2 = num2;
            double permutation = Permutation(num1, num2);

            for (int i = 1; i < num2; i++)
            {
                factorialNum2 *= i;
            }

            result = permutation / factorialNum2;

            return result;
        }
    }
}
