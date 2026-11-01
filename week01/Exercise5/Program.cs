using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hi, welcome to my square number program, I want to try calculate the square of your number, I am Freeman, a BYU student.");
    }

    static string PromptUserName()
    {
        Console.Write("Before we go any further, what is your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Kindly enter your favorite number, and press enter: ");
        string rawNumber = Console.ReadLine();
        int number = int.Parse(rawNumber);

        return number;
    }

    static int SquareNumber(int number)
    {
        // Squaring a number means multiplying it by itself
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Nice meeting you {name}, the square of your number is {square}, it was nice meeting you Pal, please do wish me all the best, till next time, take care!!!!!!!!!");
    }
}