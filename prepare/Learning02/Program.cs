using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new Job();
        job1._jobTitle = "Support Engineer";
        job1._company = "SAP";
        job1._startYear = 2019;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "SAP";
        job2._startYear = 2025;
        job2._endYear = 2030;

        Resume myResume = new Resume();
        myResume._name = "Cristiano Machado";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}