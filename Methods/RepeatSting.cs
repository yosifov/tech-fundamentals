namespace TechFundamentals.Methods
{
	using System;

	class RepeatSting
	{
		public static void Execute()
		{
			string str = Console.ReadLine();
			int repeatCount = int.Parse(Console.ReadLine());
			string repeatedString = RepeatStr(str, repeatCount);
			Console.WriteLine(repeatedString);
		}

		private static string RepeatStr(string str, int repeatCount)
		{
			string result = null;
			for (int i = 0; i < repeatCount; i++)
			{
				result += str;
			}
			return result;
		}
	}
}
