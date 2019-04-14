namespace TechFundamentals.Methods
{
	using System;

	class Rectangle
	{
		public static void Execute()
		{
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());

			double area = CalcRectangleArea(width, height);

			Console.WriteLine(area);
		}

		private static double CalcRectangleArea(double width, double height)
		{
			return width * height;
		}
	}
}
