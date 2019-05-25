namespace TechFundamentals.Strings
{
    using System;
    using System.Text;

    class MultiplyBigNumber
    {
        public static void Execute()
        {
            var num1 = Console.ReadLine().TrimStart(new char[] { '0' }).ToCharArray();
            int num2 = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            if (num2 == 0)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Array.Reverse(num1);
                int currentReminder = 0;

                foreach (var character in num1)
                {
                    int currentDigit = character - '0';

                    int currentMultiplication = currentDigit * num2 + currentReminder;

                    sb.Append(currentMultiplication % 10);

                    currentReminder = currentMultiplication / 10;
                }
                if (currentReminder > 0)
                {
                    sb.Append(currentReminder);
                }
            }
            var result = sb.ToString().ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(string.Join("", result));
        }
    }
}
