namespace TechFundamentals.Strings
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class ValidUsernames
    {
        public static void Execute()
        {
            var usernames = Console.ReadLine().Split(", ");
            var validUsernames = new List<string>();

            foreach (var username in usernames)
            {
                var validUsername = Regex.IsMatch(username, @"^[A-Za-z0-9\-_]{3,16}$");
                if (validUsername)
                {
                    validUsernames.Add(username);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
        }
    }
}