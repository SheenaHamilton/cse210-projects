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
         return (Convert.ToDouble(_distanceMeters)/1000);
    }

    public override double SpeedKMH()
    {
        return (((Convert.ToDouble(_distanceMeters) / GetMinutesAsDbl()) * 60 )/1000);
    }

    public override double PaceKM()
    {
        return (60 /SpeedKMH());
    }
}
