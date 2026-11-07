using System;
using System.Collections.Generic;

public class PromptGenerator
// Responsibility: Holds the list of default prompt strings and randomly picks and return a random one when requested.
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();

        // Generate a random index from 0 up to the count of the list
        int index = random.Next(_prompts.Count);

        // Return the prompt at that random index
        return _prompts[index];

    }
}