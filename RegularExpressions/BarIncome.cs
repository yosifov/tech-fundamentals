namespace TechFundamentals.RegularExpressions
{
    using System;
    using System.Text.RegularExpressions;

    class BarIncome
    {
        public static void Execute()
        {
            string command = Console.ReadLine();
            double totalIncome = 0;
            while (command != "end of shift")
            {
                string validCommandExpression = @"%(?<user>[A-Z][a-z]+)%[^|%$.]*<(?<product>[\w]+)>[^|%$.]*\|(?<count>[0-9]+)\|[^|%$.]*?(?<price>[0-9]+\.?[0-9]*)\$";

                if (Regex.IsMatch(command,validCommandExpression))
                {
                    var matches = Regex.Matches(command, validCommandExpression);

                    foreach (Match match in matches)
                    {
                        var user = match.Groups["user"].Value;
                        var product = match.Groups["product"].Value;
                        int count = int.Parse(match.Groups["count"].Value);
                        double price = double.Parse(match.Groups["price"].Value);

                        Console.WriteLine($"{user}: {product} - {count * price:F2}");
                        totalIncome += count * price;
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}