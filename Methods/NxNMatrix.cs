namespace TechFundamentals.Methods
{
    using System;
    using System.Text;

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
                StringBuilder sb = new StringBuilder();

                for (int j = 1; j <= n; j++)
                {
                    if (j == n)
                    {
                        sb.Append(n);
                    }
                    else
                    {
                        sb.Append(n);
                        sb.Append(" ");
                    }
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
