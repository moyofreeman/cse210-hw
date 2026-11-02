using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, 101);
        // Console.WriteLine($"The random number is {randomNumber}");

        Console.Write("Hi, welcome to the random number game, before we go any further I am Freeman, a BYU student, What is your name?: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Nice meeting you {name}, let us start our little game");
        Console.Write("Kindly pick any random number between 0 and 100 and enter it on the console, and press the enter key: ");
        int guessedNumber = -1;

        while (guessedNumber != randomNumber)
        {
            Console.Write("Pick a number between 0 and 100 and press Enter: ");
            guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessedNumber > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}