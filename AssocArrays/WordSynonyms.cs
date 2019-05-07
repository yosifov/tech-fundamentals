namespace TechFundamentals.AssocArrays
{
    using System;
    using System.Collections.Generic;

    class WordSynonyms
    {
        public static void Execute()
        {
            int words = int.Parse(Console.ReadLine());

            var synonyms = CreateWordSynonyms(words);

            PrintDictionary(synonyms);
        }

        private static Dictionary<string, List<string>> CreateWordSynonyms(int wordsCount)
        {
            var synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < wordsCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }
                if (!synonyms[word].Contains(synonym))
                {
                    synonyms[word].Add(synonym);
                }
            }

            return synonyms;
        }

        private static void PrintDictionary(Dictionary<string, List<string>> synonyms)
        {
            foreach (var word in synonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
