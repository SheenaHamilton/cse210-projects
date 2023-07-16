using System;

public class Running:Activity
{
    private int _distanceMeters;

    public Running(int distanceMeters, DateTime date, int minutes):base(date,minutes)
    {
        _distanceMeters = distanceMeters;
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
