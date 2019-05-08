namespace TechFundamentals.AssocArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LegendaryFarming
    {
        public static void Execute()
        {
            var keyMaterials = new Dictionary<string, int>
            {
                ["shards"] = 0,
                ["fragments"] = 0,
                ["motes"] = 0
            };
            var junkMaterials = new SortedDictionary<string, int>();

            while (keyMaterials["shards"] < 250
                && keyMaterials["fragments"] < 250
                && keyMaterials["motes"] < 250)
            {
                var input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    string material = input[i + 1].ToLower();
                    int quantity = int.Parse(input[i]);

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                        if (keyMaterials[material] >= 250)
                        {
                            break;
                        }
                    }
                    else if (!junkMaterials.ContainsKey(material))
                    {
                        junkMaterials[material] = quantity;
                    }
                    else
                    {
                        junkMaterials[material] += quantity;
                    }
                }
            }

            string keyMaterial = keyMaterials.First(x => x.Value >= 250).Key;
            keyMaterials[keyMaterial] -= 250;

            keyMaterials = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            string legendaryItem = "";
            switch (keyMaterial)
            {
                case "shards":
                    legendaryItem = "Shadowmourne";
                    break;
                case "fragments":
                    legendaryItem = "Valanyr";
                    break;
                case "motes":
                    legendaryItem = "Dragonwrath";
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{legendaryItem} obtained!");
            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}