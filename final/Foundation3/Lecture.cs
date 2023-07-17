using System;

public class Lecture:Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity,string title, string descr, DateTime date, string place, string street, string city, string state,  string country, string postalCode):base(title, descr, date, place, street, city, state,  country, postalCode)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string FullDetails()
    {
        return ($"Event: Lecture \n{StandardDetails()}\nSpeaker: {_speaker}\nEvent Capacity: {_capacity}");
    }

    public string ShortDetails()
    {
        return ($"Event: Lecture\n{BasicInfo()}");
    }
}