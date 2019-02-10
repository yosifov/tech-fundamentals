using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TechFundamentals
{
    class IntroAndBasicSyntaxLab
    {
        public static void Tasks()
        {
            //P01StudentInformation();
            //P02Passed();
            //P03PassedOrFailed();
            //P04BackIn30Minutes();
            //P05MonthPrinter();
            //P06ForeignLanguages();
            //P07TheatrePromotion();
            //P08DivisibleBy3();
            //P09SumOfOddNumbers();
            //P10MultiplicationTable();
            //P11MultiplicationTable2();
            //P12EvenNumber();
            P13HolidaysBetweenTwoDates();
        }

        private static void P01StudentInformation()
        {
            Console.Write("Type your name: ");
            var name = Console.ReadLine();
            Console.Write("Type your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Type your grade: ");
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
        }

        private static void P02Passed()
        {
            Console.WriteLine("Type your grade: ");
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }

        private static void P03PassedOrFailed()
        {
            Console.WriteLine("Type your grade: ");
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }

        private static void P04BackIn30Minutes()
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine()) + 30;
            if (h >= 0 && h <= 23)
            {
                if (m >= 30 && m <= 59)
                {
                    if (h == 23)
                    {
                        h = 0;
                        m = (m + 30) - 60;
                    }
                    else
                    {
                        h = h + 1;
                        m = (m + 30) - 60;
                    }
                    Console.WriteLine($"{h}:{m:D2}");
                }
                else if (m < 30 && m >= 0)
                {
                    m = m + 30;
                    Console.WriteLine($"{h}:{m:D2}");
                }
                else
                {
                    Console.WriteLine("Wrong time format!");
                }
            }
            else
            {
                Console.WriteLine("Wrong time format!");
            }
        }

        private static void P05MonthPrinter()
        {
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("Octomber");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        private static void P06ForeignLanguages()
        {
            var country = Console.ReadLine();
            switch (country)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }

        private static void P07TheatrePromotion()
        {
            var day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 18)
            {
                switch (day)
                {
                    case "Weekday": Console.WriteLine("12$"); break;
                    case "Weekend": Console.WriteLine("15$"); break;
                    case "Holiday": Console.WriteLine("5$"); break;
                    default:
                        Console.WriteLine("Wrong type of day!");
                        break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (day)
                {
                    case "Weekday": Console.WriteLine("18$"); break;
                    case "Weekend": Console.WriteLine("20$"); break;
                    case "Holiday": Console.WriteLine("12$"); break;
                    default:
                        Console.WriteLine("Wrong type of day!");
                        break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (day)
                {
                    case "Weekday": Console.WriteLine("12$"); break;
                    case "Weekend": Console.WriteLine("15$"); break;
                    case "Holiday": Console.WriteLine("10$"); break;
                    default:
                        Console.WriteLine("Wrong type of day!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        private static void P08DivisibleBy3()
        {
            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        private static void P09SumOfOddNumbers()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < (n * 2); i += 2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine(sum);
        }

        private static void P10MultiplicationTable()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", number, i, number * i);
            }
        }

        private static void P11MultiplicationTable2()
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            if (times > 10)
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
            }
            else
            {
                for (int i = times; i <= 10; i++)
                {
                    Console.WriteLine($"{theInteger} X {i} = {theInteger * i}");
                }
            }
        }

        private static void P12EvenNumber()
        {
            int number = int.Parse(Console.ReadLine());
            int absNumber = Math.Abs(number);
            while ((absNumber % 2) != 0)
            {
                Console.WriteLine("Please write an even number.");
                number = int.Parse(Console.ReadLine());
                absNumber = Math.Abs(number);
            }
            Console.WriteLine($"{absNumber}");
        }

        private static void P13HolidaysBetweenTwoDates()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "d.m.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "d.m.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            if (startDate >= endDate)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (DateTime date = startDate; date <= endDate; date.AddDays(1))
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday && date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        holidaysCount++;
                        Console.WriteLine(holidaysCount);
                    }
                }

            }

        }
    }
}
