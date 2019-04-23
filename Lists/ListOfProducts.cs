namespace TechFundamentals.Lists
{
    using System;
    using System.Collections.Generic;

    class ListOfProducts
    {
        public static void Execute()
        {
            int productsCount = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < productsCount; i++)
            {
                products.Add(Console.ReadLine());
            }

            ProductsList(products);
        }

        private static void ProductsList(List<string> products)
        {
            products.Sort();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
