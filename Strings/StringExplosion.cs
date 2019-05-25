namespace TechFundamentals.Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StringExplosion
    {
        public static void Execute()
        {
            var input = Console.ReadLine().Split(">").ToList();
            var result = new List<string>();
            int strenghtReminder = 0;
            foreach (var item in input)
            {
                if (char.IsDigit(item[0]))
                {
                    int strenght = item[0] - '0';
                    strenght += strenghtReminder;
                    string newString = "";
                    if (item.Length - 1 >= strenght)
                    {
                        newString = item.Substring(strenght);
                        strenghtReminder = 0;
                    }
                    else
                    {
                        strenghtReminder = strenght - item.Length;
                    }
                    result.Add(newString);
                }
                else
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(">", result));
        }
    }
}