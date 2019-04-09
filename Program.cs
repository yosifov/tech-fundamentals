using System;

namespace TechFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntroAndBasicSyntaxLab.Tasks();
            //IntroAndBasicSyntaxExercise.Tasks();
            //DataTypesAndVariablesLab.Tasks();
            //ArraysExercise.Tasks();
            //MethodsLab.Tasks();
            Console.Write("Enter Max Number: ");
            int maxNumber = int.Parse(Console.ReadLine());
            Methods.PrintingTriangle.PrintTriangle(maxNumber);
            Methods.PrintingTriangle.PrintReverseTriangle(maxNumber - 1);
        }
    }
}
