namespace TechFundamentals.Methods
{
    using System;

    class AddAndSubstract
    {
        public static void Execute()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Substract(Sum(firstNumber, secondNumber), thirdNumber));
        }

        private static int Substract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
