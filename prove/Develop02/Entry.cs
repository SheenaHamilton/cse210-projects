 using System;

  /*
    Entry Class
    Written By:Sheena Hamilton
    Date: May 10, 2023

    Purpose: Creates a single entry.

    Attributes:
    _prompt : string
    _response: string
    _date: string

    Behaviors :
    DisplayEntry() : void
 */
 public class Entry
 {
    public string _prompt;
    public string _response;
    public DateTime _date;

    public void DisplayEntry()
    {
         Console.WriteLine($"Date: {_date} - Prompt: {_prompt} ");
         Console.WriteLine($"{_response}\n");
    }

 }