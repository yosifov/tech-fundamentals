namespace TechFundamentals.AssocArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountRealNumbers
    {
        public static void Execute()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse);
            var sortedNumbers = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!sortedNumbers.ContainsKey(number))
                {
                    sortedNumbers.Add(number, 1);
                }
                else
                {
                    sortedNumbers[number]++;
                }
            }

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
