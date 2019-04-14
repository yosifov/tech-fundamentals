namespace TechFundamentals.Methods
{
	using System;

	class MathOperations
	{
		public static void Execute()
		{
			int number1 = int.Parse(Console.ReadLine());
			char operation = char.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());
			double result = MathOperate(number1, number2, operation);
			Console.WriteLine(result);
		}

		private static double MathOperate(int number1, int number2, char operation)
		{
			double result = 0;
			switch (operation)
			{
				case '+':
					result = number1 + number2;
					break;
				case '-':
					result = number1 - number2;
					break;
				case '/':
					result = number1 / number2;
					break;
				case '*':
					result = number1 * number2;
					break;
				default:
					Console.WriteLine("Wrong operation!");
					break;
			}
			return result;
		}
	}
}
