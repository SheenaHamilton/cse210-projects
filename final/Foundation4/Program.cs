using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Cycling newCycling1 = new Cycling(22.5,DateTime.Parse("2023/07/30"),20);
        Cycling newCycling2 = new Cycling(18.2,DateTime.Parse("2023/04/23"),30);

        Running newRunning1 = new Running(4800,DateTime.Parse("2023/05/18"),30);
        Running newRunning2 = new Running(1503,DateTime.Parse("2023/05/20"),27);


        Swimming newSwimming1 = new Swimming(14,DateTime.Parse("2023/05/18"),5);
        Swimming newSwimming2 = new Swimming(20,DateTime.Parse("2023/05/20"),6);

        activities.Add(newCycling1);
        activities.Add(newCycling2);
        activities.Add(newRunning1);
        activities.Add(newRunning2);
        activities.Add(newSwimming1);
        activities.Add(newSwimming2);

        Console.Clear();

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary(act.GetType().ToString()));
        }
    }
}