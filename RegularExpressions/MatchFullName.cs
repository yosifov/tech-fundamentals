namespace TechFundamentals.RegularExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    class MatchFullName
    {
        public static void Execute()
        {
            string regex = @"\b[A-Z][a-z]+ \b[A-Z][a-z]+";
            string text = Console.ReadLine();
            MatchCollection matched = Regex.Matches(text, regex);

            foreach (var name in matched)
            {
                Console.Write(name + " ");
            }
        }
    }
}
