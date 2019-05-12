namespace TechFundamentals.Strings
{
    using System;

    class ExtractFile
    {
        public static void Execute()
        {
            string fullPath = Console.ReadLine();

            string file = fullPath.Substring(fullPath.LastIndexOf(@"\") + 1);
            string fileName = file.Split(".")[0];
            string fileExtension = file.Split(".")[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}