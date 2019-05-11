namespace TechFundamentals.Strings
{
    using System;
    using System.Collections.Generic;

    class Substring
    {
        public static void Execute()
        {
            var textToRemove = Console.ReadLine().ToLower();
            var text = Console.ReadLine();
            while(text.IndexOf(textToRemove) >= 0)
            {
                text = text.Remove(text.IndexOf(textToRemove), textToRemove.Length);
            }
            Console.WriteLine(text);
        }
    }
}