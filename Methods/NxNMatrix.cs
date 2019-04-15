namespace TechFundamentals.Methods
{
    using System;

    class NxNMatrix
    {
        public static void Execute()
        {
            int n = int.Parse(Console.ReadLine());
            PrintNxNMatrix(n);
        }

        private static void PrintNxNMatrix(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
