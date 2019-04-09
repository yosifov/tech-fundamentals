namespace TechFundamentals
{
    using System;

    class MethodsLab
    {
        public static void Tasks()
        {
            //P01SignOfIntegerNumbers(int.Parse(Console.ReadLine()));
            //P02Grades(double.Parse(Console.ReadLine()));

            P04PrintingTriangle(int.Parse(Console.ReadLine()));
        }

        private static void P01SignOfIntegerNumbers(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }

        private static void P02Grades(double grade)
        {
            if (grade >= 2 && grade < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3 && grade <= 3.5)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.5 && grade < 4.5)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.5 && grade < 5.5)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.5 && grade <= 6)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Wrong number!");
            }
        }

        private static void P03Calculations()
        {

        }

        private static void P04PrintingTriangle(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (int i = rows - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
