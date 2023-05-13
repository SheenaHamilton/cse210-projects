 using System;

   /*
    WritingPrompt Class
    Written By:Sheena Hamilton
    Date: May 10, 2023

    Purpose: Creates a list of prompts and returns a random prompt. 

    Attributes:
    _prompts : list
    _randomGenerator: Random


    Behaviors :
    GetPrompt() : string
 */
 public class WritingPrompt
 {
    private List<string> _prompts = new List<string>();
    private Random _randomGenerator = new Random();

    public WritingPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What was your biggest goal for today?");
        _prompts.Add("What could've I done better today?");
        _prompts.Add("Something you learned today?");
    }

    public string GetPrompt()
    { 
        int promptIndex = _randomGenerator.Next(0, _prompts.Count());
        return _prompts[promptIndex];
    }
 }