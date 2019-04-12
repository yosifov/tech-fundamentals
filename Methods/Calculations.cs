namespace TechFundamentals.Methods
{
    using System;

    class Calculations
    {
        public static void Execute()
        {
            string operation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case "add":
                    Console.WriteLine(CalcAdd(firstNumber, secondNumber));
                    break;
                case "multiply":
                    Console.WriteLine(CalcMultiply(firstNumber, secondNumber));
                    break;
                case "substract":
                    Console.WriteLine(CalcSubstract(firstNumber, secondNumber));
                    break;
                case "divide":
                    Console.WriteLine(CalcDivide(firstNumber, secondNumber));
                    break;
                default:
                    break;
            }
        }

        private static int CalcDivide(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            return result;
        }

        private static int CalcSubstract(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        private static int CalcMultiply(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }

        private static int CalcAdd(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
    }
}
