namespace TechFundamentals.Methods
{
    using System;

    class PalindromeIntegers
    {
        public static void Execute()
        {
            string input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                CheckPalindrome(input);
                input = Console.ReadLine();
            }
        }

        private static void CheckPalindrome(string input)
        {
            string reverseString = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseString += input[i];
            }
            if (input == reverseString)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
