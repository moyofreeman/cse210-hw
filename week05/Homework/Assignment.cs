namespace Homework;

public class Assignment
{
    protected string _name = "";
    protected string _topic = "";

    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;

    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }


    public string GetTopic()
    {
        return _topic;
    }
    
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"Name: {_name} Topic: {_topic}";
    }

}
