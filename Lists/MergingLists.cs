namespace TechFundamentals.Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MergingLists
    {
        public static void Execute()
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(string.Join(" ", MergeLists(firstList, secondList)));
        }

        private static List<int> MergeLists(List<int> firstList, List<int> secondList)
        {
            List<int> mergedList = new List<int>();

            for (int i = 0; i < Math.Max(firstList.Count, secondList.Count); i++)
            {
                if (i < firstList.Count)
                {
                    mergedList.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    mergedList.Add(secondList[i]);
                }
            }

            return mergedList;
        }
    }
}
