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
        return ((_speedKMH/ 60) * GetMinutesAsDbl());
    }

    public override double SpeedKMH()
    {
        return _speedKMH;
    }

    public override double PaceKM()
    {
        return (60 / _speedKMH);
    }
}
