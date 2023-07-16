using System;

public class Reception:Event
{
    private DateTime _rsvpDate;
    private string _rsvpEmail;

    public Reception(DateTime rsvpDate, string rsvpEmail,string title, string descr, DateTime date, string place, string street, string city, string state,  string country, string postalCode):base(title, descr, date, place, street, city, state,  country, postalCode)
    {
        _rsvpDate = date;
        _rsvpEmail = rsvpEmail;
    }
    public void DisplayFullDetails()
    {

    }
    public void DisplayShortDetails()
    {

    }

}