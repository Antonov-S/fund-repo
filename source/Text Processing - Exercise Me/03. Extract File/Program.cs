using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int startingIndexOfFileName = input.LastIndexOf('\\');
            int endingIndexOfFileExtension = input.LastIndexOf('.');

            string fileName = input.Substring(startingIndexOfFileName + 1, endingIndexOfFileExtension - startingIndexOfFileName - 1);
            string fileExtension = input.Substring(endingIndexOfFileExtension + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
