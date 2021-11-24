using System;
using System.IO;

namespace Ylesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\opilane\samples\kasutajakaust\funfacts.txt";
            string[] dataFromFile = File.ReadAllLines(filepath);
            Console.WriteLine(dataFromFile[0]);
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(RandomLineFromFile());
            }

        }
        private static string RandomLineFromFile()
        {
            string filepath = @"C:\Users\opilane\samples\kasutajakaust\funfacts.txt";
            string[] dataFromFile = File.ReadAllLines(filepath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, dataFromFile.Length);
            return dataFromFile[randomIndex];
        }
    }
}
