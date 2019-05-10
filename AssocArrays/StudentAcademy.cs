namespace TechFundamentals.AssocArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentAcademy
    {
        public static void Execute()
        {
            var studentsGrades = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(studentName))
                {
                    studentsGrades[studentName] = new List<double>();
                }
                studentsGrades[studentName].Add(studentGrade);
            }

            studentsGrades = studentsGrades.Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in studentsGrades)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
            }
        }
    }
}
