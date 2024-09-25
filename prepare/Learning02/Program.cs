using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Programmer";
        job1._company = "Google";
        job1._startYear = 2018;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Junior Developer";
        job2._company = "IBM";
        job2._startYear = 2021;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Ashley Parson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}

