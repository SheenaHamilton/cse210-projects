using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public string GetSummary()
    {
        return "";
    }

    public abstract double DistanceKM();

    public abstract double SpeedKMH();

    public abstract double PaceKM();
}
