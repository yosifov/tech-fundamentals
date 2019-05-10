namespace TechFundamentals.AssocArrays
{
    using System;
    using System.Collections.Generic;

    class Parking
    {
        public static void Execute()
        {
            var parkingRegistrations = new Dictionary<string, string>();

            int commands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= commands; i++)
            {
                var inputData = Console.ReadLine().Split();

                if (inputData[0] == "register")
                {
                    if (parkingRegistrations.ContainsKey(inputData[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {inputData[2]}");
                    }
                    else
                    {
                        parkingRegistrations[inputData[1]] = inputData[2];
                        Console.WriteLine($"{inputData[1]} registered {inputData[2]} successfully");
                    }
                }
                else if (inputData[0] == "unregister")
                {
                    if (!parkingRegistrations.ContainsKey(inputData[1]))
                    {
                        Console.WriteLine($"ERROR: user {inputData[1]} not found");
                    }
                    else
                    {
                        parkingRegistrations.Remove(inputData[1]);
                        Console.WriteLine($"{inputData[1]} unregistered successfully");
                    }
                }
            }

            foreach (var registration in parkingRegistrations)
            {
                Console.WriteLine($"{registration.Key} => {registration.Value}");
            }
        }
    }
}