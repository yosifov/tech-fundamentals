namespace TechFundamentals.Exams.FinalExam201218
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    class ActivationKeys
    {
        public static void Execute()
        {
            var inputs = Console.ReadLine().Split("&");
            var passwordValidation = @"^[[A-Za-z0-9]+$";
            var passwords = new List<string>();
            foreach (var input in inputs)
            {

                if ((input.Length == 16 || input.Length == 25) && Regex.IsMatch(input, passwordValidation))
                {
                    passwords.Add(input.ToUpper());
                }
            }
            var validShortPass = @"[A-Za-z0-9]{4}";
            var validLongPass = @"[A-Za-z0-9]{5}";
            var validatedPassowords = new List<string>();
            foreach (var password in passwords)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < password.Length; i++)
                {

                    if (char.IsDigit(password[i]))
                    {
                        var oldNumber = password[i] - '0';
                        var newNumber = 9 - oldNumber;
                        sb.Append(newNumber);
                    }
                    else
                    {
                        sb.Append(password[i]);
                    }
                }

                string convertedPass = sb.ToString();

                MatchCollection matches;

                if (password.Length == 16)
                {
                    matches = Regex.Matches(convertedPass, validShortPass);
                }
                else
                {
                    matches = Regex.Matches(convertedPass, validLongPass);
                }
                validatedPassowords.Add(string.Join("-", matches));
            }

            Console.WriteLine(string.Join(", ", validatedPassowords));
        }
    }
}