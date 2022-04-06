using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayRandomMovie
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();

            Console.Read();



        }
        private static void DisplayRandomFood()
        {
            string[] foods = { "Sushi", "Salat", "Kala", "Täna sa nälgid", "Juust" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);


            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked : {randomFood}");
        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "Fanta", "Beer", "Sprite", "Kali", "Klaas vett" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);


            string randomDrinks = drinks[randomIndex];
            Console.WriteLine($"Computer picked : {randomDrinks}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Simpsons", "Tõde ja Õigus", "The Conjouring", "Vaata aknast välja", "Titanic" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);


            string randomMovies = movies[randomIndex];
            Console.WriteLine($"Computer picked : {randomMovies}");
        }
    }
}
