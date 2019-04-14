namespace TechFundamentals.Methods
{
	using System;

	class MultiplyEvens
	{
		public static void Execute()
		{
			int number = int.Parse(Console.ReadLine());
			int result = MultiplyEvensByOdds(number);
			Console.WriteLine(result);
		}

		private static int MultiplyEvensByOdds(int number)
		{
			number = Math.Abs(number);

			int sumEvens = GetSumOfEvenDigits(number);
			int sumOdds = GetSumOfOddDigits(number);
			int result = Multiply(sumEvens, sumOdds);

			return result;
		}

		private static int GetSumOfOddDigits(int number)
		{
			int result = 0;

			for (int i = 0; i < number.ToString().Length; i += 2)
			{
				result += int.Parse(number.ToString()[i].ToString());
			}

			return result;
		}

		private static int GetSumOfEvenDigits(int number)
		{
			int result = 0;

			for (int i = 1; i <= number.ToString().Length - 1; i += 2)
			{
				result += int.Parse(number.ToString()[i].ToString());
			}

			return result;
		}

		private static int Multiply(int num1, int num2)
		{
			return num1 * num2;
		}
	}
}
