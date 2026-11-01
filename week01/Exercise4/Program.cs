using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.Write("Hi, welcome to my number list program, I am Freeman, a BYU student. What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine($"Nice meeting you {name}, let us build a list of numbers.");

        List<int> numberList = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Kindly enter a number (type 0 to quit), and press enter: ");
            string rawNumber = Console.ReadLine();
            userNumber = int.Parse(rawNumber);

            // 0 is only the signal to stop, so it must not go into the list
            if (userNumber != 0)
            {
                numberList.Add(userNumber);
            }
        }

        if (numberList.Count == 0)
        {
            Console.WriteLine($"{name}, you did not enter any numbers, so there is nothing to compute.");
        }
        else
        {
            // Part 1: the sum
            int sum = 0;
            foreach (int number in numberList)
            {
                sum = sum + number;
            }
            Console.WriteLine($"{name}, the sum is: {sum}");

            // Part 2: the average (cast to float first, otherwise C# drops the decimals)
            float average = (float)sum / numberList.Count;
            Console.WriteLine($"The average is: {average}");

            // Part 3: the largest number
            int max = numberList[0];
            foreach (int number in numberList)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is: {max}");
        }
    }
}