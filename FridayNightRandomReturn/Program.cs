using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;

            string[] foods = { "Sushi", "Salat", "Kala", "Täna sa nälgid", "Juust" };
            string[] drinks = { "Fanta", "Beer", "Sprite", "Kali", "Klaas vett" };
            string[] movies = { "Simpsons", "Tõde ja Õigus", "The Conjouring", "Vaata aknast välja", "Titanic" };

            randomFood = PickRandomElementFromArray(foods);
            randomFood = PickRandomElementFromArray(drinks);
            randomFood = PickRandomElementFromArray(movies);
            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}");

        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;

        }
        
        private static string PickRandomElementFromArray(string[] someArray)
        {
        string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;
        }
        
    }  
}
