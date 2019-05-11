namespace TechFundamentals.Strings
{
    using System;
    using System.Collections.Generic;

    class DigitsLettersAndOther
    {
        public static void Execute()
        {
            string str = Console.ReadLine();
            string digits = "";
            string letters = "";
            string otherChars = "";
            foreach (var character in str)
            {
                if (char.IsDigit(character))
                {
                    digits += character;
                }
                else if (char.IsLetter(character))
                {
                    letters += character;
                }
                else
                {
                    otherChars += character;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}
