using System;
using System.IO;

namespace Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to read the file of? You have 2 options: stars.txt or planets.txt");
            string userPlanet = Console.ReadLine();
            string userStar = Console.ReadLine();
            string output = GetLineFromfileData(userStar);
            string outputTwo = GetLineFromfileDataTwo(userPlanet);
            if (output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else if (outputTwo.Length != 0)
            {
                Console.WriteLine(outputTwo);
            }
            else
            {
                Console.WriteLine("file not found");
            }
        }
        private static string[] ReadDataFromFile()
        {
            string directoryPath = @"C:\Users\opilane\kasutajakaust";
            string filename = "stars.txt";
            string fullpath = $@"{directoryPath}\{filename}";
            string[] dataFromFile = File.ReadAllLines(fullpath);
            return dataFromFile;
        }
        private static string[] ReadDataFromFileTwo()
        {
            string directoryPath = @"C:\Users\opilane\kasutajakaust";
            string filename = "planets.txt";
            string fullpath = $@"{directoryPath}\{filename}";
            string[] dataFromFile = File.ReadAllLines(fullpath);
            return dataFromFile;
        }
        private static string GetLineFromfileData(string userStar)
        {
            string[] dataFromFile = ReadDataFromFile();
            string result = "";
            foreach (string line in dataFromFile)
            {
                if (line.Contains(userStar))
                {
                    result = line;
                    break;
                }
            }
            return result;
        }
        private static string GetLineFromfileDataTwo(string userPlanet)
        {
            string[] dataFromFile = ReadDataFromFileTwo();
            string result = "";
            foreach (string line in dataFromFile)
            {
                if (line.Contains(userPlanet))
                {
                    result = line;
                    break;
                }
            }
            return result;
        }
    }
}
