using MyFirstProgram.Models;
using System.Diagnostics;

namespace MyFirstProgram
{
    internal class GameEngine
    {   
        internal static void DivisionGame(string message, InitialData data)
        {
            Stopwatch stopwatch = new Stopwatch();

            var difficulty = data.Difficulty;
            var numberOfQuestions = data.NumberOfQuestions;

            int score = 0;

            switch (difficulty)
            {
                case DifficultyLevel.EASY:
                    stopwatch.Start();

                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message} {DifficultyLevel.EASY} Mode");

                        int[] numbers = Helpers.GetDivisionNumbers(DifficultyLevel.EASY);
                        int firstNumber = numbers[0];
                        int secondNumber = numbers[1];
                        Console.WriteLine($"{firstNumber} / {secondNumber}");
                        var result = Console.ReadLine();

                        result = Helpers.ValidateResult(result);

                        if (int.Parse(result) == firstNumber / secondNumber)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }

                    stopwatch.Stop();
                    Helpers.AddToHistory(score, Models.GameType.Division, DifficultyLevel.EASY, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                case DifficultyLevel.MEDIUM:
                    stopwatch.Start();


                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message} {DifficultyLevel.MEDIUM} Mode");

                        int[] numbers = Helpers.GetDivisionNumbers(DifficultyLevel.MEDIUM);
                        int firstNumber = numbers[0];
                        int secondNumber = numbers[1];
                        Console.WriteLine($"{firstNumber} / {secondNumber}");
                        var result = Console.ReadLine();

                        result = Helpers.ValidateResult(result);

                        if (int.Parse(result) == firstNumber / secondNumber)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();


                    Helpers.AddToHistory(score, Models.GameType.Division, Models.DifficultyLevel.MEDIUM, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                case DifficultyLevel.HARD:
                    stopwatch.Start();

                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message} {DifficultyLevel.HARD} Mode");

                        int[] numbers = Helpers.GetDivisionNumbers(DifficultyLevel.HARD);
                        int firstNumber = numbers[0];
                        int secondNumber = numbers[1];
                        Console.WriteLine($"{firstNumber} / {secondNumber}");
                        var result = Console.ReadLine();

                        result = Helpers.ValidateResult(result);

                        if (int.Parse(result) == firstNumber / secondNumber)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, Models.GameType.Division, Models.DifficultyLevel.HARD, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            Console.WriteLine("Press ENTER to return to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }
        internal static void MultiplicationGame(string message, InitialData data)
        {
            Stopwatch stopwatch = new Stopwatch();

            var difficulty = data.Difficulty;
            var numberOfQuestions = data.NumberOfQuestions;

            int score = 0;

            switch (difficulty)
            {
                case DifficultyLevel.EASY:
                    stopwatch.Start();


                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message} {DifficultyLevel.EASY} Mode");

                        int[] numbers = Helpers.GetNumbers(DifficultyLevel.EASY);
                        int firstNumber = numbers[0];
                        int secondNumber = numbers[1];
                        Console.WriteLine($"{firstNumber} * {secondNumber}");
                        var result = Console.ReadLine();

                        result = Helpers.ValidateResult(result);

                        if (int.Parse(result) == firstNumber * secondNumber)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, Models.GameType.Multiplication, DifficultyLevel.EASY, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                case DifficultyLevel.MEDIUM:
                    stopwatch.Start();


                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message} {DifficultyLevel.MEDIUM} Mode");

                        int[] numbers = Helpers.GetNumbers(DifficultyLevel.MEDIUM);
                        int firstNumber = numbers[0];
                        int secondNumber = numbers[1];
                        Console.WriteLine($"{firstNumber} * {secondNumber}");
                        var result = Console.ReadLine();

                        result = Helpers.ValidateResult(result);

                        if (int.Parse(result) == firstNumber * secondNumber)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, Models.GameType.Multiplication, Models.DifficultyLevel.MEDIUM, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                case DifficultyLevel.HARD:
                    stopwatch.Start();


                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message} {DifficultyLevel.HARD} Mode");

                        int[] numbers = Helpers.GetNumbers(DifficultyLevel.HARD);
                        int firstNumber = numbers[0];
                        int secondNumber = numbers[1];
                        Console.WriteLine($"{firstNumber} * {secondNumber}");
                        var result = Console.ReadLine();

                        result = Helpers.ValidateResult(result);

