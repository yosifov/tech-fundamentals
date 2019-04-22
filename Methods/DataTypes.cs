namespace TechFundamentals.Methods
{
    using System;

    class DataTypes
    {
        public static void Exercise()
        {
            string command = Console.ReadLine();

            switch (command)
            {
                case "int":
                    int intNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(Manipulate(intNumber));
                    break;
                case "real":
                    double realNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Manipulate(realNumber):F2}");
                    break;
                case "string":
                    string str = Console.ReadLine();
                    Console.WriteLine(Manipulate(str));
                    break;
                default:
                    break;
            }
        }

        private static string Manipulate(string str)
        {
            return $"${str}$";
        }

        private static double Manipulate(double number)
        {
            return number * 1.5;
        }

        private static int Manipulate(int number)
        {
            return number * 2;
        }
    }
}
