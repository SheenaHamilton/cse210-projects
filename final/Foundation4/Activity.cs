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

    public double GetMinutesAsDbl()
    {
        return Convert.ToDouble(_minutes);
    }

    public string GetSummary(string type)
    {
        double distanec = DistanceKM();
        string distance = Math.Round(DistanceKM(), 1).ToString();
        string actDate = _date.ToString("dd MMM yyyy");
        string speed = Math.Round(SpeedKMH(), 1).ToString();
        string pace = Math.Round(PaceKM(), 1).ToString();
        string mins = GetMinutes().ToString();

        return ($"{actDate} {type.PadRight(8)} ({mins.PadLeft(3)} min): Distance {distance.PadLeft(4)} km, Speed: {speed.PadLeft(4)} kmh, Pace: {pace.PadLeft(4)} min per km.");
    }

    public abstract double DistanceKM();

    public abstract double SpeedKMH();

    public abstract double PaceKM();
}
