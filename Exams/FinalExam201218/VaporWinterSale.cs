namespace TechFundamentals.Exams.FinalExam201218
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class VaporWinterSale
    {
        public static void Execute()
        {
            string[] inputs = Console.ReadLine().Split(", ");
            var gamePrices = new Dictionary<string, double>();
            var gameDlcs = new Dictionary<string, string>();
            foreach (var input in inputs)
            {
                if (input.Contains("-"))
                {
                    string gameName = input.Split("-")[0];
                    double gamePrice = double.Parse(input.Split("-")[1]);
                    gamePrices[gameName] = gamePrice;
                }
                else if (input.Contains(":"))
                {
                    string gameName = input.Split(":")[0];
                    string gameDlc = input.Split(":")[1];
                    if (gamePrices.ContainsKey(gameName))
                    {
                        gameDlcs[gameName] = gameDlc;
                        gamePrices[gameName] += gamePrices[gameName] * 0.2;
                    }
                }
            }

            var gamesWithReducedPrices = new Dictionary<string, double>();

            foreach (var price in gamePrices)
            {
                if (gameDlcs.ContainsKey(price.Key))
                {
                    gamesWithReducedPrices[price.Key] = price.Value - price.Value * 0.5;
                }
                else
                {
                    gamesWithReducedPrices[price.Key] = price.Value - price.Value * 0.2;
                }
            }

            foreach (var price in gamesWithReducedPrices.Where(x => gameDlcs.ContainsKey(x.Key)).OrderBy(x => x.Value))
            {
                Console.WriteLine($"{price.Key} - {gameDlcs[price.Key]} - {price.Value:F2}");
            }
            foreach (var price in gamesWithReducedPrices.Where(x => !gameDlcs.ContainsKey(x.Key)).OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{price.Key} - {price.Value:F2}");
            }
        }
    }
}