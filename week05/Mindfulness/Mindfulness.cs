namespace Mindfulness;

// Base class: everything the three activities have in common lives here.
public abstract class Mindfulness
{
    protected string _name;
    protected string _description;
    protected int _duration; // in seconds

    public Mindfulness(string name, string description, int duration = 30)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Each derived class runs differently, so the base class only declares it.
    public abstract void Run();

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = ReadPositiveInt();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    // Shows a rotating spinner for the given number of seconds.
    public void ShowSpinner(int seconds)
    {
        List<string> frames = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i]);
            Thread.Sleep(250);
            Console.Write("\b \b"); // erase the frame
            i = (i + 1) % frames.Count;
        }
    }

    // Counts down on a single spot on the screen, e.g. 5 4 3 2 1.
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string text = i.ToString();
            Console.Write(text);
            Thread.Sleep(1000);
            // erase every digit (handles 10, 11, ... too)
            Console.Write(new string('\b', text.Length) + new string(' ', text.Length) + new string('\b', text.Length));
        }
    }

    // Keeps asking until the user types a whole number greater than 0.
    protected int ReadPositiveInt()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.Write("Please enter a whole number greater than 0: ");
        }
        return value;
    }
}