namespace TechFundamentals.Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RemoveNegativesAndReverse
    {
        public static void Execute()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            RemoveNegativesReversed(numbers);
        }

        private static void RemoveNegativesReversed(List<int> numbers)
        {
            numbers.RemoveAll(x => x < 0);

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
