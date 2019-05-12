namespace TechFundamentals.Strings
{
    using System;

    class CharacterMultiplier
    {
        public static void Execute()
        {
            var strings = Console.ReadLine().Split();
            string firstString = strings[0];
            string secondString = strings[1];
            int sum = 0;
            if (firstString.Length >= secondString.Length)
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    sum += (int)firstString[i] * (int)secondString[i];
                }
                for (int i = secondString.Length; i < firstString.Length; i++)
                {
                    sum += (int)firstString[i];
                }
            }
            else
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += (int)firstString[i] * (int)secondString[i];
                }
                for (int i = firstString.Length; i < secondString.Length; i++)
                {
                    sum += (int)secondString[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
