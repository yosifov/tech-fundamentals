namespace TechFundamentals.Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ChangeList
    {
        public static void Execute()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command.ToLower() != "end")
            {
                List<string> commands = command.Split().ToList();
                switch (commands[0].ToLower())
                {
                    case "delete":
                        numbers.RemoveAll(x => x == int.Parse(commands[1]));
                        break;
                    case "insert":
                        numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
