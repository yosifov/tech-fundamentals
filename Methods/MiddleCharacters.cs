namespace TechFundamentals.Methods
{
    using System;

    class MiddleCharacters
    {
        public static void Execute()
        {
            string str = Console.ReadLine();
            Console.WriteLine(ReturnMiddleCharacters(str));
        }

        private static string ReturnMiddleCharacters(string str)
        {
            if (str.Length % 2 == 0)
            {
                return str[str.Length / 2 - 1].ToString() + str[str.Length / 2].ToString();
            }
            else
            {
                return str[str.Length / 2].ToString();
            }
        }
    }
}
