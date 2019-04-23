namespace TechFundamentals.Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumAdjacentEqualNumbers
    {
        public static void Execute()
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            SumAdjacent(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<double> SumAdjacent(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            return numbers;
        }
    }
}
