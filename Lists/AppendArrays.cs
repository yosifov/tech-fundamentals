namespace TechFundamentals.Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AppendArrays
    {
        public static void Execute()
        {
            List<string> elements = Console.ReadLine().Split("|").ToList();
            List<int[]> arrays = new List<int[]>(elements.Count);
            for (int i = 0; i < elements.Count; i++)
            {
                arrays.Add(elements[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray());
            }
            arrays.Reverse();
            for (int i = 0; i < arrays.Count; i++)
            {
                if (i == arrays.Count - 1)
                {
                    Console.Write(string.Join(" ", arrays[i]));
                }
                else
                {
                    Console.Write(string.Join(" ", arrays[i]));
                    Console.Write(" ");
                }
            }
        }
    }
}
