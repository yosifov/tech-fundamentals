namespace TechFundamentals.Exams.MidExam100319
{
    using System;

    class SpringVacationTrip
    {
        public static void Execute()
        {
            int daysOfTheTrip = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            double fuelPricePerKm = double.Parse(Console.ReadLine());
            double foodPricePerPerson = double.Parse(Console.ReadLine());
            double roomPricePerPerson = double.Parse(Console.ReadLine());
            double hotelDiscount = 0.0;

            if (peopleCount > 10)
            {
                hotelDiscount = 0.25;
            }

            double totalExpenses = daysOfTheTrip * foodPricePerPerson * peopleCount
                + daysOfTheTrip * roomPricePerPerson * peopleCount
                - daysOfTheTrip * roomPricePerPerson * peopleCount * hotelDiscount;

            for (int i = 1; i <= daysOfTheTrip; i++)
            {
                double distance = double.Parse(Console.ReadLine());

                totalExpenses += distance * fuelPricePerKm;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    totalExpenses += totalExpenses * 0.4;
                }
                if (i % 7 == 0)
                {
                    totalExpenses -= totalExpenses / peopleCount;
                }
                if (totalExpenses > budget)
                {
                    Console.Write("Not enough money to continue the trip. ");
                    break;
                }
            }
            if (budget >= totalExpenses)
            {
                Console.WriteLine($"You have reached the destination. You have {budget - totalExpenses:F2}$ budget left.");
            }
            else
            {
                Console.WriteLine($"You need {totalExpenses - budget:F2}$ more.");
            }
        }
    }
}
