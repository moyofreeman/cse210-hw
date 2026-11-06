using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101); // Updated range from 1 to 100
        // Console.WriteLine($"The random number is {randomNumber}");

        Console.Write("Hi, welcome to the random number game, before we go any further I am Freeman, a BYU student, What is your name?: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Nice meeting you {name}, let us start our little game");

        int guessedNumber = -1;
        int guessCount = 0; // Track the number of guesses

        while (guessedNumber != randomNumber)
        {
            Console.Write("Pick a number between 1 and 100 and press Enter: ");
            guessedNumber = int.Parse(Console.ReadLine());
            guessCount++; // Increment count with each guess

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
                Console.WriteLine($"It took you {guessCount} guesses to find the number."); // Display total guesses
            }
        }
    }
}