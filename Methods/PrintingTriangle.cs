﻿namespace TechFundamentals.Methods
{
    using System;

    class PrintingTriangle
    {
        public static void Execute()
        {
            Console.Write("Enter Max Number: ");
            int maxNumber = int.Parse(Console.ReadLine());
            PrintTriangle(maxNumber);
            PrintReverseTriangle(maxNumber - 1);
        }

        public static void PrintTriangle(int maxNumber)
        {
            for (int i = 1; i <= maxNumber; i++)
            {
                PrintNumbersInRow(i);
            }
        }

        public static void PrintReverseTriangle(int maxNumber)
        {
            for (int i = maxNumber; i > 0; i--)
            {
                PrintNumbersInRow(i);
            }
        }

        public static void PrintNumbersInRow(int maxNumber)
        {
            for (int j = 1; j <= maxNumber; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
