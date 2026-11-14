using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("Psalms", 91, 1, 2);

        string text = "He who dwells in the shelter of the Most High Will abide in the shadow of the Almighty. I will say to the LORD, “My refuge and my fortress, My God, in whom I trust!";
        Scripture scripture = new Scripture(reference, text);


        string userInput = "";

        while (userInput != "q")
        {
            
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

           
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden! Great job memorizing.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words, or type 'q' to exit:");
            userInput = Console.ReadLine().Trim().ToLower();

            if (userInput == "")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.WriteLine("Goodbye!");
    }
}