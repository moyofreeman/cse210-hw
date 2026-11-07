public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        // Will change later and write to file
        Console.WriteLine($"Date: {_date} - Journal Prompt: {_promptText}");
        Console.WriteLine($"Journal Entry: {_entryText}\n");
    }


}