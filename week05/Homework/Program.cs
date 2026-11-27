using System;
using Homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignmentFreeman = new Assignment("Freeman", "Cytology");

        Console.WriteLine(assignmentFreeman.GetSummary());


        MathAssignment assignmentGoodwill = new MathAssignment("Goodwill", "Algebra", "5", "Intro");
        Console.WriteLine(assignmentGoodwill.GetMathSummary());

        WritingAssignment assignmentRee = new WritingAssignment("Ree",
        "Atoms",
        "Bohr"
        );

        Console.WriteLine(assignmentRee.GetWritingSummary());
    }
}