using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 11);
        Console.WriteLine($"The random number is {randomNumber}");

        Console.Write("Hie, welocme to the random number game, before we go any further I am Freeman, a BYU student, What is your name?: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Nice meeting you {name}, let us start our little game");
        Console.Write("Kindly pick any random number between 1 and 11 and enter it on the console, and press the enter key: ");
        int guessedNumber = 0;

        while (guessedNumber != randomNumber)
        {
            Console.Write("Pick a number between 1 and 10 and press Enter: ");
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