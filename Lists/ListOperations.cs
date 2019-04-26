namespace TechFundamentals.Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ListOperations
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
                    case "add":
                        AddNumberToList(numbers, int.Parse(commands[1]));
                        break;
                    case "insert":
                        InsertNumberToList(numbers, int.Parse(commands[1]), int.Parse(commands[2]));
                        break;
                    case "remove":
                        RemoveNumberAtIndex(numbers, int.Parse(commands[1]));
                        break;
                    case "shift":
                        ShiftList(numbers, commands[1], int.Parse(commands[2]));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void ShiftList(List<int> numbers, string direction, int count)
        {
            switch (direction.ToLower())
            {
                case "left":
                    for (int i = 0; i < count; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                    break;
                case "right":
                    for (int i = 0; i < count; i++)
                    {
                        numbers.Insert(0, numbers[numbers.Count - 1]);
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                    break;
                default:
                    break;
            }
        }

        private static void RemoveNumberAtIndex(List<int> numbers, int index)
        {
            if (index > numbers.Count - 1 || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.RemoveAt(index);
            }
        }

        private static void InsertNumberToList(List<int> numbers, int number, int index)
        {
            if (index > numbers.Count - 1 || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.Insert(index, number);
            }
        }

        private static void AddNumberToList(List<int> numbers, int number)
        {
            numbers.Add(number);
        }
    }
}
