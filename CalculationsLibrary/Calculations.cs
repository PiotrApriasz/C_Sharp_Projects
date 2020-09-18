using System;

namespace CalculationsLibrary
{
    public class CalculationsClass
    {
        public static double Permutation(double num1, double num2)
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

        public static double Combination(double num1, double num2)
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
