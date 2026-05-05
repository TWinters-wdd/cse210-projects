using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2000;
        job1._endYear = 2026;

        job2._jobTitle = "Secretary";
        job2._company = "Apple";
        job2._startYear = 1998;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}