namespace TechFundamentals.Methods
{
    using System;

    class MathPower
    {
        public static void Execute()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcPower(number, power));
        }

        private static double CalcPower(double number, int power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
