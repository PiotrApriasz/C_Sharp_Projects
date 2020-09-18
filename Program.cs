using System;
using CalculationsLibrary;

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
                result = CalculationsClass.Permutation(num1, num2);
                Console.WriteLine($"\nThe result for permutation is {result} options.");
            }
            else if (choice == 2)
            {
                result = CalculationsClass.Combination(num1, num2);
                Console.WriteLine($"\nThe result for combination is {result} options.");
            }
        }

        static double NumbersCheck()
        {
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
    }
}
