using System;

public class Cycling:Activity
{
    private double _speedKMH;

    public Cycling(double speedKMH, DateTime date, int minutes):base(date,minutes)
    {
        _speedKMH = speedKMH;
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
