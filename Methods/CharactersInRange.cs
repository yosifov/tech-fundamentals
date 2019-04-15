namespace TechFundamentals.Methods
{
    using System;

    class CharactersInRange
    {
        public static void Execute()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintCharactersInRange(firstChar, secondChar);
        }

        private static void PrintCharactersInRange(char firstChar, char secondChar)
        {
            for (int i = Math.Min(firstChar, secondChar) + 1; i < Math.Max(firstChar, secondChar); i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
