using MyFirstProgram.Models;
using System;

namespace MyFirstProgram
{
    internal class Menu
    {
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that your're working on improving yourself\n");

            bool isGameOn = true;

            while (isGameOn)
            {
                Console.WriteLine($@"What game would you like to play? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
R - Random
Q - Quit the program");
                Console.WriteLine("------------------------------------------------");

                var gameSelected = Console.ReadLine().ToLower().Trim();
                Console.Clear();

                switch (gameSelected)
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        InitialData data = Helpers.GetGameData();
                        GameEngine.AdditionGame("Addition Game", data);
                        break;
                    case "s":
                        data = Helpers.GetGameData();
                        GameEngine.SubtractionGame("Subtraction Game", data);
                        break;
                    case "m":
                        data = Helpers.GetGameData();
                        GameEngine.MultiplicationGame("Multiplication Game", data);
                        break;
                    case "d":
                        data = Helpers.GetGameData();
                        GameEngine.DivisionGame("Division Game", data);
                        break;
                    case "r":
                        data = Helpers.GetGameData();
                        GameEngine.RandomGame("Random Game", data);
                        break;
                    case "q":
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
    }
}
