using System;
using System.IO;

namespace Week13_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            Console.WriteLine("Enter directory name:");
            string userDirectory = Console.ReadLine();

            string newDirectoryFullPath = @$"{rootDirectory}\{userDirectory}";
            Console.WriteLine(newDirectoryFullPath);
            bool DirectoryExist = Directory.Exists(newDirectoryFullPath);

            Directory.CreateDirectory(newDirectoryFullPath);
            if (DirectoryExist)
            {
                Console.WriteLine($"{userDirectory} already exists in Samples.");

            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {userDirectory} has been created.");
            }

        }
    }
}
