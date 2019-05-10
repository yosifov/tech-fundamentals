namespace TechFundamentals.AssocArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Courses
    {
        public static void Execute()
        {
            var courses = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                var tokens = command.Split(" : ");
                if (!courses.ContainsKey(tokens[0]))
                {
                    courses.Add(tokens[0], new List<string>());
                }

                courses[tokens[0]].Add(tokens[1]);

                command = Console.ReadLine();
            }

            foreach (var kvp in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (var student in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}