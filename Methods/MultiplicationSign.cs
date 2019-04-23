namespace TechFundamentals.Methods
{
    using System;

    class MultiplicationSign
    {
        public static void Execute()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            CheckMultiplication(numberOne, numberTwo, numberThree);
        }

        private static void CheckMultiplication(int numberOne, int numberTwo, int numberThree)
        {
            int[] arrNumbers = { numberOne, numberTwo, numberThree };
            int negativeNumbers = 0;

            for (int i = 0; i < 3; i++)
            {
                if (arrNumbers[i] == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }
                else if (arrNumbers[i] < 0)
                {
                    negativeNumbers++;
                }
            }
            if (negativeNumbers == 1 || negativeNumbers == 3)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
           
        }
    }
}
