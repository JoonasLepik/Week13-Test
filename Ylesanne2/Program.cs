using System;
using System.IO;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\kasutajakaust";
            Console.WriteLine("Enter File Name:");
            string userStars = "stars.txt";
            string userPlanets = "planets.txt";
            string fullStarsPath = $@"{rootDirectory}\{userStars}";
            string fullPlanetsPath = $@"{rootDirectory}\{userPlanets}";
            string fileName = Console.ReadLine();
            string fullFilePath = $@"{rootDirectory}\{fileName}.txt";
            bool directoryExist = Directory.Exists(rootDirectory);            
            bool fileExists = File.Exists(fullFilePath);
            if (directoryExist && fileExists)
            {
                Console.WriteLine($"File {fileName} already exist in {rootDirectory}.");
            }
            else
            {
                Console.WriteLine($"Directory kautajakaust and files stars and planets directory does not exist.");
                Directory.CreateDirectory(rootDirectory);
                File.Create(fullPlanetsPath);
                File.Create(fullStarsPath);
                Console.WriteLine($"File {fullStarsPath}.txt, File {fullPlanetsPath}.txt and {rootDirectory} folder has been created.");
            }
        }

      
    }
}