                        if (int.Parse(result) == firstNumber * secondNumber)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, Models.GameType.Multiplication, Models.DifficultyLevel.HARD, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            Console.WriteLine("Press ENTER to return to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }
        internal static void SubtractionGame(string message, InitialData data)
        {
            Stopwatch stopwatch = new Stopwatch();

            var difficulty = data.Difficulty;
            var numberOfQuestions = data.NumberOfQuestions;

            int score = 0;

            switch (difficulty)
            {
                case DifficultyLevel.EASY:
                    stopwatch.Start();


                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message} {DifficultyLevel.EASY} Mode");

                        int[] numbers = Helpers.GetNumbers(DifficultyLevel.EASY);
                        int firstNumber = numbers[0];
                        int secondNumber = numbers[1];
                        Console.WriteLine($"{firstNumber} - {secondNumber}");
                        var result = Console.ReadLine();

                        result = Helpers.ValidateResult(result);

                        if (int.Parse(result) == firstNumber - secondNumber)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, Models.GameType.Subtraction, DifficultyLevel.EASY, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                case DifficultyLevel.MEDIUM:
                    stopwatch.Start();


                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message} {DifficultyLevel.MEDIUM} Mode");

                        int[] numbers = Helpers.GetNumbers(DifficultyLevel.MEDIUM);
                        int firstNumber = numbers[0];
                        int secondNumber = numbers[1];
                        Console.WriteLine($"{firstNumber} - {secondNumber}");
                        var result = Console.ReadLine();

                        result = Helpers.ValidateResult(result);

                        if (int.Parse(result) == firstNumber - secondNumber)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, Models.GameType.Subtraction, Models.DifficultyLevel.MEDIUM, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                case DifficultyLevel.HARD:
                    stopwatch.Start();


                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message} {DifficultyLevel.HARD} Mode");

                        int[] numbers = Helpers.GetNumbers(DifficultyLevel.HARD);
                        int firstNumber = numbers[0];
                        int secondNumber = numbers[1];
                        Console.WriteLine($"{firstNumber} - {secondNumber}");
                        var result = Console.ReadLine();

                        result = Helpers.ValidateResult(result);

                        if (int.Parse(result) == firstNumber - secondNumber)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, Models.GameType.Subtraction, Models.DifficultyLevel.HARD, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                default:
                    Console.WriteLine("defaul");
                    break;
            }

            Console.WriteLine("Press ENTER to return to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }
        internal static void AdditionGame(string message, InitialData data)
        {
            Stopwatch stopwatch = new Stopwatch();

            var difficulty = data.Difficulty;
            var numberOfQuestions = data.NumberOfQuestions;
            int score = 0; ;

            switch (difficulty)
            {
                case DifficultyLevel.EASY:
                    stopwatch.Start();

                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message} {DifficultyLevel.EASY} Mode");

                        int[] numbers = Helpers.GetNumbers(DifficultyLevel.EASY);
                        int firstNumber = numbers[0];
                        int secondNumber = numbers[1];
                        Console.WriteLine($"{firstNumber} + {secondNumber}");
                        var result = Console.ReadLine();

                        result = Helpers.ValidateResult(result);

                        if (int.Parse(result) == firstNumber + secondNumber)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, GameType.Addition, DifficultyLevel.EASY, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                case DifficultyLevel.MEDIUM:
                    stopwatch.Start();


                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message} {DifficultyLevel.MEDIUM} Mode");

                        int[] numbers = Helpers.GetNumbers(DifficultyLevel.MEDIUM);
                        int firstNumber = numbers[0];
                        int secondNumber = numbers[1];
                        Console.WriteLine($"{firstNumber} + {secondNumber}");
                        var result = Console.ReadLine();

                        result = Helpers.ValidateResult(result);

                        if (int.Parse(result) == firstNumber + secondNumber)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, Models.GameType.Addition, Models.DifficultyLevel.MEDIUM, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                case DifficultyLevel.HARD:
                    stopwatch.Start();


                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message} {DifficultyLevel.HARD} Mode");

                        int[] numbers = Helpers.GetNumbers(DifficultyLevel.HARD);
                        int firstNumber = numbers[0];
                        int secondNumber = numbers[1];
                        Console.WriteLine($"{firstNumber} + {secondNumber}");
                        var result = Console.ReadLine();

                        result = Helpers.ValidateResult(result);

