namespace TechFundamentals.Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BombNumbers
    {
        public static void Execute()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> bombNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            DetonateBomb(numbers, bombNumbers[0], bombNumbers[1]);
        }

        private static void DetonateBomb(List<int> numbers, int bomb, int damage)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int leftDamage = 0;
                    int rightDamage = 0;
                    if (damage < 0)
                    {
                        break;
                    }
                    if (i - damage < 0)
                    {
                        leftDamage = i;
                    }
                    else
                    {
                        leftDamage = damage;
                    }
                    if (i + damage >= numbers.Count)
                    {
                        rightDamage = numbers.Count - 1 - i;
                    }
                    else
                    {
                        rightDamage = damage;
                    }
                    numbers.RemoveRange(i - leftDamage, leftDamage + 1 + rightDamage);
                }
            }
            int result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
