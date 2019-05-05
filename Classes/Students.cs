namespace TechFundamentals.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }

        public static void Execute()
        {
            int studentsCount = int.Parse(Console.ReadLine());
            var students = new List<Students>();

            for (int i = 0; i < studentsCount; i++)
            {
                var input = Console.ReadLine().Split();
                
                var firstName = input[0];
                var lastName = input[1];
                var grade = input[2];

                students.Add(new Students(firstName, lastName, double.Parse(grade)));
            }

            var orderedStudents = new List<Students>();
            orderedStudents = students.OrderByDescending(o => o.Grade).ToList();

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
