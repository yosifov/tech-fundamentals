namespace TechFundamentals.Methods
{
    using System;

    class TopNumber
    {
        public static void Execute()
        {
            int lastNumberInRange = int.Parse(Console.ReadLine());
            PrintTopNumbersFromOneToN(lastNumberInRange);
        }

        private static void PrintTopNumbersFromOneToN(int lastNumberInRange)
        {
            for (int i = 1; i <= lastNumberInRange; i++)
            {
                if (SumOfDigitsDivisibleByEight(i) && ContainOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainOddDigit(int number)
        {
            bool result = false;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                if (number.ToString()[i] % 2 != 0)
                {
                    result = true;
                }
            }
            return result;
        }

        private static bool SumOfDigitsDivisibleByEight(int number)
        {
            bool result = false;
            int sumOfDigits = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                sumOfDigits += int.Parse(number.ToString()[i].ToString());
            }
            if (sumOfDigits % 8 == 0)
            {
                result = true;
            }
            return result;
        }
    }
}
