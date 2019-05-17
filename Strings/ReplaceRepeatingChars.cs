namespace TechFundamentals.Strings
{
    using System;
    using System.Text;

    class ReplaceRepeatingChars
    {
        public static void Execute()
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            char currentChar = '\0';
            foreach (var character in input)
            {
                if (currentChar != character)
                {
                    currentChar = character;
                    sb.Append(character);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
