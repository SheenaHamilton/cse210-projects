using System;

public class Swimming:Activity
{
    private int _laps;

    public Swimming(int laps, DateTime date, int minutes):base(date,minutes)
    {
        _laps = laps;
    }

    public override double DistanceKM()
    {
        return 0;
    }

    public override double SpeedKMH()
    {
        return 0;
    }

    public override double PaceKM()
    {
        return 0;
    }
}
