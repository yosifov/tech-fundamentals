namespace TechFundamentals.Methods
{
    using System;

    class GreaterValue
    {
        public static void Execute()
        {
            string type = Console.ReadLine();
            switch (type.ToLower())
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstNumber, secondNumber));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstStr = Console.ReadLine();
                    string secondStr = Console.ReadLine();
                    Console.WriteLine(GetMax(firstStr, secondStr));
                    break;
                default:
                    break;
            }
        }

        private static int GetMax(int num1, int num2)
        {
            int result = num1;
            if (num2 >= num1)
            {
                result = num2;
            }
            return result;
        }

        private static char GetMax(char char1, char char2)
        {
            char result = char1;
            if (char2 >= char1)
            {
                result = char2;
            }
            return result;
        }

        private static string GetMax(string str1, string str2)
        {
            string result = str1;
            int sumStr1 = 0;
            int sumStr2 = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                sumStr1 += str1[i];
            }
            for (int i = 0; i < str2.Length; i++)
            {
                sumStr2 += str2[i];
            }
            if (sumStr2 >= sumStr1)
            {
                result = str2;
            }
            return result;
        }
    }
}
