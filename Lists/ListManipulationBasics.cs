namespace TechFundamentals.Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ListManipulationBasics
    {
        public static void Execute()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            int changes = 0;
            while (command.ToLower() != "end")
            {
                List<string> commands = command.Split(" ").ToList();
                switch (commands[0].ToLower())
                {
                    case "add":
                        int numberToAdd = int.Parse(commands[1]);
                        numbers.Add(numberToAdd);
                        changes++;
                        break;
                    case "remove":
                        int numberToRemove = int.Parse(commands[1]);
                        numbers.Remove(numberToRemove);
                        changes++;
                        break;
                    case "removeat":
                        int indexToRemoveAt = int.Parse(commands[1]);
                        numbers.RemoveAt(indexToRemoveAt);
                        changes++;
                        break;
                    case "insert":
                        int numberToInsert = int.Parse(commands[1]);
                        int indexToInsertAt = int.Parse(commands[2]);
                        numbers.Insert(indexToInsertAt, numberToInsert);
                        changes++;
                        break;
                    case "contains":
                        int numberToContains = int.Parse(commands[1]);
                        if (numbers.Contains(numberToContains))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "printeven":
                        PrintEven(numbers);
                        break;
                    case "printodd":
                        PrintOdd(numbers);
                        break;
                    case "getsum":
                        GetSum(numbers);
                        break;
                    case "filter":
                        string condition = commands[1];
                        int numberToFilter = int.Parse(commands[2]);
                        Filter(numbers, condition, numberToFilter);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            if (changes > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static void Filter(List<int> numbers, string condition, int number)
        {
            List<int> filteredNumbers = new List<int>();
            switch (condition)
            {
                case "<":
                    filteredNumbers = numbers.Where(x => x < number).ToList();
                    Console.WriteLine(string.Join(" ", filteredNumbers));
                    break;
                case ">":
                    filteredNumbers = numbers.Where(x => x > number).ToList();
                    Console.WriteLine(string.Join(" ", filteredNumbers));
                    break;
                case ">=":
                    filteredNumbers = numbers.Where(x => x >= number).ToList();
                    Console.WriteLine(string.Join(" ", filteredNumbers));
                    break;
                case "<=":
                    filteredNumbers = numbers.Where(x => x <= number).ToList();
                    Console.WriteLine(string.Join(" ", filteredNumbers));
                    break;
                default:
                    break;
            }
        }

        private static void GetSum(List<int> numbers)
        {
            int sumNumbers = 0;

            foreach (var number in numbers)
            {
                sumNumbers += number;
            }

            Console.WriteLine(sumNumbers);
        }

        private static void PrintOdd(List<int> numbers)
        {
            List<int> oddNumbers = numbers.Where(x => x % 2 != 0).ToList();
            Console.WriteLine(string.Join(" ", oddNumbers));
        }

        private static void PrintEven(List<int> numbers)
        {
            List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
            Console.WriteLine(string.Join(" ", evenNumbers));
        }
    }
}