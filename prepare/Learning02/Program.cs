using System;


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Programmer";
        job1._company = "Valcura International";
        job1._startYear = 1999;
        job1._endYear = 2003;


        Job job2 = new Job();
        job2._jobTitle = "Consultant";
        job2._company = "CriticalControl Solutions";
        job2._startYear = 2003;
        job2._endYear = 2009;


        Resume myResume = new Resume();
        myResume._name = "Sheena Hamilton";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}