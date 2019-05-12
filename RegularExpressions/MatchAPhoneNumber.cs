namespace TechFundamentals.RegularExpressions
{
    using System;
    using System.Text.RegularExpressions;

    class MatchAPhoneNumber
    {
        public static void Execute()
        {
            string expression = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            string text = Console.ReadLine();
            var matches = Regex.Matches(text, expression);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}