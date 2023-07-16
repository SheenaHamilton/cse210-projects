using System;

public class Event
{

    private string _title;
    private string _description;
    private DateTime _date;
    private Address _address;

    public Event(string title, string descr, DateTime date, string place, string street, string city, string state,  string country, string postalCode)
    {
        _title = title;
        _description = descr;
        _date = date;
        _address = new Address(place,street,city,state,country, postalCode);
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public DateTime GetDateandTime()
    {
        return _date;
    }
    public string GetTime()
    {
        return  _date.ToShortTimeString().ToString();
    }
    public void DisplayStandardMessage()
    {
        Console.WriteLine($"{_title}\n{_description}\n{_date.ToString("dddd, MMMM dd, yyyy")} at {GetTime()}\n{_address.GetFormattedAddress()}");
    }

}