namespace TechFundamentals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ArraysExercise
    {
        public static void Tasks()
        {
            //P01Train();
            //P02CommonElementsV1();
            //P02CommonElementsV2();
            P03ZigZagArrays();
        }

        private static void P01Train()
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] people = new int[wagons];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", people));
            int sumPeople = 0;
            foreach (var human in people)
            {
                sumPeople += human;
            }
            Console.WriteLine(sumPeople);
        }

        private static void P02CommonElementsV1()
        {
            int arrOneN = int.Parse(Console.ReadLine());
            string[] arrOne = new string[arrOneN];
            int arrTwoN = int.Parse(Console.ReadLine());
            string[] arrTwo = new string[arrTwoN];
            for (int i = 0; i < arrOne.Length; i++)
            {
                arrOne[i] = Console.ReadLine();
            }
            for (int i = 0; i < arrTwo.Length; i++)
            {
                arrTwo[i] = Console.ReadLine();
            }

            string commonElements = "";
            for (int i = 0; i < arrTwo.Length; i++)
            {
                for (int j = 0; j < arrOne.Length; j++)
                {
                    if (arrTwo[i] == arrOne[j])
                    {
                        commonElements += arrTwo[i] + " ";
                    }
                }
            }
            Console.WriteLine(commonElements);
        }

        private static void P02CommonElementsV2()
        {
            string firstElements = Console.ReadLine();
            var arrOne = firstElements.Split(" ");
            string secondElements = Console.ReadLine();
            var arrTwo = secondElements.Split(" ");
            string commonElements = "";
            for (int i = 0; i < arrTwo.Length; i++)
            {
                for (int j = 0; j < arrOne.Length; j++)
                {
                    if (arrTwo[i] == arrOne[j])
                    {
                        commonElements += arrTwo[i] + " ";
                    }
                }
            }
            Console.WriteLine(commonElements);
        }

        private static void P03ZigZagArrays()
        {
            int numElements = int.Parse(Console.ReadLine());
            string firstElements = "";
            string secondElements = "";
            for (int i = 1; i <= numElements; i++)
            {
                int[] arr = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    firstElements += arr[1] + " ";
                    secondElements += arr[0] + " ";
                }
                else
                {
                    firstElements += arr[0] + " ";
                    secondElements += arr[1] + " ";
                }
            }
            Console.WriteLine(firstElements);
            Console.WriteLine(secondElements);
        }
    }
}
