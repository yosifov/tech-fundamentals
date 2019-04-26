namespace TechFundamentals.Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HouseParty
    {
        public static void Execute()
        {
            int totalCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < totalCommands; i++)
            {
                string command = Console.ReadLine();
                List<string> commands = command.Split().ToList();

                if (command.Contains("is going"))
                {
                    AddGuest(guests, commands);
                }
                else if (command.Contains("is not going"))
                {
                    RemoveGuest(guests, commands);
                }
            }
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }

        private static void RemoveGuest(List<string> guests, List<string> commands)
        {
            if (guests.Contains(commands[0]))
            {
                guests.Remove(commands[0]);
            }
            else
            {
                Console.WriteLine($"{commands[0]} is not in the list!");
            }
        }

        private static void AddGuest(List<string> guests, List<string> commands)
        {
            if (guests.Contains(commands[0]))
            {
                Console.WriteLine($"{commands[0]} is already in the list!");
            }
            else
            {
                guests.Add(commands[0]);
            }
        }
    }
}
