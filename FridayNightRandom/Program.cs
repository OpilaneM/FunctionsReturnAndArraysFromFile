using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
            Console.Read();

        }


        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;

        }
        private static void DisplayRandomFood()

        {
            string[] foods = { "Sushi", "Salat", "Kala", "Täna sa nälgid", "Juust" };
            Console.WriteLine($"Computer picked : {foods[GenerateRandomIndex(foods)]}");
        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "Fanta", "Beer", "Sprite", "Kali", "Klaas vett" };

            Console.WriteLine($"Computer picked : {drinks[GenerateRandomIndex(drinks)]}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Simpsons", "Tõde ja Õigus", "The Conjouring", "Vaata aknast välja", "Titanic" };

            Console.WriteLine($"Computer picked : {movies[GenerateRandomIndex(movies)]}");
        }
    }
}

    

