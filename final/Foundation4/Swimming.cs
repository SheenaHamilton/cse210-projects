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
        return ((Convert.ToDouble(_laps) * 50) / 1000);
    }

    public override double SpeedKMH()
    {
        return (DistanceKM()/ (GetMinutesAsDbl()/60));
    }

    public override double PaceKM()
    {
        return (60 /SpeedKMH());
    }
}
