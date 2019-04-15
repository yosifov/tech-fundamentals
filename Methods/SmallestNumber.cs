namespace TechFundamentals.Methods
{
    using System;

    class SmallestNumber
    {
        public static void Execute()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestFromThreeNumbers(firstNumber, secondNumber, thirdNumber));
        }

        private static int SmallestFromThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            int smallestNumber = firstNumber;
            if (secondNumber < firstNumber)
            {
                smallestNumber = secondNumber;
                if (thirdNumber < secondNumber)
                {
                    smallestNumber = thirdNumber;
                }
            }
            else if (thirdNumber < firstNumber)
            {
                smallestNumber = thirdNumber;
            }
            return smallestNumber;
        }
    }
}
