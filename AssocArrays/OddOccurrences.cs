namespace TechFundamentals.AssocArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class OddOccurrences
    {
        public static void Execute()
        {
            var commands = Console.ReadLine()
                .Split()
                .Select(x => x.ToLower())
                .ToArray();

            var words = CountWordsToDict(commands);

            PrintWordsWithOddValue(words);
        }

        private static void PrintWordsWithOddValue(Dictionary<string, int> words)
        {
            words = words.Where(x => x.Value % 2 != 0).ToDictionary(x => x.Key, x => x.Value);

            foreach (var word in words)
            {
                Console.Write($"{word.Key.ToLower()} ");
            }
        }

        private static Dictionary<string, int> CountWordsToDict(string[] commands)
        {
            var words = new Dictionary<string, int>();

            foreach (var command in commands)
            {
                if (!words.ContainsKey(command))
                {
                    words.Add(command, 1);
                }
                else
                {
                    words[command]++;
                }
            }

            return words;
        }
    }
}
