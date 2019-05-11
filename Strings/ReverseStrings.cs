namespace TechFundamentals.Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseStrings
    {
        public static void Execute()
        {
            string initString = Console.ReadLine();
            while (initString != "end")
            {
                var reverseStringArr = initString.ToCharArray();
                Array.Reverse(reverseStringArr);
                string reverseString = new string(reverseStringArr);
                Console.WriteLine($"{initString} = {reverseString}");
                initString = Console.ReadLine();
            }
        }
    }
}