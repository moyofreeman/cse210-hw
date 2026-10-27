using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string letter = " ";

        // Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Hi, how are you, I want to compute your grades symbol");
        Console.Write("Before I proceed, kindly write your name on the prompt, and press enter: ");
        string name = Console.ReadLine();
        Console.Write($"That is nice {name}, kindly input your mark, and press enter: ");
        string rawMark = Console.ReadLine();
        int mark = int.Parse(rawMark);

        if (mark > 90)
        {
            letter = "A";
            // Console.WriteLine($"Woow, {name} this is amazing, you got yourself an A");
        }
        else if (mark > 80)
        {
            // Console.WriteLine($"This is amazing {name}, you got yourself an B");
            letter = "B";
        }

        else if (mark > 70)
        {
            // Console.WriteLine($"Nice trial, I appreciate the effort {name}, you got yourself an C");
            letter = "C";
        }

        else if (mark > 60)
        {
            // Console.WriteLine($"You did not do so well {name}, you got yourself an D");
            letter = "D";
        }


        else
        {
            // Console.WriteLine($"Oh, that's a bad sad {name}, you got an F, try next time");
            letter = "F";
        }

        Console.WriteLine($"{name}, your grade is {letter}");

        if (letter != "F")
        {
            Console.WriteLine($"Congrats, {name}, you passed");
        }

        else
        {
            Console.WriteLine($"Sorry {name}, please try again next time");
        }
    }
}