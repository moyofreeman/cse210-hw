using System;
using System.IO;
using System.Collections.Generic; // Required for List<T> collections

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string defaultFile = "myFile.txt";

        // Optional: Auto-load default backup if it exists so entries persist
        if (File.Exists(defaultFile))
        {
            theJournal.LoadFromFile(defaultFile);
        }

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save to a file");
            Console.WriteLine("4. Load from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from 1-5: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Get a random prompt using PromptGenerator
                string randomPrompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\n{randomPrompt}");
                Console.Write("> ");
                string userEntry = Console.ReadLine();
                string theCurrentTime = DateTime.Now.ToShortDateString();

                // Create the new Entry object
                Entry newEntry = new Entry();
                newEntry._date = theCurrentTime;
                newEntry._promptText = randomPrompt;
                newEntry._entryText = userEntry;

                // Add to the journal's entry list
                theJournal._entries.Add(newEntry);

                // Automatically back up/pipe to default storage file
                theJournal.SaveToFile(defaultFile);
                Console.WriteLine("Entry recorded and backed up successfully!");
            }
            else if (choice == "2")
            {
                // Display all entries currently in the journal
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Prompt user for a custom filename and save
                Console.Write("Enter filename to save to (e.g., myJournal.txt): ");
                string customFile = Console.ReadLine();
                theJournal.SaveToFile(customFile);
                Console.WriteLine($"Journal successfully saved to {customFile}!");
            }
            else if (choice == "4")
            {
                // Prompt user for a filename and load entries
                Console.Write("Enter filename to load from: ");
                string loadFile = Console.ReadLine();
                theJournal.LoadFromFile(loadFile);
            }
            else if (choice == "5")
            {
                // Exceeding requirements metadata summary on exit
                Console.WriteLine("\n--- Journal Files Summary ---");
                if (Directory.Exists(Directory.GetCurrentDirectory()))
                {
                    string[] txtFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
                    foreach (string file in txtFiles)
                    {
                        string fileNameOnly = Path.GetFileName(file);
                        DateTime lastModified = File.GetLastWriteTime(file);
                        string[] lines = File.ReadAllLines(file);
                        int entryCount = lines.Length / 3; // 3 lines per entry format

                        Console.WriteLine($"File: {fileNameOnly} | Entries: {entryCount} | Last Modified: {lastModified}");
                    }
                }

                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
            }
        }
    }
}