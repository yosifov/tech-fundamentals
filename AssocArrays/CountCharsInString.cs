namespace TechFundamentals.AssocArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountCharsInString
    {
        public static void Execute()
        {
            string input = Console.ReadLine();
            var chars = new Dictionary<char, int>();
            foreach (var symbol in input)
            {
                if (!chars.ContainsKey(symbol))
                {
                    chars[symbol] = 1;
                }
                else
                {
                    chars[symbol]++;
                }
            }
            chars = chars.Where(x => x.Key != ' ').ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
