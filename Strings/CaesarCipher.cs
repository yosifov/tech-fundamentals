namespace TechFundamentals.Strings
{
    using System;
    using System.Text;

    class CaesarCipher
    {
        public static void Execute()
        {
            string inputString = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (var character in inputString)
            {
                sb.Append((char)(character + 3));
            }

            Console.WriteLine(sb);
        }
    }
}