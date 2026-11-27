namespace Homework;

public class MathAssignment : Assignment
{
    private string _section = "";
    private string _problem = "";

    public MathAssignment(string name, string topic, string section, string problem) : base(name, topic)
    {
        _section = section;
        _problem = problem;
    }

    public string GetSection()
    {
        return _section;
    }

    public void SetSection(string section)
    {
        _section = section;
    }

    public string GetProblem()
    {
        return _problem;
    }

    public void SetProblem(string problem)
    {
        _problem = problem;
    }

    public string GetMathSummary()
    {
        return $"Name: {_name} Topic: {_topic} Section: {_section} Problem: {_problem}";
    }

}
