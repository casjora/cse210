using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company="IntouchCx";
        job1._endYear=2024;
        job1._startYear = 2018;
        job1._jobTitle="QA Supervisor";

        Job job2 = new Job();
        job2._company="ICC";
        job2._endYear=2028;
        job2._startYear = 2024;
        job2._jobTitle="QA Coordinator";

        Resume myResume = new Resume();
        myResume._name="Rafael Lopez";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}