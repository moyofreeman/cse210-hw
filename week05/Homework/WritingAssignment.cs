namespace Homework;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }
    
    public string GetWritingSummary()
    {
        return $"{GetSummary()}, Title: {_title}";
    }
}
