using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Teacher";
        job1._company = "Northcote Academy";
        job1._startYear = 2026;
        job1._endYear = 2027;



        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "MTC Namibia";
        job2._startYear = 2028;
        job2._endYear = 2030;


        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "Freeman Moyo";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResumes();


        
    }
}