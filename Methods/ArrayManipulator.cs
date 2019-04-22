namespace TechFundamentals.Methods
{
    using System;
    using System.Linq;

    class ArrayManipulator
    {
        public static void Execute()
        {
            int[] numArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                if (command.Contains("exchange"))
                {
                    int index = int.Parse(command.Substring(9));

                    if (index >= numArray.Length || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ExchangeArray(numArray, index);
                    }
                }
                if (command.Contains("max"))
                {
                    if (command.Contains("odd"))
                    {
                        if (OddNumbers(numArray).Length > 0)
                        {
                            Console.WriteLine(Array.IndexOf(numArray, OddNumbers(numArray).Max()));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (command.Contains("even"))
                    {
                        if (EvenNumbers(numArray).Length > 0)
                        {
                            Console.WriteLine(Array.IndexOf(numArray, EvenNumbers(numArray).Max()));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");
                    }
                }
                if (command.Contains("min"))
                {
                    if (command.Contains("odd"))
                    {
                        if (OddNumbers(numArray).Length > 0)
                        {
                            Console.WriteLine(Array.IndexOf(numArray, OddNumbers(numArray).Min()));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (command.Contains("even"))
                    {
                        if (EvenNumbers(numArray).Length > 0)
                        {
                            Console.WriteLine(Array.IndexOf(numArray, EvenNumbers(numArray).Min()));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");
                    }
                }

                int elementsCounter;

                if (command.Contains("first"))
                {
                    if (command.Contains("even"))
                    {
                        elementsCounter = int.Parse(command.Substring(5, command.Length - 9));

                        if (elementsCounter > numArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (elementsCounter > EvenNumbers(numArray).Length)
                            {
                                elementsCounter = EvenNumbers(numArray).Length;
                            }
                            Console.Write("[");
                            if (EvenNumbers(numArray).Length > 0)
                            {
                                Console.Write(string.Join(", ", FirstNElements(EvenNumbers(numArray), elementsCounter)));
                            }
                            Console.WriteLine("]");
                        }
                    }
                    else if (command.Contains("odd"))
                    {
                        elementsCounter = int.Parse(command.Substring(5, command.Length - 8));

                        if (elementsCounter > numArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (elementsCounter > OddNumbers(numArray).Length)
                            {
                                elementsCounter = OddNumbers(numArray).Length;
                            }
                            Console.Write("[");
                            if (OddNumbers(numArray).Length > 0)
                            {
                                Console.Write(string.Join(", ", FirstNElements(OddNumbers(numArray), elementsCounter)));
                            }
                            Console.WriteLine("]");
                        }
                    }
                }
                if (command.Contains("last"))
                {
                    if (command.Contains("even"))
                    {
                        elementsCounter = int.Parse(command.Substring(5, command.Length - 9));

                        if (elementsCounter > numArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (elementsCounter > EvenNumbers(numArray).Length)
                            {
                                elementsCounter = EvenNumbers(numArray).Length;
                            }
                            Console.Write("[");
                            if (EvenNumbers(numArray).Length > 0)
                            {
                                Console.Write(string.Join(", ", LastNElements(EvenNumbers(numArray), elementsCounter)));
                            }
                            Console.WriteLine("]");
                        }
                    }
                    else if (command.Contains("odd"))
                    {
                        elementsCounter = int.Parse(command.Substring(5, command.Length - 8));
                        if (elementsCounter > numArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (elementsCounter > OddNumbers(numArray).Length)
                            {
                                elementsCounter = OddNumbers(numArray).Length;
                            }
                            Console.Write("[");
                            if (OddNumbers(numArray).Length > 0)
                            {
                                Console.Write(string.Join(", ", LastNElements(OddNumbers(numArray), elementsCounter)));
                            }
                            Console.WriteLine("]");
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", numArray));
            Console.WriteLine("]");
        }

        private static int[] FirstNElements(int[] arr, int elementsCounter)
        {
            int[] newArr = new int[elementsCounter];
            for (int i = 0; i < elementsCounter; i++)
            {
                newArr[i] = arr[i];
            }
            return newArr;
        }

        private static int[] LastNElements(int[] arr, int elementsCounter)
        {
            int[] newArr = new int[elementsCounter];
            for (int i = elementsCounter - 1; i >= 0; i--)
            {
                newArr[i] = arr[i];
            }
            return newArr;
        }

        private static int[] EvenNumbers(int[] numArray)
        {
            return numArray.Where(x => x % 2 == 0).ToArray();
        }

        private static int[] OddNumbers(int[] numArray)
        {
            return numArray.Where(x => x % 2 != 0).ToArray();
        }

        private static void ExchangeArray(int[] numArray, int index)
        {
            int[] newArray = new int[numArray.Length];

            for (int i = index + 1, j = 0; i < numArray.Length; i++, j++)
            {
                newArray[j] = numArray[i];
            }
            for (int i = 0, j = numArray.Length - index - 1; i <= index; i++, j++)
            {
                newArray[j] = numArray[i];
            }

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = newArray[i];
            }
        }
    }
}