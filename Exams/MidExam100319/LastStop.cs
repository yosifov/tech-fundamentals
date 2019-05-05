namespace TechFundamentals.Exams.MidExam100319
{
    using System;
    using System.Linq;

    class LastStop
    {
        public static void Execute()
        {
            var paintings = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            while (input != "END")
            {
                var inputWords = input.Split();
                string command = inputWords[0];
                int paintingNumber;
                int changedNumber;
                int paintingNumber2;
                int place;

                switch (command)
                {
                    case "Change":
                        paintingNumber = int.Parse(inputWords[1]);
                        changedNumber = int.Parse(inputWords[2]);
                        if (paintings.Contains(paintingNumber))
                        {
                            paintings.Insert(paintings.IndexOf(paintingNumber), changedNumber);
                            paintings.Remove(paintingNumber);
                        }
                        break;
                    case "Hide":
                        paintingNumber = int.Parse(inputWords[1]);
                        if (paintings.Contains(paintingNumber))
                        {
                            paintings.Remove(paintingNumber);
                        }
                        break;
                    case "Switch":
                        paintingNumber = int.Parse(inputWords[1]);
                        paintingNumber2 = int.Parse(inputWords[2]);
                        if (paintings.Contains(paintingNumber) && paintings.Contains(paintingNumber2))
                        {
                            int firstNumberIndex = paintings.IndexOf(paintingNumber);
                            int secondNumberIndex = paintings.IndexOf(paintingNumber2);
                            paintings[firstNumberIndex] = paintingNumber2;
                            paintings[secondNumberIndex] = paintingNumber;
                        }
                        break;
                    case "Insert":
                        place = int.Parse(inputWords[1]);
                        paintingNumber = int.Parse(inputWords[2]);
                        if (place < paintings.Count)
                        {
                            if (place == paintings.Count - 1)
                            {
                                paintings.Add(paintingNumber);
                            }
                            else
                            {
                                paintings.Insert(place + 1, paintingNumber);
                            }
                        }
                        break;
                    case "Reverse":
                        paintings.Reverse();
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", paintings));
        }
    }
}