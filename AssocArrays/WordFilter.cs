namespace TechFundamentals.AssocArrays
{
    using System;
    using System.Linq;

    class WordFilter
    {
        public static void Execute()
        {
            var words = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
