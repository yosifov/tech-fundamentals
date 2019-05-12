namespace TechFundamentals.RegularExpressions
{
    using System;
    using System.Text.RegularExpressions;

    class MatchNumbers
    {
        public static void Execute()
        {
            string expression = @"(^|(?<=\s))-?\d+(\.?\d+)?($|(?=\s))";
            string text = Console.ReadLine();
            var matches = Regex.Matches(text, expression);
            Console.WriteLine(string.Join(" ", matches));
        }
    }
}