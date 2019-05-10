namespace TechFundamentals.AssocArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ForceBook
    {
        public static void Execute()
        {
            var forceUsers = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                string user = "";
                string side = "";

                if (input.Contains(" | "))
                {
                    var tokensForAdd = input.Split(" | ");
                    user = tokensForAdd[1];
                    side = tokensForAdd[0];

                    if (!forceUsers.Values.SelectMany(lst => lst).Any(u => u == user))
                    {
                        if (!forceUsers.ContainsKey(side))
                        {
                            forceUsers[side] = new List<string>();
                        }
                        forceUsers[side].Add(user);
                    }
                }
                else if (input.Contains(" -> "))
                {
                    var tokensForCheck = input.Split(" -> ");
                    user = tokensForCheck[0];
                    side = tokensForCheck[1];

                    if (!forceUsers.Values.SelectMany(lst => lst).Any(u => u == user))
                    {
                        if (!forceUsers.ContainsKey(side))
                        {
                            forceUsers[side] = new List<string>();
                        }
                        forceUsers[side].Add(user);
                    }
                    else
                    {
                        string existingUserForce = forceUsers.FirstOrDefault(x => x.Value.Contains(user)).Key;
                        forceUsers[existingUserForce].Remove(user);
                        if (!forceUsers.ContainsKey(side))
                        {
                            forceUsers[side] = new List<string>();
                        }
                        forceUsers[side].Add(user);
                    }

                    Console.WriteLine($"{user} joins the {side} side!");
                }

                input = Console.ReadLine();
            }

            forceUsers = forceUsers.Where(x => x.Value.Count > 0).ToDictionary(x => x.Key, x => x.Value);

            foreach (var side in forceUsers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}