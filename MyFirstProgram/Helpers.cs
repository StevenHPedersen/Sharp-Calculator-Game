using Microsoft.VisualBasic;
using MyFirstProgram.Models;
using System.Data.Common;

namespace MyFirstProgram
{

    internal class Helpers
    {
        static List<Game> games = new();
        internal static void AddToHistory(int score, GameType gameType, DifficultyLevel difficultyLevel, int elapsedTime, int numberOfQuestions)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = gameType,
                Difficulty = difficultyLevel,
                NumberOfQuestions = numberOfQuestions,
                Time = elapsedTime
            });
        }
        internal static string GetName()
        {
            Console.WriteLine("Please type your name");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty");
                name = Console.ReadLine();
            }
            return name;
        }
        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("------------------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"Date: {game.Date}, Type: {game.Type}, Score: {game.Score}/{game.NumberOfQuestions}, Difficulty: {game.Difficulty}, Time: {game.Time} seconds");
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press ENTER to return to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }
        internal static string ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                result = Console.ReadLine();
            }

            return result;
        }
        internal static int[] GetNumbers(DifficultyLevel difficulty)
        {
            var random = new Random();
            int[] numbers = new int[2];
            switch (difficulty)
            {
                case DifficultyLevel.EASY:
                    for (int i = 0; i < 2; i++)
                    {
                        numbers[i] = random.Next(1, 10);
                    }
                    return numbers;
                case DifficultyLevel.MEDIUM:
                    for (int i = 0; i < 2; i++)
                    {
                        numbers[i] = random.Next(2, 51);
                    }
                    return numbers;
                case DifficultyLevel.HARD:
                    for (int i = 0; i < 2; i++)
                    {
                        numbers[i] = random.Next(3, 251);
                    }
                    return numbers;
                default:
                    return numbers;
            }
        }
        internal static Models.DifficultyLevel ChooseDifficulty()
        {
            Models.DifficultyLevel selectedDifficulty;
            
                Console.Clear();
                Console.WriteLine($@"Choose a difficulty level:
1 - Easy
2 - Medium
3 - Hard");
                Console.WriteLine("------------------------------------------------");

                var difficulty = Console.ReadLine();
            
            do
            {
                switch (difficulty)
                {
                    case "1":
                        selectedDifficulty = Models.DifficultyLevel.EASY;
                        break;
                    case "2":
                        selectedDifficulty = Models.DifficultyLevel.MEDIUM;
                        break;
                    case "3":
                        selectedDifficulty = Models.DifficultyLevel.HARD;
                        break;
                    default:
                        selectedDifficulty = Models.DifficultyLevel.UNDEFINED;
                        Console.WriteLine("Select from the choices provided");
                        difficulty = Console.ReadLine();
                        break;
                }
            } while (selectedDifficulty == Models.DifficultyLevel.UNDEFINED);

            return selectedDifficulty;
        }
        internal static int[] GetDivisionNumbers(DifficultyLevel difficulty)
        {
            {
                var random = new Random();
                int[] numbers = new int[2];
                switch (difficulty)
                {
                    case DifficultyLevel.EASY:
                        for (int i = 0; i < 2; i++)
                        {
                            numbers[i] = random.Next(1, 10);
                        }
                        while (numbers[0] % numbers[1] != 0)
                        {
                            numbers[0] = random.Next(1, 10);
                            numbers[1] = random.Next(1, 10);
                        }
                        return numbers;
                    case DifficultyLevel.MEDIUM:
                        for (int i = 0; i < 2; i++)
                        {
                            numbers[i] = random.Next(2, 51);
                        }
                        while (numbers[0] % numbers[1] != 0)
                        {
                            numbers[0] = random.Next(2, 51);
                            numbers[1] = random.Next(2, 51);
                        }
                        return numbers;
                    case DifficultyLevel.HARD:
                        for (int i = 0; i < 2; i++)
                        {
                            numbers[i] = random.Next(3, 251);
                        }
                        while (numbers[0] % numbers[1] != 0)
                        {
                            numbers[0] = random.Next(3, 251);
                            numbers[1] = random.Next(3 ,251);
                        }
                        return numbers;
                    default:
                        return numbers;
                }
            }
        }
        internal static DateTime dateTime => DateTime.UtcNow;
        internal static int TimeElapsed(int start, int end)
        {
            int elapsedTime = end - start;
            return elapsedTime;
        }
        internal static int AskForNumber()
        {
            Console.Clear();
            int numberOfQuestions;
            Console.WriteLine("How many questions would you like to answer?");

            numberOfQuestions = int.Parse(ValidateResult(Console.ReadLine()));

            return numberOfQuestions;
        }
        internal static InitialData GetGameData()
        {
            var data = new InitialData();
            data.Difficulty = ChooseDifficulty();
            data.NumberOfQuestions = AskForNumber();
            return data;
        }
    }  
}
