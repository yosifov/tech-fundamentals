namespace TechFundamentals.Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Train
    {
        public static void Execute()
        {
            List<int> wagons = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command.ToLower() != "end")
            {
                if (command.ToLower().Contains("add"))
                {
                    AddWagon(wagons, command);
                }
                else
                {
                    AddPassengers(wagons, maxCapacity, command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void AddPassengers(List<int> wagons, int maxCapacity, string command)
        {
            int passengers = int.Parse(command);
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] + passengers <= maxCapacity)
                {
                    wagons[i] += passengers;
                    break;
                }
            }
        }

        private static void AddWagon(List<int> wagons, string wagon)
        {
            List<string> commands = wagon.Split().ToList();
            wagons.Add(int.Parse(commands[1]));
        }
    }
}
