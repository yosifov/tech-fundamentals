namespace TechFundamentals.Methods
{
	using System;

	class Orders
	{
		public static void Execute()
		{
			string product = Console.ReadLine();
			int num = int.Parse(Console.ReadLine());

			double totalPrice = CalcOrder(product, num);

			Console.WriteLine($"{totalPrice:F2}");
		}

		private static double CalcOrder(string product, int num)
		{
			double productPrice = 0;
			switch (product)
			{
				case "coffee":
					productPrice = 1.50;
					break;
				case "water":
					productPrice = 1.00;
					break;
				case "coke":
					productPrice = 1.40;
					break;
				case "snacks":
					productPrice = 2.00;
					break;
				default:
					Console.WriteLine("Wrong product!");
					break;
			}
			return num * productPrice;
		}
	}
}
