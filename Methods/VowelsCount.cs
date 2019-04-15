namespace TechFundamentals.Methods
{
    using System;

    class VowelsCount
    {
        public static void Execute()
        {
            string word = Console.ReadLine();
            Console.WriteLine(CountVowels(word));
        }

        private static int CountVowels(string word)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word.ToLower()[i] == 'a' || 
                    word.ToLower()[i] == 'o' ||
                    word.ToLower()[i] == 'e' ||
                    word.ToLower()[i] == 'i' ||
                    word.ToLower()[i] == 'u')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
