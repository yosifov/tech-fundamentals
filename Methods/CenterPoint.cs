namespace TechFundamentals.Methods
{
    using System;

    class CenterPoint
    {
        public static void Execute()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            ClosestPoint(x1, y1, x2, y2);
        }

        private static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1) + Math.Abs(y1) <= Math.Abs(x2) + Math.Abs(y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
