namespace TechFundamentals.Exams.MidExam041118
{
    using System;

    class PartyProfit
    {
        public static void Execute()
        {
            int companionsCount = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int coins = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    companionsCount -= 2;
                }
                if (i % 15 == 0)
                {
                    companionsCount += 5;
                }

                coins += 50 - (2 * companionsCount);

                if (i % 3 == 0)
                {
                    coins -= companionsCount * 3;
                    if (i % 5 == 0)
                    {
                        coins -= companionsCount * 2;
                    }
                }
                if (i % 5 == 0)
                {
                    coins += companionsCount * 20;
                }
            }
            Console.WriteLine($"{companionsCount} companions received {coins / companionsCount} coins each.");
        }
    }
}
