public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>()
    {

    };

    public void DisplayAll()
    {
        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        // Using the 'file' parameter passed in rather than a hardcoded string
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // You can add text to the file with the WriteLine method
            // outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
            // string color = "Blue";
            // outputFile.WriteLine($"My favorite color is {color}");

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // Using the 'file' parameter passed in
        if (File.Exists(file))
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            _entries.Clear(); // Clear current list to load fresh data

            for (int i = 0; i < lines.Length; i += 3)
            {
                if (i + 2 < lines.Length)
                {
                    Entry entry = new Entry();
                    entry._date = lines[i];
                    entry._promptText = lines[i + 1];
                    entry._entryText = lines[i + 2];
                    _entries.Add(entry);
                }
            }
        }

        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split(",");

        //     string firstName = parts[0];
        //     string lastName = parts[1];
        // }
    }
}