namespace TechFundamentals.Exams.MidExam041118
{
    using System;
    using System.Linq;

    class QuestsJournal
    {
        public static void Execute()
        {
            var quests = Console.ReadLine().Split(", ").ToList();
            var input = Console.ReadLine().Split(" - ");
            while (input[0].ToLower() != "retire!")
            {
                string command = input[0];
                string quest = input[1];

                if (command.ToLower() == "start" && !quests.Contains(quest))
                {
                    quests.Add(quest);
                }
                else if (command.ToLower() == "complete" && quests.Contains(quest))
                {
                    quests.Remove(quest);
                }
                else if (command.ToLower() == "side quest")
                {
                    var existingQuest = quest.Split(":")[0];
                    var sideQuest = quest.Split(":")[1];
                    if (quests.Contains(existingQuest) && !quests.Contains(sideQuest))
                    {
                        if (quests.IndexOf(existingQuest) == quests.Count - 1)
                        {
                            quests.Add(sideQuest);
                        }
                        else
                        {
                            quests.Insert(quests.IndexOf(existingQuest) + 1, sideQuest);
                        }
                    }
                }
                else if (command.ToLower() == "renew")
                {
                    if (quests.Contains(quest))
                    {
                        quests.Remove(quest);
                        quests.Add(quest);
                    }
                }

                input = Console.ReadLine().Split(" - ");
            }
            if (quests.Count > 0)
            {
                Console.WriteLine(string.Join(", ", quests));
            }
        }
    }
}
