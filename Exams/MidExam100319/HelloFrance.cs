namespace TechFundamentals.Exams.MidExam100319
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HelloFrance
    {
        public static void Execute()
        {
            var itemsToBuy = Console.ReadLine().Split("|");
            double budget = double.Parse(Console.ReadLine());

            double clothesMaxPrice = 50.0;
            double shoesMaxPrice = 35.0;
            double accessoriesMaxPrice = 20.5;

            List<double> newPrices = new List<double>();
            double profit = 0;

            for (int i = 0; i < itemsToBuy.Length; i++)
            {
                string item = itemsToBuy[i].Split("->")[0];
                double itemPrice = double.Parse(itemsToBuy[i].Split("->")[1]);

                if (budget - itemPrice < 0)
                {
                    continue;
                }
                else
                {
                    switch (item)
                    {
                        case "Clothes":
                            if (itemPrice <= clothesMaxPrice)
                            {
                                newPrices.Add(itemPrice + itemPrice * 0.4);
                                budget -= itemPrice;
                                profit += itemPrice * 0.4;
                            }
                            break;
                        case "Shoes":
                            if (itemPrice <= shoesMaxPrice)
                            {
                                newPrices.Add(itemPrice + itemPrice * 0.4);
                                budget -= itemPrice;
                                profit += itemPrice * 0.4;
                            }
                            break;
                        case "Accessories":
                            if (itemPrice <= accessoriesMaxPrice)
                            {
                                newPrices.Add(itemPrice + itemPrice * 0.4);
                                budget -= itemPrice;
                                profit += itemPrice * 0.4;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            foreach (var price in newPrices)
            {
                Console.Write($"{price:F2} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Profit: {profit:F2}");

            if (newPrices.Sum() + budget >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
