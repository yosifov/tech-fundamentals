namespace TechFundamentals.Strings
{
    using System;
    using System.Collections.Generic;

    class RepeatString
    {
        public static void Execute()
        {
            var input = Console.ReadLine();
            var words = input.Split();
            foreach (var word in words)
            {
                var repeatCount = word.Length;
                for (int i = 1; i <= repeatCount; i++)
                {
                    Console.Write(word);
                }
            }
        }
    }
}
