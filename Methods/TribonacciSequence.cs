namespace TechFundamentals.Methods
{
    using System;
    using System.Collections.Generic;

    class TribonacciSequence
    {
        public static void Execute()
        {
            int n = int.Parse(Console.ReadLine());
            Tribonacci(n);
        }

        private static void Tribonacci(int n)
        {
            int[] tribonacciArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    tribonacciArray[i] = 1;
                }
                if (i == 1)
                {
                    tribonacciArray[i] = 1;
                }
                if (i == 2)
                {
                    tribonacciArray[i] = 2;
                }
                if (i > 2)
                {
                    tribonacciArray[i] = tribonacciArray[i - 1] + tribonacciArray[i - 2] + tribonacciArray[i - 3];
                }
            }
            Console.WriteLine(string.Join(" ", tribonacciArray));
        }
    }
}
