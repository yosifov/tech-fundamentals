using System;

namespace TechFundamentals
{
    class IntroAndBasicSyntaxExercise
    {
        public static void Tasks()
        {
            //P01Ages();
            //P02Division();
            //P03Vacation();
            //P04PrintAndSum();
            //P05Login();
            //P06StrongNumber();
            P07VendingMachine();
            //P08TriangleOfNumbers();
        }

        private static void P01Ages()
        {
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (age >= 3 && age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (age >= 14 && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (age >= 20 && age <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (age >= 66)
            {
                Console.WriteLine("elder");
            }
            else
            {
                Console.WriteLine("Wrong age!");
            }
        }

        private static void P02Division()
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (num % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }

        private static void P03Vacation()
        {
            int group = int.Parse(Console.ReadLine());
            var groupType = Console.ReadLine();
            var day = Console.ReadLine();
            switch (groupType)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        if (group >= 30)
                        {
                            double price = (group * 8.45) - (group * 8.45 * 15 / 100);
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                        else
                        {
                            double price = group * 8.45;
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                    }
                    else if (day == "Saturday")
                    {
                        if (group >= 30)
                        {
                            double price = (group * 9.80) - (group * 9.80 * 15 / 100);
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                        else
                        {
                            double price = group * 9.80;
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                    }
                    else if (day == "Sunday")
                    {
                        if (group >= 30)
                        {
                            double price = (group * 10.46) - (group * 10.46 * 15 / 100);
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                        else
                        {
                            double price = group * 10.46;
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        if (group >= 100)
                        {
                            double price = (group * 10.90) - (10 * 10.90);
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                        else
                        {
                            double price = group * 10.90;
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                    }
                    else if (day == "Saturday")
                    {
                        if (group >= 100)
                        {
                            double price = (group * 15.60) - (10 * 15.60);
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                        else
                        {
                            double price = group * 15.60;
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                    }
                    else if (day == "Sunday")
                    {
                        if (group >= 100)
                        {
                            double price = (group * 16) - (10 * 16);
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                        else
                        {
                            double price = group * 16;
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        if (group >= 10 && group <= 20)
                        {
                            double price = (group * 15) - (group * 15 * 5 / 100);
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                        else
                        {
                            double price = group * 15;
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                    }
                    else if (day == "Saturday")
                    {
                        if (group >= 10 && group <= 20)
                        {
                            double price = (group * 20) - (group * 20 * 5 / 100);
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                        else
                        {
                            double price = group * 20;
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                    }
                    else if (day == "Sunday")
                    {
                        if (group >= 10 && group <= 20)
                        {
                            double price = (group * 22.50) - (group * 22.50 * 5 / 100);
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                        else
                        {
                            double price = group * 22.50;
                            Console.WriteLine($"Total price: {price:F2}");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Wrong group type!");
                    break;
            }
        }

        private static void P04PrintAndSum()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;
            if (num1 > num2)
            {
                Console.WriteLine("Wrong numbers!");
            }
            else
            {
                for (int i = num1; i <= num2; i++)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
                Console.WriteLine();
                Console.WriteLine("Sum: " + sum);
            }
        }

        private static void P05Login()
        {
            string username = Console.ReadLine();
            string password = "";
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string currentPassword = Console.ReadLine();
            int attempts = 0;
            while (password != currentPassword)
            {

                attempts++;

                if (attempts == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");

                currentPassword = Console.ReadLine();

            }
            if (attempts < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }

        private static void P06StrongNumber()
        {
            Console.Write("Type a (int)number: ");
            int initNumber = int.Parse(Console.ReadLine());
            int number = initNumber;
            int digits = number.ToString().Length;
            int sumOfTheFactoriels = 0;
            for (int i = 0; i < digits; i++)
            {
                int lastDigit = number % 10;

                int factoriel = 1;

                for (int y = 1; y <= lastDigit; y++)
                {
                    factoriel *= y;
                }

                // Increase the sum
                sumOfTheFactoriels += factoriel;

                // Remove the last digit
                number = number / 10;

            }
            if (sumOfTheFactoriels == initNumber)
            {
                Console.WriteLine("Your number is strong!");
            }
            else
            {
                Console.WriteLine("Your number is NOT strong!");
            }
        }

        private static void P07VendingMachine()
        {
            string input = Console.ReadLine();
            double sum = 0;
            while (input != "Start")
            {
                double coin = double.Parse(input);
                if (coin == 0.1 ||
                    coin == 0.2 ||
                    coin == 0.5 ||
                    coin == 1 ||
                    coin == 2)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                double productPrice = 0;

                switch (input)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                if (sum >= productPrice && productPrice > 0)
                {
                    Console.WriteLine($"Purchased {input}");
                    sum -= productPrice;
                }
                else if (sum < productPrice && productPrice > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                input = Console.ReadLine();

            }
            Console.WriteLine($"Change: {sum:F2}");
        }

        private static void P08TriangleOfNumbers()
        {

        }
    }
}
