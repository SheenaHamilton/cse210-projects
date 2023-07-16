using System;

public class Outdoor:Event
{
    private string _weatherStatement;

    public Outdoor(string weather, string title, string descr, DateTime date, string place, string street, string city, string state,  string country, string postalCode):base(title, descr, date, place, street, city, state,  country, postalCode)
    {
        _weatherStatement = weather;
    }
    public void DisplayFullDetails()
    {

    }
    public void DisplayShortDetails()
    {

    }

}