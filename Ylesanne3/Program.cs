using System;
using System.IO;

namespace Ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string milkyPath = @"C:\Users\opilane\samples\kasutajakaust\MilkyWay.txt";
            string planetPath = @"C:\Users\opilane\samples\kasutajakaust\planets.txt";
            string starPath = @"C:\Users\opilane\samples\kasutajakaust\stars.txt";
            string[] milkyData = File.ReadAllLines(milkyPath);
            string[] planetData = File.ReadAllLines(planetPath);
            string[] starData = File.ReadAllLines(starPath);            
            File.WriteAllLines(planetPath, milkyData);
            File.WriteAllLines(starPath, milkyData);
        }
        private static string[] ReadDataFromFile()
        {
            string directoryPath = @"C:\Users\opilane\samples\kasutajakaust\";
            string filename = "MilkyWay.txt";
            string fullpath = $@"{directoryPath}\{filename}";
            string[] dataFromFile = File.ReadAllLines(fullpath);
            return dataFromFile;
        }       
        private static string GetLineFromFileData(string milkypathOne)
        {
            string[] dataFromFile = ReadDataFromFile();
            string result = "star";
            foreach (string line in dataFromFile)
            {
                if (line.Contains("star"))
                {
                    result = line;
                    break;
                }

            }
            return result;
        }
        private static string GetLineFromFileDataTwo(string milkyPathTwo)
        {
            string[] dataFromFile = ReadDataFromFile();          
            string result = "planet";
            foreach (string line in dataFromFile)
            {
                if (line.Contains("planet"))
                {
                    result = line;
                    break;
                }

            }
            return result;
        }
    }
}
