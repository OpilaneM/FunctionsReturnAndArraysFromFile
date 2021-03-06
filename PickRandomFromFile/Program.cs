using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            randomFood = GetRandomFromFile("foods.txt");
            randomDrink = GetRandomFromFile("drinks.txt");
            randomMovie = GetRandomFromFile("movies.txt");
            Console.WriteLine($"Tonight you will have some {randomFood} with some {randomDrink} and watch {randomMovie}");
            Console.Read();
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }
        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\mraud\source\RandomFile\{fileName}";
            string[]dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];
            return randomElement;

        }
    }
}