                        if (int.Parse(result) == firstNumber + secondNumber)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect!");
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, Models.GameType.Addition, DifficultyLevel.HARD, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                default:
                    Console.WriteLine("defaul");
                    break;
            }

            Console.WriteLine("Press ENTER to return to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }
        internal static void RandomGame(string message, InitialData data)
        {
            Random random = new Random();
            Stopwatch stopwatch = new Stopwatch();

            var difficulty = data.Difficulty;
            var numberOfQuestions = data.NumberOfQuestions;
            int score = 0;

            switch (difficulty)
            {
                case DifficultyLevel.EASY:
                    stopwatch.Start();

                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message}: {difficulty} Mode");

                        int randomNumber = random.Next(1, 5);
                        switch (randomNumber)
                        {
                            case 1:
                                int[] numbers = Helpers.GetNumbers(difficulty);
                                int firstNumber = numbers[0];
                                int secondNumber = numbers[1];
                                Console.WriteLine($"{firstNumber} + {secondNumber}");
                                var result = Console.ReadLine();

                                result = Helpers.ValidateResult(result);
                                if (int.Parse(result) == firstNumber + secondNumber)
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect!");
                                }
                                break;
                            case 2:
                                numbers = Helpers.GetNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];
                                Console.WriteLine($"{firstNumber} - {secondNumber}");
                                result = Console.ReadLine();

                                result = Helpers.ValidateResult(result);
                                if (int.Parse(result) == firstNumber - secondNumber)
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect!");
                                }
                                break;
                            case 3:
                                numbers = Helpers.GetNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];
                                Console.WriteLine($"{firstNumber} x {secondNumber}");
                                result = Console.ReadLine();

                                result = Helpers.ValidateResult(result);
                                if (int.Parse(result) == firstNumber * secondNumber)
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect!");
                                }
                                break;
                            case 4:
                                numbers = Helpers.GetDivisionNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];
                                Console.WriteLine($"{firstNumber} / {secondNumber}");
                                result = Console.ReadLine();

                                result = Helpers.ValidateResult(result);
                                if (int.Parse(result) == firstNumber / secondNumber)
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect!");
                                }
                                break;
                        }
                        
                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, GameType.Random, difficulty, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                case DifficultyLevel.MEDIUM:
                    stopwatch.Start();


                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message}: {difficulty} Mode");

                        int randomNumber = random.Next(1, 5);
                        switch (randomNumber)
                        {
                            case 1:
                                int[] numbers = Helpers.GetNumbers(difficulty);
                                int firstNumber = numbers[0];
                                int secondNumber = numbers[1];
                                Console.WriteLine($"{firstNumber} + {secondNumber}");
                                var result = Console.ReadLine();

                                result = Helpers.ValidateResult(result);
                                if (int.Parse(result) == firstNumber + secondNumber)
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect!");
                                }
                                break;
                            case 2:
                                numbers = Helpers.GetNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];
                                Console.WriteLine($"{firstNumber} - {secondNumber}");
                                result = Console.ReadLine();

                                result = Helpers.ValidateResult(result);
                                if (int.Parse(result) == firstNumber - secondNumber)
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect!");
                                }
                                break;
                            case 3:
                                numbers = Helpers.GetNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];
                                Console.WriteLine($"{firstNumber} x {secondNumber}");
                                result = Console.ReadLine();

                                result = Helpers.ValidateResult(result);
                                if (int.Parse(result) == firstNumber * secondNumber)
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect!");
                                }
                                break;
                            case 4:
                                numbers = Helpers.GetDivisionNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];
                                Console.WriteLine($"{firstNumber} / {secondNumber}");
                                result = Console.ReadLine();

                                result = Helpers.ValidateResult(result);
                                if (int.Parse(result) == firstNumber / secondNumber)
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect!");
                                }
                                break;
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, GameType.Random, difficulty, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                case DifficultyLevel.HARD:
                    stopwatch.Start();

                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{message}: {difficulty} Mode");

                        int randomNumber = random.Next(1, 5);
                        switch (randomNumber)
                        {
                            case 1:
                                int[] numbers = Helpers.GetNumbers(difficulty);
                                int firstNumber = numbers[0];
                                int secondNumber = numbers[1];
                                Console.WriteLine($"{firstNumber} + {secondNumber}");
                                var result = Console.ReadLine();

                                result = Helpers.ValidateResult(result);
                                if (int.Parse(result) == firstNumber + secondNumber)
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect!");
                                }
                                break;
                            case 2:
                                numbers = Helpers.GetNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];
                                Console.WriteLine($"{firstNumber} - {secondNumber}");
                                result = Console.ReadLine();

                                result = Helpers.ValidateResult(result);
                                if (int.Parse(result) == firstNumber - secondNumber)
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect!");
                                }
                                break;
                            case 3:
                                numbers = Helpers.GetNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];
                                Console.WriteLine($"{firstNumber} x {secondNumber}");
                                result = Console.ReadLine();

                                result = Helpers.ValidateResult(result);
                                if (int.Parse(result) == firstNumber * secondNumber)
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect!");
                                }
                                break;
                            case 4:
                                numbers = Helpers.GetDivisionNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];
                                Console.WriteLine($"{firstNumber} / {secondNumber}");
                                result = Console.ReadLine();

                                result = Helpers.ValidateResult(result);
                                if (int.Parse(result) == firstNumber / secondNumber)
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect!");
                                }
                                break;
                        }

                        if (i == (numberOfQuestions - 1))
                        {
                            Console.WriteLine($"Game Over. Your final score is {score}\n");
                            break;
                        }

                        Console.WriteLine("Press ENTER for the next question");
                        Console.ReadLine();
                    }
                    stopwatch.Stop();

                    Helpers.AddToHistory(score, GameType.Random, difficulty, stopwatch.Elapsed.Seconds, numberOfQuestions);
                    break;
                default:
                    Console.WriteLine("defaul");
                    break;
            }

            Console.WriteLine("Press ENTER to return to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }

    }
}

