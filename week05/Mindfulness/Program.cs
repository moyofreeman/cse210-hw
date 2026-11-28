using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Project.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start listing activity");
            Console.WriteLine("  3. Start reflecting activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string? choice = Console.ReadLine();
            Mindfulness.Mindfulness? activity = null;

            switch (choice)
            {
                case "1":
                    activity = new Breathing();
                    break;
                case "2":
                    activity = new Listing();
                    break;
                case "3":
                    activity = new Reflection();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press enter to try again.");
                    Console.ReadLine();
                    break;
            }

            // Polymorphism preview: the same call runs a different Run() for each activity.
            activity?.Run();
        }

        Console.WriteLine("Goodbye!");
    }
}