namespace TechFundamentals.Methods
{
    using System;
    using System.Linq;
    using System.Text;

    class ArrayManipulator
    {
        public static void Execute()
        {
            string initNumbers = Console.ReadLine();
            string[] numArray = initNumbers.Split(" ");
            string command = Console.ReadLine();
            int elementsCounter = 0;
            while (command.ToLower() != "end")
            {
                if (command.ToLower().Contains("exchange"))
                {
                    int index = int.Parse(command.Substring(9));
                    if (index >= numArray.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ExchangeArray(numArray, index);
                    }
                }
                if (command.ToLower().Contains("max"))
                {
                    if (command.ToLower().Contains("odd"))
                    {
                        if (OddNumbers(numArray) != null)
                        {
                            Console.WriteLine(Array.IndexOf(numArray, OddNumbers(numArray).Max().ToString()));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (command.ToLower().Contains("even"))
                    {
                        if (EvenNumbers(numArray) != null)
                        {
                            Console.WriteLine(Array.IndexOf(numArray, EvenNumbers(numArray).Max().ToString()));
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
                if (command.ToLower().Contains("min"))
                {
                    if (command.ToLower().Contains("odd"))
                    {
                        if (OddNumbers(numArray) != null)
                        {
                            Console.WriteLine(Array.IndexOf(numArray, OddNumbers(numArray).Min().ToString()));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (command.ToLower().Contains("even"))
                    {
                        if (EvenNumbers(numArray) != null)
                        {
                            Console.WriteLine(Array.IndexOf(numArray, EvenNumbers(numArray).Min().ToString()));
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
                if (command.ToLower().Contains("first"))
                {
                    if (command.ToLower().Contains("even"))
                    {
                        elementsCounter = int.Parse(command.Substring(5, command.Length - 9));
                        if (elementsCounter > numArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else if (EvenNumbers(numArray) == null)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            if (elementsCounter > EvenNumbers(numArray).Length)
                            {
                                elementsCounter = EvenNumbers(numArray).Length;
                            }
                            Console.Write("[");
                            Console.Write(string.Join(", ", FirstNElements(EvenNumbers(numArray), elementsCounter)));
                            Console.WriteLine("]");
                        }
                    }
                    else if (command.ToLower().Contains("odd"))
                    {
                        elementsCounter = int.Parse(command.Substring(5, command.Length - 8));
                        if (elementsCounter > numArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else if (OddNumbers(numArray) == null)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            if (elementsCounter > OddNumbers(numArray).Length)
                            {
                                elementsCounter = OddNumbers(numArray).Length;
                            }
                            Console.Write("[");
                            Console.Write(string.Join(", ", FirstNElements(OddNumbers(numArray), elementsCounter)));
                            Console.WriteLine("]");
                        }
                    }
                }
                if (command.ToLower().Contains("last"))
                {
                    if (command.ToLower().Contains("even"))
                    {
                        elementsCounter = int.Parse(command.Substring(5, command.Length - 9));
                        if (elementsCounter > numArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else if (EvenNumbers(numArray) == null)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            if (elementsCounter > EvenNumbers(numArray).Length)
                            {
                                elementsCounter = EvenNumbers(numArray).Length;
                            }
                            Console.Write("[");
                            Console.Write(string.Join(", ", LastNElements(EvenNumbers(numArray), elementsCounter)));
                            Console.WriteLine("]");
                        }
                    }
                    else if (command.ToLower().Contains("odd"))
                    {
                        elementsCounter = int.Parse(command.Substring(5, command.Length - 8));
                        if (elementsCounter > numArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else if (OddNumbers(numArray) == null)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            if (elementsCounter > OddNumbers(numArray).Length)
                            {
                                elementsCounter = OddNumbers(numArray).Length;
                            }
                            Console.Write("[");
                            Console.Write(string.Join(", ", LastNElements(OddNumbers(numArray), elementsCounter)));
                            Console.WriteLine("]");
                        }
                    }
                }
                command = Console.ReadLine();
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

        private static int[] EvenNumbers(string[] numArray)
        {
            int evenCounter = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                if (int.Parse(numArray[i]) % 2 == 0)
                {
                    evenCounter++;
                }
            }
            if (evenCounter > 0)
            {
                int[] evenArr = new int[evenCounter];
                for (int i = 0; i < numArray.Length; i++)
                {
                    if (int.Parse(numArray[i]) % 2 == 0)
                    {
                        evenArr[evenCounter - 1] = int.Parse(numArray[i]);
                        evenCounter--;
                    }
                }
                Array.Reverse(evenArr);
                return evenArr;
            }
            else
            {
                return null;
            }
        }

        private static int[] OddNumbers(string[] numArray)
        {
            int oddCounter = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                if (int.Parse(numArray[i]) % 2 != 0)
                {
                    oddCounter++;
                }
            }
            if (oddCounter > 0)
            {
                int[] oddArr = new int[oddCounter];
                for (int i = 0; i < numArray.Length; i++)
                {
                    if (int.Parse(numArray[i]) % 2 != 0)
                    {
                        oddArr[oddCounter - 1] = int.Parse(numArray[i]);
                        oddCounter--;
                    }
                }
                Array.Reverse(oddArr);
                return oddArr;
            }
            else
            {
                return null;
            }
        }

        private static void ExchangeArray(string[] numArray, int index)
        {
            string[] newArray = new string[numArray.Length];

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
