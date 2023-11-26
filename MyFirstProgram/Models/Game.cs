using System.Runtime.CompilerServices;

namespace MyFirstProgram.Models;

internal class Game
{
    internal DateTime Date { get; set; }
    internal int Score { get; set; }
    internal GameType Type { get; set; }
    internal DifficultyLevel Difficulty { get; set; }
    internal int Time { get; set; }
    internal int NumberOfQuestions { get; set; }
}

internal class InitialData
{
    internal DifficultyLevel Difficulty { get; set; }
    internal int NumberOfQuestions { get; set; }
}
internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Random
}

internal enum DifficultyLevel
{
    EASY,
    MEDIUM,
    HARD,
    UNDEFINED
}
