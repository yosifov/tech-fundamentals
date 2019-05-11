namespace TechFundamentals.Strings
{
    using System;
    using System.Collections.Generic;

    class TextFilter
    {
        public static void Execute()
        {
            var bannedWords = Console.ReadLine().Split(", ");
            var text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                var asteriks = new string('*', word.Length);
                text = text.Replace(word, asteriks);
            }
            Console.WriteLine(text);
        }
    }
}