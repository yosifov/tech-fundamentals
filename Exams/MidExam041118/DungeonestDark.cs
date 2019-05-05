namespace TechFundamentals.Exams.MidExam041118
{
    using System;
    using System.Linq;

    class DungeonestDark
    {
        public static void Execute()
        {
            int health = 100;
            int coins = 0;
            var rooms = Console.ReadLine().Split("|");

            for (int i = 0; i < rooms.Length; i++)
            {
                string roomObject = rooms[i].Split()[0];
                int objectPoints = int.Parse(rooms[i].Split()[1]);

                if (roomObject == "potion")
                {
                    if (health + objectPoints > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {objectPoints} hp.");
                        health += objectPoints;
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (roomObject == "chest")
                {
                    coins += objectPoints;
                    Console.WriteLine($"You found {objectPoints} coins.");
                }
                else
                {
                    health -= objectPoints;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {roomObject}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {roomObject}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                }
            }
            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
