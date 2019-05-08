namespace TechFundamentals.AssocArrays
{
    using System;
    using System.Collections.Generic;

    class AMinerTask
    {
        public static void Execute()
        {
            var resources = new Dictionary<string, int>();
            string resource = Console.ReadLine();

            while (resource.ToLower() != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = quantity;
                }
                else
                {
                    resources[resource] += quantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
