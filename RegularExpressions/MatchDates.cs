﻿namespace TechFundamentals.RegularExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class MatchDates
    {
        public static void Execute()
        {
            string expression = @"(?<day>\d{2})([-./])(?<month>\w{3})\1(?<year>\d{4})";
            string text = Console.ReadLine();
            var matches = Regex.Matches(text, expression);
            foreach (Match date in matches)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
