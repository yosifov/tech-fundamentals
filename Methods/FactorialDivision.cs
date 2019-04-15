namespace TechFundamentals.Methods
{
    using System;

    class FactorialDivision
    {
        public static void Execute()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double result = Division(Factorial(firstNumber), Factorial(secondNumber));
            Console.WriteLine($"{result:F2}");
        }

        private static long Factorial(int factorialNumber)
        {
            long result = 1;
            if (factorialNumber == 0)
            {
                result = 0;
            }
            else
            {
                for (int i = 1; i <= factorialNumber; i++)
                {
                    result *= i;
                }
            }
            return result;
        }

        private static double Division(long firstNumber, long secondNumber)
        {
            return firstNumber / (double)secondNumber;
        }
    }
}
