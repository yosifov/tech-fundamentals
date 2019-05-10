namespace TechFundamentals.AssocArrays
{
    using System;
    using System.Collections.Generic;

    class Orders
    {
        public static void Execute()
        {
            var productPrices = new Dictionary<string, double>();
            var productQuantities = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                var tokens = input.Split();
                string productName = tokens[0];
                double productPrice = double.Parse(tokens[1]);
                int productQuantity = int.Parse(tokens[2]);

                if (!productPrices.ContainsKey(productName))
                {
                    productPrices[productName] = productPrice;
                    productQuantities[productName] = productQuantity;
                }
                else
                {
                    if (productPrices[productName] != productPrice)
                    {
                        productPrices[productName] = productPrice;
                    }
                    productQuantities[productName] += productQuantity;
                }

                input = Console.ReadLine();
            }
            foreach (var item in productPrices)
            {
                Console.WriteLine($"{item.Key} -> {item.Value * productQuantities[item.Key]:F2}");
            }
        }
    }
}
